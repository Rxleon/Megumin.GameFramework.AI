﻿///********************************************************************************************************************************
///The code on this page is generated by the code generator, do not manually modify.
///CodeGenerator: Megumin.CSCodeGenerator.  Version: 1.0.1
///CodeGenericBy: Megumin.AI.BehaviorTree.Editor.NodeGenerator
///CodeGenericSourceFilePath: Packages/com.megumin.ai/Editor/BehaviorTree/Generator/NodeGeneraotr.asset
///********************************************************************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.AI.BehaviorTree
{
    [Icon("d_Camera Icon")]
    [DisplayName("Camera_RenderToCubemap")]
    [Category("UnityEngine/Camera")]
    [AddComponentMenu("RenderToCubemap(RenderTexture, Int32)")]
    public sealed class Camera_RenderToCubemap_RenderTexture_Int32_Method_Decorator : ConditionDecorator<UnityEngine.Camera>
    {
        [Space]
        public Megumin.Binding.RefVar_RenderTexture cubemap;
        public Megumin.Binding.RefVar_Int faceMask;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = ((UnityEngine.Camera)MyAgent).RenderToCubemap(cubemap, faceMask);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

    }
}



