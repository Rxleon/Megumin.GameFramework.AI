﻿using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    public class Loop : OneChildNode
    {
        int loopCount = 2;

        int cur = 0;
        protected override Status OnTick()
        {
            var res = child.Tick();
            if (res == Status.Succeeded || res == Status.Failed)
            {
                cur++;
                Debug.Log($"loop: complete {cur}");
                if (cur >= loopCount)
                {
                    return res;
                }
            }

            return Status.Running;
        }
    }
}