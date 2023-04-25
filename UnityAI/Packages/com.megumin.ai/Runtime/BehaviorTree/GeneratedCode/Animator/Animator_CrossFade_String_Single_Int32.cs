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
    [DisplayName("Animator_CrossFade")]
    [Category("UnityEngine/Animator")]
    [AddComponentMenu("CrossFade(String, Single, Int32)")]
    public sealed class Animator_CrossFade_String_Single_Int32 : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar_String stateName;
        public Megumin.Binding.RefVar_Float normalizedTransitionDuration;
        public Megumin.Binding.RefVar_Int layer;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).CrossFade(stateName, normalizedTransitionDuration, layer);
            return Status.Succeeded;
        }
    }
}




