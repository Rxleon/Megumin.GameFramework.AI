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
    [DisplayName("Physics2D_Raycast")]
    [Category("UnityEngine/Physics2D")]
    [AddComponentMenu("Raycast(Vector2, Vector2, Single, Int32, Single, Single)")]
    public sealed class Physics2D_Raycast_Vector2_Vector2_Single_Int32_Single_Single_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2 origin;
        public Megumin.Binding.RefVar_Vector2 direction;
        public Megumin.Binding.RefVar_Float distance;
        public Megumin.Binding.RefVar_Int layerMask;
        public Megumin.Binding.RefVar_Float minDepth;
        public Megumin.Binding.RefVar_Float maxDepth;

        [Space]
        public Megumin.Binding.RefVar<UnityEngine.RaycastHit2D> SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Physics2D.Raycast(origin, direction, distance, layerMask, minDepth, maxDepth);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




