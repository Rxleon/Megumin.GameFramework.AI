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
    [DisplayName("Vector2_Distance")]
    [Category("UnityEngine/Vector2")]
    [AddComponentMenu("Distance(Vector2, Vector2)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Vector2_Distance_Vector2_Vector2_Method_Decorator : CompareDecorator<float>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2 a;
        public Megumin.Binding.RefVar_Vector2 b;

        [Space]
        public Megumin.Binding.RefVar_Float CompareTo;

        [Space]
        public Megumin.Binding.RefVar_Float SaveValueTo;

        public override float GetResult()
        {
            var result = UnityEngine.Vector2.Distance(a, b);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

        public override float GetCompareTo()
        {
            return CompareTo;
        }

    }
}




