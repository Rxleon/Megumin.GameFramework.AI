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
    [DisplayName("Physics_RebuildBroadphaseRegions")]
    [Category("UnityEngine/Physics")]
    [AddComponentMenu("RebuildBroadphaseRegions(Bounds, Int32)")]
    [Obsolete("Obsolete API in a future version of Unity", true)]
    public sealed class Physics_RebuildBroadphaseRegions_Bounds_Int32 : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Bounds worldBounds;
        public Megumin.Binding.RefVar_Int subdivisions;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.Physics.RebuildBroadphaseRegions(worldBounds, subdivisions);
            return Status.Succeeded;
        }
    }
}




