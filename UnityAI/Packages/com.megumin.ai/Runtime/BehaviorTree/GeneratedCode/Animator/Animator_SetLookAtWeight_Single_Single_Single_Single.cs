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
    [DisplayName("Animator_SetLookAtWeight")]
    [Category("UnityEngine/Animator")]
    [AddComponentMenu("SetLookAtWeight(Single, Single, Single, Single)")]
    public sealed class Animator_SetLookAtWeight_Single_Single_Single_Single : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar_Float weight;
        public Megumin.Binding.RefVar_Float bodyWeight;
        public Megumin.Binding.RefVar_Float headWeight;
        public Megumin.Binding.RefVar_Float eyesWeight;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight);
            return Status.Succeeded;
        }
    }
}



