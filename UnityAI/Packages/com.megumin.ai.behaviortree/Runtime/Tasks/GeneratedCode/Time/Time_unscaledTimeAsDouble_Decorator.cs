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
    [Icon("d_unityeditor.animationwindow@2x")]
    [DisplayName("Time_unscaledTimeAsDouble")]
    [Category("UnityEngine/Time")]
    [AddComponentMenu("unscaledTimeAsDouble")]
    public sealed class Time_unscaledTimeAsDouble_Decorator : CompareDecorator<double>
    {
        [Space]
        public Megumin.Binding.RefVar_Double CompareTo;

        [Space]
        public Megumin.Binding.RefVar_Double SaveValueTo;

        public override double GetResult()
        {
            var result = UnityEngine.Time.unscaledTimeAsDouble;

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




