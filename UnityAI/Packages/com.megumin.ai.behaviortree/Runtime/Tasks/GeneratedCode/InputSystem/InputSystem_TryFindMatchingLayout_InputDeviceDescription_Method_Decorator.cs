﻿///********************************************************************************************************************************
///The code on this page is generated by the code generator, do not manually modify.
///CodeGenerator: Megumin.CSCodeGenerator.  Version: 1.0.2
///CodeGenericBy: Megumin.AI.BehaviorTree.Editor.NodeGenerator
///CodeGenericSourceFilePath: Packages/com.megumin.ai.behaviortree/Editor/Generator/InputSystem.asset
///********************************************************************************************************************************

#if ENABLE_INPUT_SYSTEM

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.AI.BehaviorTree
{
    [DisplayName("InputSystem_TryFindMatchingLayout")]
    [Category("UnityEngine/InputSystem")]
    [AddComponentMenu("TryFindMatchingLayout(InputDeviceDescription)")]
    public sealed class InputSystem_TryFindMatchingLayout_InputDeviceDescription_Method_Decorator : CompareDecorator<string>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.InputSystem.Layouts.InputDeviceDescription> deviceDescription;

        [Space]
        public Megumin.Binding.RefVar_String CompareTo;

        [Space]
        public Megumin.Binding.RefVar_String SaveValueTo;

        public override string GetResult()
        {
            var result = UnityEngine.InputSystem.InputSystem.TryFindMatchingLayout(deviceDescription);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

        public override string GetCompareTo()
        {
            return CompareTo;
        }

    }
}

#endif




