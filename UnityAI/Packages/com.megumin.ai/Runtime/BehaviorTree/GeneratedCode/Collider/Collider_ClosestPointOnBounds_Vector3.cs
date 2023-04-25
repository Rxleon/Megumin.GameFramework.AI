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
    [Icon("DefaultAsset Icon")]
    [DisplayName("Collider_ClosestPointOnBounds")]
    [Category("UnityEngine/Collider")]
    [AddComponentMenu("ClosestPointOnBounds(Vector3)")]
    public sealed class Collider_ClosestPointOnBounds_Vector3 : BTActionNode<UnityEngine.Collider>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 position;

        [Space]
        public Megumin.Binding.RefVar_Vector3 SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = ((UnityEngine.Collider)MyAgent).ClosestPointOnBounds(position);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




