﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：Megumin.GameFramework.AI.BehaviorTree.Editor.NodeGenerator
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [Icon("d_Animator Icon")]
    [DisplayName("Animator_hasBoundPlayables")]
    [Category("UnityEngine/Animator")]
    [AddComponentMenu("hasBoundPlayables")]
    public sealed class Animator_hasBoundPlayables_Decorator : ConditionDecorator<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = ((UnityEngine.Animator)MyAgent).hasBoundPlayables;

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

    }
}




