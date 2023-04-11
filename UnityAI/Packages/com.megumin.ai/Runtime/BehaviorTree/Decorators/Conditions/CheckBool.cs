﻿using System;
using Megumin.Reflection;
using UnityEngine.Serialization;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    //[FormerlySerializedAs("CheckBool")]
    [Serializable]
    [SerializationAlias("CheckBool")]
    public class CheckBool : ConditionDecorator, IConditionDecorator
    {
        public RefVar_Bool Value;

        protected override bool OnCheckCondition(BTNode container)
        {
            return Value;
        }
    }
}

