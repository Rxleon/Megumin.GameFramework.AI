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
    [Icon("Light Icon")]
    [DisplayName("Light_RemoveCommandBuffers")]
    [Category("UnityEngine/Light")]
    [AddComponentMenu("RemoveCommandBuffers(LightEvent)")]
    public sealed class Light_RemoveCommandBuffers_LightEvent : BTActionNode<UnityEngine.Light>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.Rendering.LightEvent> evt;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Light)MyAgent).RemoveCommandBuffers(evt);
            return Status.Succeeded;
        }
    }
}




