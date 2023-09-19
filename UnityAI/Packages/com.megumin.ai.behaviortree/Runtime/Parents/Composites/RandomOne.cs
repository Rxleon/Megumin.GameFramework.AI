﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Megumin.Binding;
using UnityEngine;

namespace Megumin.AI.BehaviorTree
{
    /// <summary>
    /// 加权随机选出一个子节点执行
    /// TODO,抽象随机接口
    /// </summary>
    public class RandomOne : CompositeNode, IDetailable, IDetailAlignable
    {
        [Space]
        public List<int> Priority;

        [ReadOnlyInInspector]
        public int currentRandom = -1;
        BTNode currentChild;

        protected override void OnEnter(object options = null)
        {
            base.OnEnter(options);
            currentChild = null;
            currentRandom = -1;

            if (Children == null || Children.Count == 0)
            {
                return;
            }

            if (Priority == null)
            {
                Priority = new List<int>();
            }

            if (Priority.Count < Children.Count)
            {
                //权重个数少于子节点个数，补充1
                for (int i = Priority.Count; i < Children.Count; i++)
                {
                    Priority[i] = 1;
                }
            }

            currentRandom = GetRandomIndex(Priority);
            if (0 <= currentRandom && currentRandom < Children.Count)
            {
                currentChild = Children[currentRandom];
            }
        }

        /// <summary>
        /// 根据权重选择一个子节点
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int GetRandomIndex(List<int> list)
        {
            var totalWeight = list.Sum();
            var value = Random.Range(0, totalWeight);
            for (int i = 0; i < list.Count; i++)
            {
                value -= list[i];
                if (value < 0)
                {
                    return i;
                }
            }
            return -1;
        }

        protected override Status OnTick(BTNode from, object options = null)
        {
            if (currentChild != null)
            {
                return currentChild.Tick(from, options);
            }
            else
            {
                return Status.Failed;
            }
        }

        public string GetDetail()
        {
            if (Priority != null)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < Priority.Count; i++)
                {
                    int p = Priority[i];
                    sb.Append(p.ToString());
                    if (i < Priority.Count - 1)
                    {
                        sb.Append(" | ");
                    }
                }
                return sb.ToString();
            }
            return null;
        }

        public TextAnchor DetailTextAlign => TextAnchor.MiddleCenter;
    }
}


