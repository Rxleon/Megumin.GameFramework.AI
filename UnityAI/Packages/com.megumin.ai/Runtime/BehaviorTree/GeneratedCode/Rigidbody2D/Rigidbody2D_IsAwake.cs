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
    [Icon("Rigidbody2D Icon")]
    [DisplayName("Rigidbody2D_IsAwake")]
    [Category("Unity/Rigidbody2D")]
    [AddComponentMenu("IsAwake")]
    public sealed class Rigidbody2D_IsAwake : ConditionDecorator<UnityEngine.Rigidbody2D>
    {

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = ((UnityEngine.Rigidbody2D)MyAgent).IsAwake();

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }
    }
}




