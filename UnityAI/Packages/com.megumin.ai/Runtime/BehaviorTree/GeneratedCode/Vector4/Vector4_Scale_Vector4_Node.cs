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
    [DisplayName("Vector4_Scale")]
    [Category("UnityEngine/Vector4")]
    [AddComponentMenu("Scale(Vector4)")]
    public sealed class Vector4_Scale_Vector4_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector4 MyAgent;

        [Space]
        public Megumin.Binding.RefVar_Vector4 scale;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Vector4)MyAgent).Scale(scale);
            return Status.Succeeded;
        }
    }
}




