﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Megumin.Binding;
using Megumin.Reflection;
using Megumin.Serialization;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    public partial class BehaviorTreeAsset_1_1 : ScriptableObject, IBehaviorTreeAsset
    {
        public string Version = new Version(1, 1, 0).ToString();
        [field: ContextMenuItem("ChangeGUID", "ChangeGUID")]
        [field: SerializeField]
        public string GUID { get; set; } = Guid.NewGuid().ToString();
        [field: SerializeField]
        public string StartNodeGUID { get; set; } = "";
        public bool UseSerializeReferenceGeneric = false;
        public List<UnityObjectData> UnityObjectRef;
        public List<ObjectData> variables;
        public List<ObjectData> nodes;
        public List<ObjectData> decorators;
        public List<ObjectData> treeElements;


        public bool SaveTree(BehaviorTree tree)
        {
            if (tree == null)
            {
                return false;
            }

            if (!Guid.TryParse(tree.GUID, out var _))
            {
                tree.GUID = Guid.NewGuid().ToString();
            }
            GUID = tree.GUID;
            StartNodeGUID = tree.StartNode?.GUID;

            Dictionary<object, string> cacheRef = new();
            Stack<(string name, object value)> needSerialization = new();
            List<UnityObjectData> objRefs = new();

            //缓存所有已知引用对象
            cacheRef.Add(tree, tree.GUID);

            foreach (var variable in tree.Variable.Table)
            {
                cacheRef.Add(variable, variable.RefName);
                needSerialization.Push((variable.RefName, variable));
            }

            foreach (var node in tree.AllNodes)
            {
                cacheRef.Add(node, node.GUID);

                foreach (var decorator in node.Decorators)
                {
                    cacheRef.Add(decorator, decorator.GUID);
                }
            }

            {
                //序列化参数表
                List<ObjectData> variableDatas = new();
                while (needSerialization.Count > 0)
                {
                    var item = needSerialization.Pop();
                    ObjectData data = new ObjectData();
                    if (data.TrySerialize(item.name, item.value, needSerialization, objRefs, cacheRef, GetSerializeMembers))
                    {
                        variableDatas.Add(data);
                    }
                }

                variableDatas.Sort();
                variables = variableDatas;
            }

            {
                //序列化节点
                List<ObjectData> treeElementData = new();
                List<ObjectData> nodeDatas = new();
                List<ObjectData> decoratorDatas = new();

                void SaveNode(BTNode node)
                {
                    ObjectData nodeData = new ObjectData();
                    if (nodeData.TrySerialize(node.GUID, node, needSerialization, objRefs, cacheRef, GetSerializeMembers))
                    {
                        nodeDatas.Add(nodeData);
                    }
                }

                void SaveDeco(ITreeElement decorator)
                {
                    ObjectData decoratorData = new ObjectData();
                    if (decoratorData.TrySerialize(decorator.GUID, decorator, needSerialization, objRefs, cacheRef, GetSerializeMembers))
                    {
                        decoratorDatas.Add(decoratorData);
                    }
                }

                foreach (var node in tree.AllNodes)
                {
                    SaveNode(node);

                    foreach (var decorator in node.Decorators)
                    {
                        SaveDeco(decorator);
                    }
                }

                nodeDatas.Sort();
                nodes = nodeDatas;

                decoratorDatas.Sort();
                decorators = decoratorDatas;

                while (needSerialization.Count > 0)
                {
                    var item = needSerialization.Pop();
                    ObjectData data = new ObjectData();
                    if (data.TrySerialize(item.name, item.value, needSerialization, objRefs, cacheRef, GetSerializeMembers))
                    {
                        treeElementData.Add(data);
                    }
                }

                treeElementData.Sort();
                treeElements = treeElementData;
            }


            UnityObjectRef = objRefs;
            return true;


        }

        /// <summary>
        /// 装饰器，子节点直接引用序列化，自动关联引用。不用额外处理
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        /// <returns></returns>
        public IEnumerable<(string MemberName, object MemberValue, Type MemberType)>
            GetSerializeMembers<T>(T instance)
        {
            foreach (var item in instance.GetSerializeMembers())
            {
                if (instance is BehaviorTreeElement treeElement)
                {
                    if (item.MemberValue == treeElement.Tree)
                    {
                        continue;
                    }
                }
                yield return item;
            }
        }

        public UnityEngine.Object AssetObject => this;

        public BehaviorTree Instantiate(InitOption initOption, IRefFinder refFinder = null)
        {
            if (initOption == null)
            {
                return null;
            }

            BehaviorTree tree = new();
            tree.GUID = GUID;
            tree.InstanceGUID = Guid.NewGuid().ToString();
            if (!Guid.TryParse(tree.GUID, out var _))
            {
                tree.GUID = Guid.NewGuid().ToString();
            }

            tree.RootTree = tree;
            tree.InitOption = initOption;

            if (UseSerializeReferenceGeneric)
            {
                //多态序列化 + 泛型
                //
                Debug.Log("至少需要unity2023");
                return tree;
            }

            RefFinder finder = new();
            finder.Parent = refFinder;

            tree.RefFinder = finder;

            finder.RefDic.Add(tree.GUID, tree);

            //缓存Unity引用对象
            if (UnityObjectRef != null)
            {
                foreach (var item in UnityObjectRef)
                {
                    finder.RefDic.Add(item.Name, item.Ref);
                }
            }

            //先创建引用实例

            //创建参数表实例
            Dictionary<ObjectData, object> variableCache = new();
            if (variables != null)
            {
                foreach (var item in variables)
                {
                    if (string.IsNullOrEmpty(item.Name))
                    {
                        Debug.LogError($"意外错误，没有引用名字");
                        continue;
                    }
                    if (item.TryCreateInstance(out var instance))
                    {
                        finder.RefDic.Add(item.Name, instance);
                        variableCache.Add(item, instance);
                    }
                }
            }


            //创建节点实例
            Dictionary<ObjectData, object> treeObjCache = new();
            if (nodes != null)
            {
                foreach (var item in nodes)
                {
                    if (string.IsNullOrEmpty(item.Name))
                    {
                        Debug.LogError($"意外错误，没有引用名字");
                        continue;
                    }

                    if (item.TryCreateInstance(out var instance))
                    {

                    }
                    else
                    {
                        //使用MissingNode代替
                        MissingNode missing = new();
                        missing.MissType = item.Type;
                        missing.GUID = item.Name;
                        missing.OrignalData = item;
                        instance = missing;
                    }

                    finder.RefDic.Add(item.Name, instance);
                    treeObjCache.Add(item, instance);
                }
            }

            if (decorators != null)
            {
                foreach (var item in decorators)
                {
                    if (string.IsNullOrEmpty(item.Name))
                    {
                        Debug.LogError($"意外错误，没有引用名字");
                        continue;
                    }

                    if (item.TryCreateInstance(out var instance))
                    {

                    }
                    else
                    {
                        //使用MissingDecorator代替
                        MissingDecorator missing = new();
                        missing.MissType = item.Type;
                        missing.GUID = item.Name;
                        missing.OrignalData = item;
                        instance = missing;
                    }

                    finder.RefDic.Add(item.Name, instance);
                    treeObjCache.Add(item, instance);
                }
            }

            if (treeElements != null)
            {
                foreach (var item in treeElements)
                {
                    if (string.IsNullOrEmpty(item.Name))
                    {
                        Debug.LogError($"意外错误，没有引用名字");
                        continue;
                    }
                    if (item.TryCreateInstance(out var instance))
                    {
                        finder.RefDic.Add(item.Name, instance);
                        treeObjCache.Add(item, instance);
                    }
                }
            }

            //反序列化
            //反序列化参数表
            foreach (var item in variableCache)
            {
                if (item.Key.TryDeserialize(item.Value, finder))
                {
                    if (item.Value is IRefable variable)
                    {
                        tree.Variable.Table.Add(variable);
                    }
                }
            }

            //反序列化树节点 节点父子关系和装饰器关系自动关联
            foreach (var item in treeObjCache)
            {
                if (item.Key.TryDeserialize(item.Value, finder))
                {
                    if (item.Value is BTNode node)
                    {
                        tree.AddNode(node);
                        if (node.GUID == StartNodeGUID)
                        {
                            tree.StartNode = node;
                        }
                    }

                    if (item.Value is BehaviorTreeElement element)
                    {
                        element.Tree = tree;
                    }
                }
            }

            tree.Asset = this;
            return tree;
        }

        [Editor]
        public void ChangeGUID()
        {
            GUID = Guid.NewGuid().ToString();
#if UNITY_EDITOR
            UnityEditor.EditorUtility.SetDirty(this);
            UnityEditor.AssetDatabase.SaveAssetIfDirty(this);
#endif
        }
    }

}

