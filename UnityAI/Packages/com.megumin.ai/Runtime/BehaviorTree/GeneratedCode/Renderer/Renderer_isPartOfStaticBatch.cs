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
    [DisplayName("Renderer_isPartOfStaticBatch")]
    [Category("UnityEngine/Renderer")]
    [AddComponentMenu("isPartOfStaticBatch")]
    public sealed class Renderer_isPartOfStaticBatch : ConditionDecorator<UnityEngine.Renderer>
    {
        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = ((UnityEngine.Renderer)MyAgent).isPartOfStaticBatch;

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

    }
}




