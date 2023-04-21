﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：Megumin.GameFramework.AI.BehaviorTree.Editor.NodeGeneraotr
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [Icon("Animator Icon")]
    [DisplayName("Animator_SetBoneLocalRotation")]
    [Category("Unity/Animator")]
    [AddComponentMenu("SetBoneLocalRotation(HumanBodyBones, Quaternion)")]
    public sealed class Animator_SetBoneLocalRotation_HumanBodyBones_Quaternion : BTActionNode<UnityEngine.Animator>
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




