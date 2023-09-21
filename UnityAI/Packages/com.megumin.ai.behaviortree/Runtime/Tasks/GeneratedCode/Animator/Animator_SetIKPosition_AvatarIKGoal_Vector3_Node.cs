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
    [Icon("d_Animator Icon")]
    [DisplayName("Animator_SetIKPosition")]
    [Category("UnityEngine/Animator")]
    [AddComponentMenu("SetIKPosition(AvatarIKGoal, Vector3)")]
    public sealed class Animator_SetIKPosition_AvatarIKGoal_Vector3_Node : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.AvatarIKGoal> goal;
        public Megumin.Binding.RefVar_Vector3 goalPosition;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).SetIKPosition(goal, goalPosition);
            return Status.Succeeded;
        }
    }
}




