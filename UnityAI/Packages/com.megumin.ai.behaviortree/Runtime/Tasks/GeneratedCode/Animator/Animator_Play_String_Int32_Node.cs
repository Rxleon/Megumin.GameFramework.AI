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
    [Icon("d_Animator Icon")]
    [DisplayName("Animator_Play")]
    [Category("UnityEngine/Animator")]
    [AddComponentMenu("Play(String, Int32)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Animator_Play_String_Int32_Node : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar_String stateName;
        public Megumin.Binding.RefVar_Int layer;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).Play(stateName, layer);
            return Status.Succeeded;
        }
    }
}




