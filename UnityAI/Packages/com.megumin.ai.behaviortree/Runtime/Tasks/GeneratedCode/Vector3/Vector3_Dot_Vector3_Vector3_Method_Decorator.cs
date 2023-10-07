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
    [DisplayName("Vector3_Dot")]
    [Category("UnityEngine/Vector3")]
    [AddComponentMenu("Dot(Vector3, Vector3)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Vector3_Dot_Vector3_Vector3_Method_Decorator : CompareDecorator<float>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 lhs;
        public Megumin.Binding.RefVar_Vector3 rhs;

        [Space]
        public Megumin.Binding.RefVar_Float CompareTo;

        [Space]
        public Megumin.Binding.RefVar_Float SaveValueTo;

        public override float GetResult()
        {
            var result = UnityEngine.Vector3.Dot(lhs, rhs);

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




