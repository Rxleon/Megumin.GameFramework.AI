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
    [DisplayName("InputSystem_ResetHaptics")]
    [Category("UnityEngine/InputSystem")]
    [AddComponentMenu("ResetHaptics")]
    public sealed class InputSystem_ResetHaptics_Node : BTActionNode
    {
        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.InputSystem.InputSystem.ResetHaptics();
            return Status.Succeeded;
        }
    }
}

#endif




