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
    [Icon("Transform Icon")]
    [DisplayName("Transform_SetParent")]
    [Category("UnityEngine/Transform")]
    [AddComponentMenu("SetParent(Transform, Boolean)")]
    public sealed class Transform_SetParent_Transform_Boolean_Node : BTActionNode<UnityEngine.Transform>
    {
        [Space]
        public Megumin.Binding.RefVar_Transform parent;
        public Megumin.Binding.RefVar_Bool worldPositionStays;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Transform)MyAgent).SetParent(parent, worldPositionStays);
            return Status.Succeeded;
        }
    }
}




