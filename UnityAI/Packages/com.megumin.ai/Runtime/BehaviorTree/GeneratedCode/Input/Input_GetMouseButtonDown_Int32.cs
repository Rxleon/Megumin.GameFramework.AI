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
    [Icon("standaloneinputmodule icon")]
    [DisplayName("Input_GetMouseButtonDown")]
    [Category("UnityEngine/Input")]
    [AddComponentMenu("GetMouseButtonDown(Int32)")]
    public sealed class Input_GetMouseButtonDown_Int32 : ConditionDecorator
    {
        [Space]
        public Megumin.Binding.RefVar_Int button;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = UnityEngine.Input.GetMouseButtonDown(button);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }
    }
}




