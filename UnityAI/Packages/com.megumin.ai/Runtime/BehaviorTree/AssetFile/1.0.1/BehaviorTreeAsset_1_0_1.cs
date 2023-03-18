using System;
using System.Collections;
using System.Collections.Generic;
using Megumin.Serialization;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    public partial class BehaviorTreeAsset_1_0_1 : ScriptableObject, IBehaviorTreeAsset
    {
        public List<UnityObjRef> UnityObjectRef;
        public List<ObjData> datas;

        public void Se(BehaviorTree tree)
        {
            Dictionary<object, string> cahce = new();
            Stack<(string name, object value)> needS = new();
            List<UnityObjRef> objRefs = new();

            foreach (var variable in tree.Variable.Table)
            {
                cahce.Add(variable, variable.RefName);
                needS.Push((variable.RefName, variable));
            }

            foreach (var node in tree.AllNodes)
            {
                cahce.Add(node, node.GUID);
                needS.Push((node.GUID, node));

                foreach (var decorator in node.Decorators)
                {
                    cahce.Add(decorator, decorator.GUID);
                    needS.Push((decorator.GUID, decorator));
                }
            }

            List<ObjData> AllSedRefData = new();
            while (needS.Count > 0)
            {
                if (AllSedRefData.Count > 1000)
                {
                    Debug.LogError($"Too Large!!");
                    break;
                }

                var item = needS.Pop();
                ObjData data = new ObjData();
                if (data.TreS(item.name, item.value, needS, objRefs, cahce))
                {
                    AllSedRefData.Add(data);
                }
            }

            AllSedRefData.Sort();
            datas = AllSedRefData;
            UnityObjectRef = objRefs;
        }



        public UnityEngine.Object AssetObject => this;

        public BehaviorTree Instantiate(bool instanceMeta = true)
        {
            return new BehaviorTree();
        }

        public bool SaveTree(BehaviorTree tree)
        {
            Se(tree);
            return true;
        }
    }
}