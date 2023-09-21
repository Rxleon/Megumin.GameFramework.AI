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
    [DisplayName("Animator_SetIKPositionWeight")]
    [Category("UnityEngine/Animator")]
    [AddComponentMenu("SetIKPositionWeight(AvatarIKGoal, Single)")]
    public sealed class Animator_SetIKPositionWeight_AvatarIKGoal_Single_Node : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.AvatarIKGoal> goal;
        public Megumin.Binding.RefVar_Float value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).SetIKPositionWeight(goal, value);
            return Status.Succeeded;
        }
    }
}




