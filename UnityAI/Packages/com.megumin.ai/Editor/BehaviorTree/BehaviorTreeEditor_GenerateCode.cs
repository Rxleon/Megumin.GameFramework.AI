﻿using System;
using System.Collections;
using System.Collections.Generic;
using Megumin.Reflection;
using Megumin.Serialization;
using UnityEditor;

namespace Megumin.GameFramework.AI.BehaviorTree.Editor
{
    partial class BehaviorTreeEditor
    {
        //TODO, 重构代码，不然后面还要改
        public void GenerateCode()
        {
            //BehaviorTreeAsset_1_1 behaviorTree = CurrentAsset.AssetObject as BehaviorTreeAsset_1_1;
            BehaviorTree tree = TreeView.Tree;

            if (tree == null)
            {
                return;
            }

            CSCodeGenerator generator = new();


            generator.Push($"using System;");
            generator.Push($"using Megumin.Serialization;");
            generator.PushBlankLines();

            generator.Push($"namespace Megumin.GameFramework.AI.BehaviorTree");
            using (generator.NewScope)
            {
                generator.Push($"public sealed partial class $(ClassName) : BehaviorTreeCreator");
                using (generator.NewScope)
                {
                    GenerateInitMethod(generator, tree);
                }
            }

            generator.Macro["$(ClassName)"] =
                BehaviorTreeCreator.GetCreatorTypeName(tree.Asset.name, tree.GUID);
            generator.Macro["$(TreeName)"] = tree.Asset.name;

            string filePath = $"Assets/{tree.Asset.name}_Gene.cs";
            generator.Generate(filePath);

            //Open
            AssetDatabase.ImportAsset(filePath, ImportAssetOptions.ForceUpdate);
            var script = AssetDatabase.LoadAssetAtPath<MonoScript>(filePath);
            AssetDatabase.OpenAsset(script);
        }

        public void GenerateInitMethod(CSCodeGenerator generator, BehaviorTreeAsset_1_1 behaviorTree)
        {
            generator.Push($"static readonly Unity.Profiling.ProfilerMarker instantiateMarker = new(\"$(TreeName)_Init\");");
            generator.Push($"public override BehaviorTree Instantiate(InitOption initOption, IRefFinder refFinder = null)");
            using (generator.NewScope)
            {
                generator.Push($"using var profiler = instantiateMarker.Auto();");
                generator.PushBlankLines();

                generator.Push($"if (initOption == null)");
                using (generator.NewScope)
                {
                    generator.Push($"return null;");
                }
                generator.PushBlankLines();

                generator.Push($"BehaviorTree tree = new();");
                generator.Push($"tree.GUID = \"{behaviorTree.GUID}\";");
                generator.Push($"tree.RootTree = tree;");
                generator.Push($"tree.InitOption = initOption;");
                generator.PushBlankLines();


                generator.Push("//生成节点");
                foreach (var item in behaviorTree.nodes)
                {
                    DeclareObj(generator, item);
                }

                generator.PushBlankLines();

                generator.Push("//生成装饰器");
                foreach (var item in behaviorTree.decorators)
                {
                    DeclareObj(generator, item);
                }
                generator.PushBlankLines();

                generator.Push("//生成ref obj");
                foreach (var item in behaviorTree.refObjs)
                {
                    DeclareObj(generator, item);
                }
                generator.PushBlankLines();

                generator.Push("//反序列化 nodes");
                foreach (var item in behaviorTree.nodes)
                {
                    Deserialize(generator, item);
                }
                generator.PushBlankLines();

                generator.Push("//反序列化 decorators");
                foreach (var item in behaviorTree.decorators)
                {
                    Deserialize(generator, item);
                }
                generator.PushBlankLines();

                //generator.Push("//反序列化 ref obj");
                //foreach (var item in behaviorTree.refObjs)
                //{
                //    Deserialize(generator, item);
                //}
                //generator.PushBlankLines();

                generator.Push($"return tree;");
            }
        }

