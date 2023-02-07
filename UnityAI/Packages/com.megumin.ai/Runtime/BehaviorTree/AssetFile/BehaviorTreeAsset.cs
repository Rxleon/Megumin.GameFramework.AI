﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Codice.CM.WorkspaceServer.Tree.GameUI.Checkin.Updater;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    public class BehaviorTreeAsset : ScriptableObject//, ISerializationCallbackReceiver
    {
        public string test = "行为树SO资产";
        public List<NodeAsset> Nodes = new List<NodeAsset>();

        [Serializable]
        public class NodeAsset
        {
            public string TypeName;
            public string GUID;
            public bool IsStartNode;
            public NodeMeta Meta;
            public List<string> ChildNodes = new List<string>();
        }

        public bool SaveTree(BehaviorTree tree)
        {
            if (tree == null)
            {
                return false;
            }

            Nodes.Clear();
            foreach (var node in tree.AllNodes.OrderBy(elem => elem.GUID))
            {
                var nodeAsset = new NodeAsset();
                nodeAsset.TypeName = node.GetType().FullName;
                nodeAsset.GUID = node.GUID;
                nodeAsset.IsStartNode = node == tree.StartNode;
                nodeAsset.Meta = node.Meta;
                Nodes.Add(nodeAsset);
            }

            if (Nodes.Count > 0 && !Nodes.Any(elem => elem.IsStartNode))
            {
                //没有设置开始节点时，将最上面的节点设置为开始节点。
                var upnode = Nodes.OrderBy(elem => elem.Meta.y).FirstOrDefault();
                upnode.IsStartNode = true;
            }

            return true;
        }

        public BehaviorTree CreateTree()
        {
            var tree = new BehaviorTree();
            foreach (var nodeAsset in Nodes)
            {
                var nodeType = Type.GetType(nodeAsset.TypeName);
                if (nodeType.IsSubclassOf(typeof(BTNode)))
                {
                    var node = Activator.CreateInstance(nodeType) as BTNode;
                    if (node != null)
                    {
                        node.GUID = nodeAsset.GUID;
                        node.Meta = nodeAsset.Meta;
                        node.InstanceID = Guid.NewGuid().ToString();
                        tree.AddNode(node);
                        if (nodeAsset.IsStartNode)
                        {
                            tree.StartNode = node;
                        }
                    }
                    else
                    {
                        Debug.LogError($"无法创建的节点{nodeAsset.TypeName}");
                        continue;
                    }
                }
                else
                {
                    Debug.LogError($"无法识别的节点{nodeAsset.TypeName}");
                    continue;
                }
            }


            tree.Asset = this;
            //Load1(tree);
            return tree;
        }

        private void LoadLast(BehaviorTree tree)
        {
            var wait = tree.AddNode<Wait>();
            var log = tree.AddNode<Log>();
            var seq = tree.AddNode<Sequence>();
            seq.children.Add(wait);
            seq.children.Add(log);

            var loop = new Loop();
            seq.Derators = new object[] { loop };
            //var loop = new Repeater();
            //loop.child = seq;

            var check = new CheckBool();
            var remap = new Remap();
            log.Derators = new object[] { check, remap };
            tree.StartNode = seq;
        }

        private void Load4(BehaviorTree tree)
        {
            var wait = new Wait();
            var log = new Log();
            var seq = new Sequence();
            seq.children.Add(wait);
            seq.children.Add(log);

            var loop = new Repeater();
            loop.child = seq;

            var check = new CheckBool();
            var remap = new Remap();
            log.Derators = new object[] { check, remap };
            tree.StartNode = loop;
        }

        private void Load3(BehaviorTree tree)
        {
            var wait = new Wait();
            var log = new Log();
            var seq = new Sequence();
            seq.children.Add(wait);
            seq.children.Add(log);

            var loop = new Repeater();
            loop.child = seq;

            var check = new CheckBool();
            log.Derators = new object[] { check };
            tree.StartNode = loop;
        }

        private void Load2(BehaviorTree tree)
        {
            var wait = new Wait();
            var log = new Log();
            var seq = new Sequence();
            seq.children.Add(wait);
            seq.children.Add(log);

            var loop = new Repeater();
            loop.child = seq;

            tree.StartNode = loop;
        }

        private void Load1(BehaviorTree tree)
        {
            var wait = tree.AddNode<Wait>();
            var log = tree.AddNode<Log>();
            var seq = tree.AddNode<Sequence>();
            seq.children.Add(wait);
            seq.children.Add(log);

            tree.StartNode = seq;
        }

        public void OnBeforeSerialize()
        {
            this.LogFuncName();
        }

        public void OnAfterDeserialize()
        {
            //this.LogFuncName();
        }
    }
}
