﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：Megumin.GameFramework.AI.BehaviorTree.Editor.NodeGenerator
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [Icon("Animator Icon")]
    [DisplayName("Animator_SetTarget")]
    [Category("UnityEngine/Animator")]
    [AddComponentMenu("SetTarget(AvatarTarget, Single)")]
    public sealed class Animator_SetTarget_AvatarTarget_Single : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.AvatarTarget> targetIndex;
        public Megumin.Binding.RefVar_Float targetNormalizedTime;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).SetTarget(targetIndex, targetNormalizedTime);
            return Status.Succeeded;
        }
    }
}




