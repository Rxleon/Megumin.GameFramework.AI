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
    [Icon("Camera Icon")]
    [DisplayName("Camera_useOcclusionCulling")]
    [Category("UnityEngine/Camera")]
    [AddComponentMenu("useOcclusionCulling")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Camera_useOcclusionCulling_Decorator : ConditionDecorator<UnityEngine.Camera>
    {
        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = ((UnityEngine.Camera)MyAgent).useOcclusionCulling;

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

    }
}




