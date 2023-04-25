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
    [Icon("Animator Icon")]
    [DisplayName("Animator_Play")]
    [Category("UnityEngine/Animator")]
    [AddComponentMenu("Play(Int32)")]
    public sealed class Animator_Play_Int32 : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar_Int stateNameHash;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).Play(stateNameHash);
            return Status.Succeeded;
        }
    }
}




