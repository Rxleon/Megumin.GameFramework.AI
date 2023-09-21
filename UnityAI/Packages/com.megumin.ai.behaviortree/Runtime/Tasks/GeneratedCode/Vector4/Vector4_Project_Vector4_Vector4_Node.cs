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
    [DisplayName("Vector4_Project")]
    [Category("UnityEngine/Vector4")]
    [AddComponentMenu("Project(Vector4, Vector4)")]
    public sealed class Vector4_Project_Vector4_Vector4_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector4 a;
        public Megumin.Binding.RefVar_Vector4 b;

        [Space]
        public Megumin.Binding.RefVar_Vector4 SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Vector4.Project(a, b);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




