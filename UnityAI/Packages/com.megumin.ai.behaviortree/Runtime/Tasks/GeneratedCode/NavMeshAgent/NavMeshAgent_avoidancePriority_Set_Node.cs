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
    [DisplayName("Set_NavMeshAgent_avoidancePriority")]
    [Category("UnityEngine/NavMeshAgent")]
    [AddComponentMenu("Set_avoidancePriority")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class NavMeshAgent_avoidancePriority_Set_Node : BTActionNode<UnityEngine.AI.NavMeshAgent>
    {
        [Space]
        public Megumin.Binding.RefVar_Int Value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.AI.NavMeshAgent)MyAgent).avoidancePriority = Value;
            return Status.Succeeded;
        }

    }
}




