﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：Megumin.GameFramework.AI.BehaviorTree.Editor.NodeGenerator
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

#if ENABLE_INPUT_SYSTEM

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [DisplayName("InputSystem_TryFindMatchingLayout")]
    [Category("UnityEngine/InputSystem")]
    [AddComponentMenu("TryFindMatchingLayout(InputDeviceDescription)")]
    public sealed class InputSystem_TryFindMatchingLayout_InputDeviceDescription_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.InputSystem.Layouts.InputDeviceDescription> deviceDescription;

        [Space]
        public Megumin.Binding.RefVar_String SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.InputSystem.InputSystem.TryFindMatchingLayout(deviceDescription);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}

#endif




