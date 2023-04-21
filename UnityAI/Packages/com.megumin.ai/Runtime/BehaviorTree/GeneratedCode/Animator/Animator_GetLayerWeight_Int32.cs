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
    [Icon("Animator Icon")]
    [DisplayName("Animator_GetLayerWeight")]
    [Category("Unity/Animator")]
    [AddComponentMenu("GetLayerWeight(Int32)")]
    public sealed class Animator_GetLayerWeight_Int32 : BTActionNode<UnityEngine.Animator>
    {
        [Space]
        public Megumin.Binding.RefVar_Int layerIndex;

        [Space]
        public Megumin.Binding.RefVar_Float SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = ((UnityEngine.Animator)MyAgent).GetLayerWeight(layerIndex);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




