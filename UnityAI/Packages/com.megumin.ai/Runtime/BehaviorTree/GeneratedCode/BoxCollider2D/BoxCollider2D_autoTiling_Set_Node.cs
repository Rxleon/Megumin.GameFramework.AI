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
    [Icon("BoxCollider2D Icon")]
    [DisplayName("Set_BoxCollider2D_autoTiling")]
    [Category("UnityEngine/BoxCollider2D")]
    [AddComponentMenu("Set_autoTiling")]
    public sealed class BoxCollider2D_autoTiling_Set_Node : BTActionNode<UnityEngine.BoxCollider2D>
    {
        [Space]
        public Megumin.Binding.RefVar_Bool Value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.BoxCollider2D)MyAgent).autoTiling = Value;
            return Status.Succeeded;
        }

    }
}




