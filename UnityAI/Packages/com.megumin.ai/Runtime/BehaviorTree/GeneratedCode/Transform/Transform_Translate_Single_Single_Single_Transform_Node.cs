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
    [DisplayName("Transform_Translate")]
    [Category("UnityEngine/Transform")]
    [AddComponentMenu("Translate(Single, Single, Single, Transform)")]
    public sealed class Transform_Translate_Single_Single_Single_Transform_Node : BTActionNode<UnityEngine.Transform>
    {
        [Space]
        public Megumin.Binding.RefVar_Float x;
        public Megumin.Binding.RefVar_Float y;
        public Megumin.Binding.RefVar_Float z;
        public Megumin.Binding.RefVar_Transform relativeTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Transform)MyAgent).Translate(x, y, z, relativeTo);
            return Status.Succeeded;
        }
    }
}




