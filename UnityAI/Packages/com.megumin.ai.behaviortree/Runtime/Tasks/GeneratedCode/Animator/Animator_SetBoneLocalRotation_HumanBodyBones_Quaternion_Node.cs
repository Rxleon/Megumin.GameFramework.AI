﻿///********************************************************************************************************************************
///The code on this page is generated by the code generator, do not manually modify.
///CodeGenerator: Megumin.CSCodeGenerator.  Version: 1.0.1
///CodeGenericBy: Megumin.AI.BehaviorTree.Editor.NodeGenerator
///CodeGenericSourceFilePath: Packages/com.megumin.ai/Editor/BehaviorTree/Generator/NodeGeneraotr.asset
///********************************************************************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.AI.BehaviorTree
{
    [Icon("d_Animator Icon")]
    [DisplayName("Animator_SetBoneLocalRotation")]
    [Category("UnityEngine/Animator")]
    [AddComponentMenu("SetBoneLocalRotation(HumanBodyBones, Quaternion)")]
    public sealed class Animator_SetBoneLocalRotation_HumanBodyBones_Quaternion_Node : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.HumanBodyBones> humanBoneId;
        public Megumin.Binding.RefVar<UnityEngine.Quaternion> rotation;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).SetBoneLocalRotation(humanBoneId, rotation);
            return Status.Succeeded;
        }
    }
}



