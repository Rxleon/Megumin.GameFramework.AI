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
    [Icon("d_DefaultAsset Icon")]
    [DisplayName("Renderer_sortingLayerName")]
    [Category("UnityEngine/Renderer")]
    [AddComponentMenu("sortingLayerName")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Renderer_sortingLayerName_Decorator : CompareDecorator<UnityEngine.Renderer, string>
    {
        [Space]
        public Megumin.Binding.RefVar_String CompareTo;

        [Space]
        public Megumin.Binding.RefVar_String SaveValueTo;

        public override string GetResult()
        {
            var result = ((UnityEngine.Renderer)MyAgent).sortingLayerName;

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

        public override string GetCompareTo()
        {
            return CompareTo;
        }

    }
}




