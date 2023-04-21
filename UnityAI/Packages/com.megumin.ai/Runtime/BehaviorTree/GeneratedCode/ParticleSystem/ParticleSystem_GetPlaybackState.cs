﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：Megumin.GameFramework.AI.BehaviorTree.Editor.NodeGeneraotr
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [Icon("ParticleSystem Icon")]
    [DisplayName("ParticleSystem_GetPlaybackState")]
    [Category("Unity/ParticleSystem")]
    [AddComponentMenu("GetPlaybackState")]
    public sealed class ParticleSystem_GetPlaybackState : BTActionNode<UnityEngine.ParticleSystem>
    {

        [Space]
        public Megumin.Binding.RefVar<UnityEngine.ParticleSystem.PlaybackState> SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = ((UnityEngine.ParticleSystem)MyAgent).GetPlaybackState();

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




