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
    [DisplayName("NavMeshAgent_ActivateCurrentOffMeshLink")]
    [Category("UnityEngine/NavMeshAgent")]
    [AddComponentMenu("ActivateCurrentOffMeshLink(Boolean)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class NavMeshAgent_ActivateCurrentOffMeshLink_Boolean_Node : BTActionNode<UnityEngine.AI.NavMeshAgent>
    {
        [Space]
        public Megumin.Binding.RefVar_Bool activated;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.AI.NavMeshAgent)MyAgent).ActivateCurrentOffMeshLink(activated);
            return Status.Succeeded;
        }
    }
}




