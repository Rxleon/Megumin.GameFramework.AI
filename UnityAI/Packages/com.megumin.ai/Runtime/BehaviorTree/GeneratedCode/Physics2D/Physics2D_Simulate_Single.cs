﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：Megumin.GameFramework.AI.BehaviorTree.Editor.NodeGeneraotr
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [DisplayName("Physics2D_Simulate")]
    [Category("Unity/Physics2D")]
    [AddComponentMenu("Simulate(Single)")]
    public sealed class Physics2D_Simulate_Single : ConditionDecorator
    {
        [Space]
        public Megumin.Binding.RefVar_Float step;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = UnityEngine.Physics2D.Simulate(step);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }
    }
}