        class DeclaredObject
        {
            public object Instance { get; set; }
            public string VarName { get; set; }
            public string RefName { get; set; }
        }

        public void GenerateInitMethod(CSCodeGenerator generator, BehaviorTree tree)
        {
            generator.Push($"static readonly Unity.Profiling.ProfilerMarker instantiateMarker = new(\"$(TreeName)_Init\");");
            generator.Push($"public override BehaviorTree Instantiate(InitOption initOption, IRefFinder refFinder = null)");
            using (generator.NewScope)
            {
                generator.Push($"using var profiler = instantiateMarker.Auto();");
                generator.PushBlankLines();

                generator.Push($"if (initOption == null)");
                using (generator.NewScope)
                {
                    generator.Push($"return null;");
                }
                generator.PushBlankLines();

                generator.Push($"//创建 树实例");
                generator.Push($"BehaviorTree tree = new();");
                generator.Push($"tree.GUID = \"{tree.GUID}\";");
                generator.Push($"tree.RootTree = tree;");
                generator.Push($"tree.InitOption = initOption;");
                generator.PushBlankLines();

                generator.Push($"//创建 引用查找器");
                generator.Push($"RefFinder finder = new();");
                generator.Push($"finder.Parent = refFinder;");
                generator.Push($"tree.RefFinder = finder;");
                generator.PushBlankLines();

                //Dictionary<object, string> declaredObj = new();
                Dictionary<object, DeclaredObject> declaredObjs = new();

                Dictionary<object, DeclaredObject> varis = new();
                Dictionary<object, DeclaredObject> nodes = new();
                Dictionary<object, DeclaredObject> decos = new();

                Queue<DeclaredObject> needSetMember = new();

                //缓存所有已知引用对象
                DeclaredObject treeObj = new();
                treeObj.Instance = tree;
                treeObj.VarName = SafeVarName(tree.GUID);
                treeObj.RefName = tree.GUID;
                declaredObjs.Add(tree, treeObj);

                generator.Push($"//添加树实例到引用查找器");
                generator.Push($"finder.RefDic.Add({tree.GUID.ToCodeString()}, tree);");
                generator.PushBlankLines();


                void DeclareObj(string refName, object obj)
                {
                    string varName = SafeVarName(refName);
                    if (declaredObjs.TryGetValue(obj, out var variableName))
                    {
                        //generator.Push($"var {varName} = {variableName};");
                    }
                    else
                    {
                        DeclaredObject dclaredObject = new();
                        dclaredObject.Instance = obj;
                        dclaredObject.VarName = varName;
                        dclaredObject.RefName = refName;

                        generator.PushBlankLines();
                        generator.Push($"var {varName} = new {obj.GetType().ToCodeString()}();");
                        generator.Push($"finder.RefDic.Add({refName.ToCodeString()}, {varName});");
                        //generator.PushBlankLines();

                        declaredObjs.Add(obj, dclaredObject);
                        needSetMember.Enqueue(dclaredObject);

                        DeclareObjMember(refName, obj);
                    }
                }

                void DeclareObjMember(string refName, object obj)
                {
                    foreach (var (memberName, memberValue, memberType) in obj.GetSerializeMembers())
                    {
                        if (memberType.IsPrimitive || memberValue is string || memberValue == null)
                        {
                            //generator.Push($"{varName}.{memberName} = {memberValue.ToCodeString()};");
                        }
                        else
                        {
                            //引用对象声明
                            var refMemberName = $"{refName}.{memberName}";
                            DeclareObj(refMemberName, memberValue);
                        }
                    }
                }

                generator.Push($"//创建 参数表参数实例");
                foreach (var variable in tree.Variable.Table)
                {
                    DeclareObj(variable.RefName, variable);
                    varis.Add(variable, declaredObjs[variable]);
                }
                generator.PushBlankLines();

                generator.Push($"//创建 节点，装饰器，普通对象");
                foreach (var node in tree.AllNodes)
                {
                    DeclareObj(node.GUID, node);
                    nodes.Add(node, declaredObjs[node]);

                    foreach (var decorator in node.Decorators)
                    {
                        DeclareObj(decorator.GUID, decorator);
                        decos.Add(decorator, declaredObjs[decorator]);
                    }

                    generator.PushBlankLines();
                }
                generator.Push($"//以上创建 {nodes.Count} 节点");
                generator.Push($"//以上创建 {decos.Count} 装饰器");
                generator.Push($"//以上创建 {declaredObjs.Count - nodes.Count - decos.Count - varis.Count - 1} 普通对象");
                generator.PushBlankLines();


                HashSet<object> alrendySetMember = new();
                using (generator.GetRegionScope($"初始化成员值"))
                {
                    generator.Push($"//初始化成员值");
                    while (needSetMember.Count > 0)
                    {
                        var v = needSetMember.Dequeue();
                        var item = v.Instance;
                        var varName = v.VarName;

                        if (alrendySetMember.Contains(item))
                        {
                            continue;
                        }

                        foreach (var (memberName, memberValue, memberType) in item.GetSerializeMembers())
                        {
                            if (item is IList)
                            {
                                if (memberType.IsPrimitive || memberValue is string || memberValue == null)
                                {
                                    generator.Push($"{varName}.Insert({memberName}, {memberValue.ToCodeString()});");
                                }
                                else
                                {
                                    //引用对象声明
                                    if (declaredObjs.TryGetValue(memberValue, out var declaredObject))
                                    {
                                        var refObjName = SafeVarName($"ref_{declaredObject.RefName}");
                                        generator.Push($"if (finder.TryGetRefValue<{memberType.ToCodeString()}>(");
                                        generator.Push($"{declaredObject.RefName.ToCodeString()},", 1);
                                        generator.Push($"out var {refObjName}))", 1);

                                        generator.BeginScope();
                                        generator.Push($"{varName}.Insert({memberName}, {refObjName});");
                                        generator.EndScope();
                                        //generator.Push($"else");
                                        //generator.BeginScope();
                                        //generator.Push($"{varName}.Insert({memberName}, {declaredObject.VarName});");
                                        //generator.EndScope();
                                        generator.PushBlankLines();
                                    }
                                    else
                                    {
                                        generator.Push($"//TODO : {memberName}");
                                    }
                                }
                            }
                            else
                            {
                                if (memberType.IsPrimitive || memberValue is string || memberValue == null)
                                {
                                    generator.Push($"{varName}.{memberName} = {memberValue.ToCodeString()};");
                                }
                                else
                                {
                                    //引用对象声明
                                    if (declaredObjs.TryGetValue(memberValue, out var declaredObject))
                                    {
                                        var refObjName = SafeVarName($"ref_{declaredObject.RefName}");
                                        generator.Push($"if (finder.TryGetRefValue<{memberType.ToCodeString()}>(");
                                        generator.Push($"{declaredObject.RefName.ToCodeString()},", 1);
                                        generator.Push($"out var {refObjName}))", 1);

                                        generator.BeginScope();
                                        generator.Push($"{varName}.{memberName} = {refObjName};");
                                        generator.EndScope();
                                        //generator.Push($"else");
                                        //generator.BeginScope();
                                        //generator.Push($"{varName}.{memberName} = {declaredObject.VarName};");
                                        //generator.EndScope();
                                        generator.PushBlankLines();
                                    }
                                    else
                                    {
                                        generator.Push($"//TODO : {memberName}");
                                    }
                                }
                            }
                        }

                        alrendySetMember.Add(item);

                        generator.PushBlankLines();
                    }
                }

                using (generator.GetRegionScope("添加实例到树"))
                {
                    //generator.Push($"//添加到集合");
                    //generator.PushBlankLines();

                    generator.Push($"//添加参数");
                    foreach (var item in varis)
                    {
                        generator.Push($"tree.InitAddVariable({item.Value.VarName});");
                    }
                    generator.Push($"//以上添加到树 {varis.Count} 参数实例");
                    generator.PushBlankLines();

                    generator.Push($"//添加普通对象");
                    //先处理非节点装饰器对象
                    int objCount = 0;
                    foreach (var item in alrendySetMember)
                    {
                        if (varis.ContainsKey(item))
                        {
                            continue;
                        }

                        if (nodes.ContainsKey(item))
                        {
                            continue;
                        }

                        if (decos.ContainsKey(item))
                        {
                            continue;
                        }

                        generator.Push($"tree.InitAddTreeRefObj({declaredObjs[item].VarName});");
                        objCount++;
                    }
                    generator.Push($"//以上添加到树 {objCount} 普通对象");
                    generator.PushBlankLines();

                    generator.Push($"//添加装饰器");
                    foreach (var item in decos)
                    {
                        generator.Push($"tree.InitAddTreeRefObj({item.Value.VarName});");
                    }
                    generator.Push($"//以上添加到树 {decos.Count} 装饰器");
                    generator.PushBlankLines();

                    generator.Push($"//添加节点");
                    foreach (var item in nodes)
                    {
                        generator.Push($"tree.InitAddTreeRefObj({item.Value.VarName});");
                    }
                    generator.Push($"//以上添加到树 {nodes.Count} 节点");
                    generator.PushBlankLines();

                }

                using (generator.GetRegionScope($"设置开始节点 和 装饰器Owner"))
                {
                    generator.Push($"tree.StartNode = {declaredObjs[tree.StartNode].VarName};");

                    foreach (var item in decos)
                    {
                        generator.Push($"{item.Value.VarName}.Owner = {declaredObjs[(item.Key as IDecorator).Owner].VarName};");
                    }
                }

                generator.Push($"tree.UpdateNodeIndexDepth();");

                generator.PushWrapBlankLines($"PostInit(initOption, tree);");

                generator.Push($"return tree;");
            }
        }

