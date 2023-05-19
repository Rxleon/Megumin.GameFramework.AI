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
    [DisplayName("Camera_WorldToScreenPoint")]
    [Category("UnityEngine/Camera")]
    [AddComponentMenu("WorldToScreenPoint(Vector3, MonoOrStereoscopicEye)")]
    public sealed class Camera_WorldToScreenPoint_Vector3_MonoOrStereoscopicEye_Node : BTActionNode<UnityEngine.Camera>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 position;
        public Megumin.Binding.RefVar<UnityEngine.Camera.MonoOrStereoscopicEye> eye;

        [Space]
        public Megumin.Binding.RefVar_Vector3 SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = ((UnityEngine.Camera)MyAgent).WorldToScreenPoint(position, eye);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




