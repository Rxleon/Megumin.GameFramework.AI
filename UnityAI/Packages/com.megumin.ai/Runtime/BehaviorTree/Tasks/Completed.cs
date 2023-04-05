﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [Category("Debug")]
    public sealed class Completed : BTActionNode
    {
        public bool Success = true;
        protected override Status OnTick(BTNode from)
        {
            return Success ? Status.Succeeded : Status.Failed;
        }
    }
}
