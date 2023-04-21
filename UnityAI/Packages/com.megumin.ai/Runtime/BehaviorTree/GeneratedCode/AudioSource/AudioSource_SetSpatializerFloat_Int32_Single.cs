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
    [Icon("AudioSource Icon")]
    [DisplayName("AudioSource_SetSpatializerFloat")]
    [Category("Unity/AudioSource")]
    [AddComponentMenu("SetSpatializerFloat(Int32, Single)")]
    public sealed class AudioSource_SetSpatializerFloat_Int32_Single : ConditionDecorator<UnityEngine.AudioSource>
    {
        [Space]
        public Megumin.Binding.RefVar_Int index;
        public Megumin.Binding.RefVar_Float value;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = ((UnityEngine.AudioSource)MyAgent).SetSpatializerFloat(index, value);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }
    }
}




