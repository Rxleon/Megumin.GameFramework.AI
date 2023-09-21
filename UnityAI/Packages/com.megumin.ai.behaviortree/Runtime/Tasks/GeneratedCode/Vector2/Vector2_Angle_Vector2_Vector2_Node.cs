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
    [DisplayName("Vector2_Angle")]
    [Category("UnityEngine/Vector2")]
    [AddComponentMenu("Angle(Vector2, Vector2)")]
    public sealed class Vector2_Angle_Vector2_Vector2_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2 from;
        public Megumin.Binding.RefVar_Vector2 to;

        [Space]
        public Megumin.Binding.RefVar_Float SaveValueTo;

        protected override Status OnTick(BTNode from1, object options = null)
        {
            var result = UnityEngine.Vector2.Angle(from, to);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




