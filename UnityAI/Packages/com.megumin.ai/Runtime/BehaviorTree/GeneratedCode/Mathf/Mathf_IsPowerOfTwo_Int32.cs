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
    [Icon("d_collabcreate icon")]
    [DisplayName("Mathf_IsPowerOfTwo")]
    [Category("UnityEngine/Mathf")]
    [AddComponentMenu("IsPowerOfTwo(Int32)")]
    public sealed class Mathf_IsPowerOfTwo_Int32 : ConditionDecorator
    {
        [Space]
        public Megumin.Binding.RefVar_Int value;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = UnityEngine.Mathf.IsPowerOfTwo(value);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }
    }
}



