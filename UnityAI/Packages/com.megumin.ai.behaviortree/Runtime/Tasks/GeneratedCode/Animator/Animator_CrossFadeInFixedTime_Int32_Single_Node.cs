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
    [Icon("Animator Icon")]
    [DisplayName("Animator_CrossFadeInFixedTime")]
    [Category("UnityEngine/Animator")]
    [AddComponentMenu("CrossFadeInFixedTime(Int32, Single)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Animator_CrossFadeInFixedTime_Int32_Single_Node : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar_Int stateHashName;
        public Megumin.Binding.RefVar_Float fixedTransitionDuration;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).CrossFadeInFixedTime(stateHashName, fixedTransitionDuration);
            return Status.Succeeded;
        }
    }
}




