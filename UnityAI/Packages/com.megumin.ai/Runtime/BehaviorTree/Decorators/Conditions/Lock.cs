﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Megumin.Binding;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    /// <summary>
    /// 保证同名锁同一时间只能有一个Task执行
    /// </summary>
    internal class Lock : ConditionDecorator, IPostDecorator, IPreDecorator, IConditionDecorator
    {
        public RefVar<string> lockName;
        public Status AfterNodeExit(Status result, BTNode bTNode)
        {
            Tree.LockDic.Remove(lockName);
            return result;
        }

        public void BeforeNodeEnter(BTNode bTNode)
        {
            if (string.IsNullOrEmpty(lockName))
            {
                lockName = bTNode.InstanceID;
            }

            Tree.LockDic.Add(lockName, this);
        }

        protected override bool OnCheckCondition(BTNode container)
        {
            Tree.LockDic.TryGetValue(lockName, out var result);
            return result == this;
        }
    }
}