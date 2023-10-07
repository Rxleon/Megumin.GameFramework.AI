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
    [DisplayName("InputSystem_RegisterLayout")]
    [Category("UnityEngine/InputSystem")]
    [AddComponentMenu("RegisterLayout(String, String, Nullable`1)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class InputSystem_RegisterLayout_String_String_Nullable_1_InputDeviceMatcher_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_String json;
        public Megumin.Binding.RefVar_String name;
        public Megumin.Binding.RefVar<System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>> matches;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.InputSystem.InputSystem.RegisterLayout(json, name, matches);
            return Status.Succeeded;
        }
    }
}

#endif




