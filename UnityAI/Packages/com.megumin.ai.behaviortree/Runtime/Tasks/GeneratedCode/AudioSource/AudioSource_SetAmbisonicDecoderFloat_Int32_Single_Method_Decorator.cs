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
    [DisplayName("AudioSource_SetAmbisonicDecoderFloat")]
    [Category("UnityEngine/AudioSource")]
    [AddComponentMenu("SetAmbisonicDecoderFloat(Int32, Single)")]
    public sealed class AudioSource_SetAmbisonicDecoderFloat_Int32_Single_Method_Decorator : ConditionDecorator<UnityEngine.AudioSource>
    {
        [Space]
        public Megumin.Binding.RefVar_Int index;
        public Megumin.Binding.RefVar_Float value;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = ((UnityEngine.AudioSource)MyAgent).SetAmbisonicDecoderFloat(index, value);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

    }
}




