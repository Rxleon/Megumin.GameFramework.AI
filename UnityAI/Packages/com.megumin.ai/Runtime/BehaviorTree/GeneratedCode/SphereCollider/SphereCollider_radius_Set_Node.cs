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
    [Icon("SphereCollider Icon")]
    [DisplayName("Set_SphereCollider_radius")]
    [Category("UnityEngine/SphereCollider")]
    [AddComponentMenu("Set_radius")]
    public sealed class SphereCollider_radius_Set_Node : BTActionNode<UnityEngine.SphereCollider>
    {
        [Space]
        public Megumin.Binding.RefVar_Float Value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.SphereCollider)MyAgent).radius = Value;
            return Status.Succeeded;
        }

    }
}




