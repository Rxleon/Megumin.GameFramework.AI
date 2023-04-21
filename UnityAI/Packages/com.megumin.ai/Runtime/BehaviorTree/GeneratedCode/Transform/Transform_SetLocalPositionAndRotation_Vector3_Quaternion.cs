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
    [Icon("Transform Icon")]
    [DisplayName("Transform_SetLocalPositionAndRotation")]
    [Category("Unity/Transform")]
    [AddComponentMenu("SetLocalPositionAndRotation(Vector3, Quaternion)")]
    public sealed class Transform_SetLocalPositionAndRotation_Vector3_Quaternion : BTActionNode<UnityEngine.Transform>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 localPosition;
        public Megumin.Binding.RefVar<UnityEngine.Quaternion> localRotation;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Transform)MyAgent).SetLocalPositionAndRotation(localPosition, localRotation);
            return Status.Succeeded;
        }
    }
}




