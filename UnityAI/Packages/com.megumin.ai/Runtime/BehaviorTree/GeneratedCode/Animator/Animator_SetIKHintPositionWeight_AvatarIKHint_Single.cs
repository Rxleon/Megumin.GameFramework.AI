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
    [DisplayName("Animator_SetIKHintPositionWeight")]
    [Category("Unity/Animator")]
    [AddComponentMenu("SetIKHintPositionWeight(AvatarIKHint, Single)")]
    public sealed class Animator_SetIKHintPositionWeight_AvatarIKHint_Single : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.AvatarIKHint> hint;
        public Megumin.Binding.RefVar_Float value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).SetIKHintPositionWeight(hint, value);
            return Status.Succeeded;
        }
    }
}




