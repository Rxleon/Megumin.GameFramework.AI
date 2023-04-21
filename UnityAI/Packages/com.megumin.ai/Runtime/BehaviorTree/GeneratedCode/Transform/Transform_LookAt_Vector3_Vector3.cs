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
    [DisplayName("Transform_LookAt")]
    [Category("Unity/Transform")]
    [AddComponentMenu("LookAt(Vector3, Vector3)")]
    public sealed class Transform_LookAt_Vector3_Vector3 : BTActionNode<UnityEngine.Transform>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 worldPosition;
        public Megumin.Binding.RefVar_Vector3 worldUp;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Transform)MyAgent).LookAt(worldPosition, worldUp);
            return Status.Succeeded;
        }
    }
}




