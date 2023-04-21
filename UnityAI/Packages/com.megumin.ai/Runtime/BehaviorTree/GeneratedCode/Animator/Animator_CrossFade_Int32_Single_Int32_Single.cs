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
    [DisplayName("Animator_CrossFade")]
    [Category("Unity/Animator")]
    [AddComponentMenu("CrossFade(Int32, Single, Int32, Single)")]
    public sealed class Animator_CrossFade_Int32_Single_Int32_Single : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar_Int stateHashName;
        public Megumin.Binding.RefVar_Float normalizedTransitionDuration;
        public Megumin.Binding.RefVar_Int layer;
        public Megumin.Binding.RefVar_Float normalizedTimeOffset;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).CrossFade(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset);
            return Status.Succeeded;
        }
    }
}




