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
    [DisplayName("Physics_SphereCast")]
    [Category("UnityEngine/Physics")]
    [AddComponentMenu("SphereCast(Ray, Single, Single, Int32)")]
    public sealed class Physics_SphereCast_Ray_Single_Single_Int32_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.Ray> ray;
        public Megumin.Binding.RefVar_Float radius;
        public Megumin.Binding.RefVar_Float maxDistance;
        public Megumin.Binding.RefVar_Int layerMask;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Physics.SphereCast(ray, radius, maxDistance, layerMask);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




