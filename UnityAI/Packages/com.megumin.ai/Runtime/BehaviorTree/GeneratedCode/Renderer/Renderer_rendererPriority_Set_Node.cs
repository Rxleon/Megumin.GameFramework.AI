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
    [DisplayName("Set_Renderer_rendererPriority")]
    [Category("UnityEngine/Renderer")]
    [AddComponentMenu("Set_rendererPriority")]
    public sealed class Renderer_rendererPriority_Set_Node : BTActionNode<UnityEngine.Renderer>
    {
        [Space]
        public Megumin.Binding.RefVar_Int Value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Renderer)MyAgent).rendererPriority = Value;
            return Status.Succeeded;
        }

    }
}




