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
    [Icon("Camera Icon")]
    [DisplayName("Camera_RenderToCubemap")]
    [Category("UnityEngine/Camera")]
    [AddComponentMenu("RenderToCubemap(RenderTexture, Int32, MonoOrStereoscopicEye)")]
    public sealed class Camera_RenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye : ConditionDecorator<UnityEngine.Camera>
    {
        [Space]
        public Megumin.Binding.RefVar_RenderTexture cubemap;
        public Megumin.Binding.RefVar_Int faceMask;
        public Megumin.Binding.RefVar<UnityEngine.Camera.MonoOrStereoscopicEye> stereoEye;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = ((UnityEngine.Camera)MyAgent).RenderToCubemap(cubemap, faceMask, stereoEye);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }
    }
}




