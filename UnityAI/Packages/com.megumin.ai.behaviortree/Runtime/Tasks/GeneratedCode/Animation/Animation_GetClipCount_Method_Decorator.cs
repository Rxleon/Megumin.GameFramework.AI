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
    [Icon("d_Animation Icon")]
    [DisplayName("Animation_GetClipCount")]
    [Category("UnityEngine/Animation")]
    [AddComponentMenu("GetClipCount")]
    public sealed class Animation_GetClipCount_Method_Decorator : CompareDecorator<UnityEngine.Animation, int>
    {
        [Space]
        public Megumin.Binding.RefVar_Int CompareTo;

        [Space]
        public Megumin.Binding.RefVar_Int SaveValueTo;

        public override int GetResult()
        {
            var result = ((UnityEngine.Animation)MyAgent).GetClipCount();

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

        public override int GetCompareTo()
        {
            return CompareTo;
        }

    }
}




