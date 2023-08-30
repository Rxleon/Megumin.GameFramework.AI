﻿///********************************************************************************************************************************
///The code on this page is generated by the code generator, do not manually modify.
///CodeGenerator: Megumin.CSCodeGenerator.  Version: 1.0.1
///CodeGenericBy: Megumin.AI.BehaviorTree.Editor.NodeGenerator
///CodeGenericSourceFilePath: Packages/com.megumin.ai/Editor/BehaviorTree/Generator/InputSystem.asset
///********************************************************************************************************************************

#if ENABLE_INPUT_SYSTEM

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.AI.BehaviorTree
{
    [DisplayName("InputSystem_RegisterLayoutMatcher")]
    [Category("UnityEngine/InputSystem")]
    [AddComponentMenu("RegisterLayoutMatcher(String, InputDeviceMatcher)")]
    public sealed class InputSystem_RegisterLayoutMatcher_String_InputDeviceMatcher_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_String layoutName;
        public Megumin.Binding.RefVar<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matcher;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.InputSystem.InputSystem.RegisterLayoutMatcher(layoutName, matcher);
            return Status.Succeeded;
        }
    }
}

#endif



