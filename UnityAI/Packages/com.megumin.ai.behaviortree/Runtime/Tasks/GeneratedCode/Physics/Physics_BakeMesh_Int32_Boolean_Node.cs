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
    [DisplayName("Physics_BakeMesh")]
    [Category("UnityEngine/Physics")]
    [AddComponentMenu("BakeMesh(Int32, Boolean)")]
    public sealed class Physics_BakeMesh_Int32_Boolean_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Int meshID;
        public Megumin.Binding.RefVar_Bool convex;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.Physics.BakeMesh(meshID, convex);
            return Status.Succeeded;
        }
    }
}




