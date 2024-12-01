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
    [Icon("NavMeshAgent Icon")]
    [DisplayName("Get_NavMeshAgent_remainingDistance")]
    [Category("UnityEngine/NavMeshAgent")]
    [AddComponentMenu("Get_remainingDistance")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class NavMeshAgent_remainingDistance_Get_Node : BTActionNode<UnityEngine.AI.NavMeshAgent>
    {
        [Space]
        public Megumin.Binding.RefVar_Float SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = ((UnityEngine.AI.NavMeshAgent)MyAgent).remainingDistance;

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }

    }
}