        public void Deserialize(CSCodeGenerator generator, ObjectData item)
        {
            using (generator.GetRegionScope(item.Name))
            {
                var varName = SafeVarName(item.Name);
                if (item.Member != null)
                {
                    foreach (var memberData in item.Member)
                    {
                        using (generator.NewScope)
                        {
                            generator.Push($"//SetMember {memberData.Name}");

                            var resultString = $"//{memberData.Type} can not parse!";

                            if (memberData.Type == ObjectData.NullType)
                            {
                                resultString = "null";
                            }
                            else if (memberData.Type == ObjectData.RefType)
                            {
                                resultString = SafeVarName(memberData.Value);
                            }
                            else
                            {
                                if (StringFormatter.TryDeserialize(memberData.Type, memberData.Value, out var value))
                                {
                                    resultString = value.ToCodeString();
                                }
                            }

                            generator.Push($"{varName}.{memberData.Name} = {resultString};");
                        }

                        generator.PushBlankLines();
                    }
                }
            }
        }

        /// <summary>
        /// 声明对象
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="item"></param>
        public void DeclareObj(CSCodeGenerator generator, ObjectData item)
        {
            var varName = SafeVarName(item.Name);
            if (Megumin.Reflection.TypeCache.TryGetType(item.Type, out var type))
            {
                generator.Push($"var {varName} = new {type.ToCodeString()}();");
            }
            else
            {
                generator.Push($"//{item.Type} can not parse!");
            }
        }

        public string SafeVarName(string refName)
        {
            var name = refName;
            if (name.StartsWith("temp_") == false)
            {
                name = $"temp_{refName}";
            }

            name = name.Replace('-', '_');
            name = name.Replace('.', '_');
            return name;
        }
    }
}


