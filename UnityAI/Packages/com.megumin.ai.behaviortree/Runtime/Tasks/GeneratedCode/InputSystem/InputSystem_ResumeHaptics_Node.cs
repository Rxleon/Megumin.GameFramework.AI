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
    [DisplayName("InputSystem_ResumeHaptics")]
    [Category("UnityEngine/InputSystem")]
    [AddComponentMenu("ResumeHaptics")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class InputSystem_ResumeHaptics_Node : BTActionNode
    {
        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.InputSystem.InputSystem.ResumeHaptics();
            return Status.Succeeded;
        }
    }
}

#endif




