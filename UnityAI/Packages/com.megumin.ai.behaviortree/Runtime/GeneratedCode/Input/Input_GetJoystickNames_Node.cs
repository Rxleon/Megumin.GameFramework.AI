﻿///********************************************************************************************************************************
///The code on this page is generated by the code generator, do not manually modify.
///CodeGenerator: Megumin.CSCodeGenerator.  Version: 1.0.1
///CodeGenericBy: Megumin.AI.BehaviorTree.Editor.NodeGenerator
///CodeGenericSourceFilePath: Packages/com.megumin.ai/Editor/BehaviorTree/Generator/NodeGeneraotr.asset
///********************************************************************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.AI.BehaviorTree
{
    [Icon("standaloneinputmodule icon")]
    [DisplayName("Input_GetJoystickNames")]
    [Category("UnityEngine/Input")]
    [AddComponentMenu("GetJoystickNames")]
    public sealed class Input_GetJoystickNames_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_String_Array SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Input.GetJoystickNames();

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}



