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
    [Icon("d_DefaultAsset Icon")]
    [DisplayName("InputActionAsset_LoadFromJson")]
    [Category("UnityEngine/InputActionAsset")]
    [AddComponentMenu("LoadFromJson(String)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class InputActionAsset_LoadFromJson_String_Node : BTActionNode
    {
        [Space]
        public UnityEngine.InputSystem.InputActionAsset MyAgent;

        [Space]
        public Megumin.Binding.RefVar_String json;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.InputSystem.InputActionAsset)MyAgent).LoadFromJson(json);
            return Status.Succeeded;
        }
    }
}

#endif




