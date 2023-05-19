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
    [Icon("Rigidbody2D Icon")]
    [DisplayName("Rigidbody2D_AddForceAtPosition")]
    [Category("UnityEngine/Rigidbody2D")]
    [AddComponentMenu("AddForceAtPosition(Vector2, Vector2)")]
    public sealed class Rigidbody2D_AddForceAtPosition_Vector2_Vector2_Node : BTActionNode<UnityEngine.Rigidbody2D>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2 force;
        public Megumin.Binding.RefVar_Vector2 position;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Rigidbody2D)MyAgent).AddForceAtPosition(force, position);
            return Status.Succeeded;
        }
    }
}




