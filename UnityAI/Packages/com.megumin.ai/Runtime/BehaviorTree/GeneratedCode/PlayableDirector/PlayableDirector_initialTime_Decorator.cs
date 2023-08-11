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
    [Icon("d_PlayableDirector Icon")]
    [DisplayName("PlayableDirector_initialTime")]
    [Category("UnityEngine/PlayableDirector")]
    [AddComponentMenu("initialTime")]
    public sealed class PlayableDirector_initialTime_Decorator : CompareDecorator<UnityEngine.Playables.PlayableDirector, double>
    {
        [Space]
        public Megumin.Binding.RefVar_Double CompareTo;

        [Space]
        public Megumin.Binding.RefVar_Double SaveValueTo;

        public override double GetResult()
        {
            var result = ((UnityEngine.Playables.PlayableDirector)MyAgent).initialTime;

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

        public override double GetCompareTo()
        {
            return CompareTo;
        }

    }
}



