﻿///********************************************************************************************************************************
///The code on this page is generated by the code generator, do not manually modify.
///CodeGenerator: Megumin.CSCodeGenerator.  Version: 1.0.2
///CodeGenericBy: Megumin.AI.BehaviorTree.Editor.NodeGenerator
///CodeGenericSourceFilePath: Packages/com.megumin.ai.behaviortree/Editor/Generator/NodeGeneraotr.asset
///********************************************************************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.AI.BehaviorTree
{
    [DisplayName("Physics_RebuildBroadphaseRegions")]
    [Category("UnityEngine/Physics")]
    [AddComponentMenu("RebuildBroadphaseRegions(Bounds, Int32)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    [Obsolete("Obsolete API in a future version of Unity", true)]
    public sealed class Physics_RebuildBroadphaseRegions_Bounds_Int32_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Bounds worldBounds;
        public Megumin.Binding.RefVar_Int subdivisions;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.Physics.RebuildBroadphaseRegions(worldBounds, subdivisions);
            return Status.Succeeded;
        }
    }
}




