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
    [Icon("d_Camera Icon")]
    [DisplayName("Camera_FocalLengthToFieldOfView")]
    [Category("UnityEngine/Camera")]
    [AddComponentMenu("FocalLengthToFieldOfView(Single, Single)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Camera_FocalLengthToFieldOfView_Single_Single_Method_Decorator : CompareDecorator<UnityEngine.Camera, float>
    {
        [Space]
        public Megumin.Binding.RefVar_Float focalLength;
        public Megumin.Binding.RefVar_Float sensorSize;

        [Space]
        public Megumin.Binding.RefVar_Float CompareTo;

        [Space]
        public Megumin.Binding.RefVar_Float SaveValueTo;

        public override float GetResult()
        {
            var result = UnityEngine.Camera.FocalLengthToFieldOfView(focalLength, sensorSize);

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




