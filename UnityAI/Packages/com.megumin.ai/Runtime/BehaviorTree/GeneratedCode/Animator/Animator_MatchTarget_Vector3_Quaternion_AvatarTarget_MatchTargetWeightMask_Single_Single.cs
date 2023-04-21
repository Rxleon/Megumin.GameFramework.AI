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
    [DisplayName("Animator_MatchTarget")]
    [Category("Unity/Animator")]
    [AddComponentMenu("MatchTarget(Vector3, Quaternion, AvatarTarget, MatchTargetWeightMask, Single, Single)")]
    public sealed class Animator_MatchTarget_Vector3_Quaternion_AvatarTarget_MatchTargetWeightMask_Single_Single : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 matchPosition;
        public Megumin.Binding.RefVar<UnityEngine.Quaternion> matchRotation;
        public Megumin.Binding.RefVar<UnityEngine.AvatarTarget> targetBodyPart;
        public Megumin.Binding.RefVar<UnityEngine.MatchTargetWeightMask> weightMask;
        public Megumin.Binding.RefVar_Float startNormalizedTime;
        public Megumin.Binding.RefVar_Float targetNormalizedTime;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).MatchTarget(matchPosition, matchRotation, targetBodyPart, weightMask, startNormalizedTime, targetNormalizedTime);
            return Status.Succeeded;
        }
    }
}




