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
    [Icon("d_ParticleSystem Icon")]
    [DisplayName("ParticleSystem_SetMaximumPreMappedBufferCounts")]
    [Category("UnityEngine/ParticleSystem")]
    [AddComponentMenu("SetMaximumPreMappedBufferCounts(Int32, Int32)")]
    public sealed class ParticleSystem_SetMaximumPreMappedBufferCounts_Int32_Int32_Node : BTActionNode<UnityEngine.ParticleSystem>
    {
        [Space]
        public Megumin.Binding.RefVar_Int vertexBuffersCount;
        public Megumin.Binding.RefVar_Int indexBuffersCount;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.ParticleSystem.SetMaximumPreMappedBufferCounts(vertexBuffersCount, indexBuffersCount);
            return Status.Succeeded;
        }
    }
}




