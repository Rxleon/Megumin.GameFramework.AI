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
    [DisplayName("Physics_Raycast")]
    [Category("UnityEngine/Physics")]
    [AddComponentMenu("Raycast(Vector3, Vector3, Single)")]
    public sealed class Physics_Raycast_Vector3_Vector3_Single_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 origin;
        public Megumin.Binding.RefVar_Vector3 direction;
        public Megumin.Binding.RefVar_Float maxDistance;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Physics.Raycast(origin, direction, maxDistance);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




