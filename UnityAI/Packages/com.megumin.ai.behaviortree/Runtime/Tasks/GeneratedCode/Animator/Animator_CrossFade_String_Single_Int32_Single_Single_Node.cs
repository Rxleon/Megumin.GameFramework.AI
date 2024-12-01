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
    [DisplayName("Animator_CrossFade")]
    [Category("UnityEngine/Animator")]
    [AddComponentMenu("CrossFade(String, Single, Int32, Single, Single)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Animator_CrossFade_String_Single_Int32_Single_Single_Node : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar_String stateName;
        public Megumin.Binding.RefVar_Float normalizedTransitionDuration;
        public Megumin.Binding.RefVar_Int layer;
        public Megumin.Binding.RefVar_Float normalizedTimeOffset;
        public Megumin.Binding.RefVar_Float normalizedTransitionTime;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).CrossFade(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
            return Status.Succeeded;
        }
    }
}




