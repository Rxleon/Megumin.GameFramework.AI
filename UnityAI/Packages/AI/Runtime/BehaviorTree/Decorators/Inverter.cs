﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    internal class Inverter : IPostDecirator
    {
        public Status AfterNodeExit(Status result, BTNode bTNode)
        {
            //可能会出现结果是Running的情况，比如有LoopUntil在此之前执行，将结果改成了Running。
            //所以只处理成功和失败两种。
            if (result == Status.Failed)
            {
                return Status.Succeeded;
            }
            else if (result == Status.Succeeded)
            {
                return Status.Failed;
            }

            return result;
        }
    }
}