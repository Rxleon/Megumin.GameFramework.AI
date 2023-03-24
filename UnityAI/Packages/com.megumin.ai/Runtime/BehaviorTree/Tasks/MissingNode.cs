﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    /// <summary>
    /// 用于反序列化失败
    /// </summary>
    [Category("Debug")]
    public class MissingNode : ActionTaskNode
    {
        public override bool Enabled
        {
            get => false;
            internal set => throw new NotSupportedException();
        }
    }
}
