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
    [Icon("d_AudioSource Icon")]
    [DisplayName("Set_AudioSource_timeSamples")]
    [Category("UnityEngine/AudioSource")]
    [AddComponentMenu("Set_timeSamples")]
    public sealed class AudioSource_timeSamples_Set_Node : BTActionNode<UnityEngine.AudioSource>
    {
        [Space]
        public Megumin.Binding.RefVar_Int Value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.AudioSource)MyAgent).timeSamples = Value;
            return Status.Succeeded;
        }

    }
}




