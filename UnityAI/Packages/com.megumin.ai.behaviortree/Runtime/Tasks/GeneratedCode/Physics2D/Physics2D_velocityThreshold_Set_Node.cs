﻿///********************************************************************************************************************************
///The code on this page is generated by the code generator, do not manually modify.
///CodeGenerator: Megumin.CSCodeGenerator.  Version: 1.0.2
///CodeGenericBy: Megumin.AI.BehaviorTree.Editor.NodeGenerator
///CodeGenericSourceFilePath: Packages/com.megumin.ai.behaviortree/Editor/Generator/NodeGeneraotr.asset
///********************************************************************************************************************************

#if !UNITY_2023_1_OR_NEWER

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.AI.BehaviorTree
{
    [DisplayName("Set_Physics2D_velocityThreshold")]
    [Category("UnityEngine/Physics2D")]
    [AddComponentMenu("Set_velocityThreshold")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    [Obsolete("Obsolete API in a future version of Unity", true)]
    public sealed class Physics2D_velocityThreshold_Set_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Float Value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.Physics2D.velocityThreshold = Value;
            return Status.Succeeded;
        }

    }
}

#endif




