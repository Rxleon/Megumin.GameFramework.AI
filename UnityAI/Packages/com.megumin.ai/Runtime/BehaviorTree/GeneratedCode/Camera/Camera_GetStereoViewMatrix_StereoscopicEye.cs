﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：Megumin.GameFramework.AI.BehaviorTree.Editor.NodeGeneraotr
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [Icon("Camera Icon")]
    [DisplayName("Camera_GetStereoViewMatrix")]
    [Category("Unity/Camera")]
    [AddComponentMenu("GetStereoViewMatrix(StereoscopicEye)")]
    public sealed class Camera_GetStereoViewMatrix_StereoscopicEye : BTActionNode<UnityEngine.Camera>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.Camera.StereoscopicEye> eye;

        [Space]
        public Megumin.Binding.RefVar<UnityEngine.Matrix4x4> SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = ((UnityEngine.Camera)MyAgent).GetStereoViewMatrix(eye);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




