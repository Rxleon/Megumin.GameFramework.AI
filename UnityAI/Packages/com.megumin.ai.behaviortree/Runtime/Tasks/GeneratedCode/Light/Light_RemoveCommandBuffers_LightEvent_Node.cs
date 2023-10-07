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
    [Icon("d_Light Icon")]
    [DisplayName("Light_RemoveCommandBuffers")]
    [Category("UnityEngine/Light")]
    [AddComponentMenu("RemoveCommandBuffers(LightEvent)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Light_RemoveCommandBuffers_LightEvent_Node : BTActionNode<UnityEngine.Light>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.Rendering.LightEvent> evt;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Light)MyAgent).RemoveCommandBuffers(evt);
            return Status.Succeeded;
        }
    }
}




