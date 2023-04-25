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
    [DisplayName("Physics_IgnoreLayerCollision")]
    [Category("UnityEngine/Physics")]
    [AddComponentMenu("IgnoreLayerCollision(Int32, Int32)")]
    public sealed class Physics_IgnoreLayerCollision_Int32_Int32 : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Int layer1;
        public Megumin.Binding.RefVar_Int layer2;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.Physics.IgnoreLayerCollision(layer1, layer2);
            return Status.Succeeded;
        }
    }
}




