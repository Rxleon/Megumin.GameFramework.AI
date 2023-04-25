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
    [DisplayName("Camera_CalculateFrustumCorners")]
    [Category("UnityEngine/Camera")]
    [AddComponentMenu("CalculateFrustumCorners(Rect, Single, MonoOrStereoscopicEye, Vector3[])")]
    public sealed class Camera_CalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array : BTActionNode<UnityEngine.Camera>
    {
        [Space]
        public Megumin.Binding.RefVar_Rect viewport;
        public Megumin.Binding.RefVar_Float z;
        public Megumin.Binding.RefVar<UnityEngine.Camera.MonoOrStereoscopicEye> eye;
        public Megumin.Binding.RefVar_Vector3_Array outCorners;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Camera)MyAgent).CalculateFrustumCorners(viewport, z, eye, outCorners);
            return Status.Succeeded;
        }
    }
}




