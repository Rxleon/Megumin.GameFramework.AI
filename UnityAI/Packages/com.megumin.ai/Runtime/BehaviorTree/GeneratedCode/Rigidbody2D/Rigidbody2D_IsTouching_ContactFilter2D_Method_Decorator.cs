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
    [Icon("d_Rigidbody2D Icon")]
    [DisplayName("Rigidbody2D_IsTouching")]
    [Category("UnityEngine/Rigidbody2D")]
    [AddComponentMenu("IsTouching(ContactFilter2D)")]
    public sealed class Rigidbody2D_IsTouching_ContactFilter2D_Method_Decorator : ConditionDecorator<UnityEngine.Rigidbody2D>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.ContactFilter2D> contactFilter;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = ((UnityEngine.Rigidbody2D)MyAgent).IsTouching(contactFilter);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

    }
}




