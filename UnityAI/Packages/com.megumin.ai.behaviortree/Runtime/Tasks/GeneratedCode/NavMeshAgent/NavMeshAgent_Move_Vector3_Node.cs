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
    [Icon("d_NavMeshAgent Icon")]
    [DisplayName("NavMeshAgent_Move")]
    [Category("UnityEngine/NavMeshAgent")]
    [AddComponentMenu("Move(Vector3)")]
    public sealed class NavMeshAgent_Move_Vector3_Node : BTActionNode<UnityEngine.AI.NavMeshAgent>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 offset;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.AI.NavMeshAgent)MyAgent).Move(offset);
            return Status.Succeeded;
        }
    }
}




