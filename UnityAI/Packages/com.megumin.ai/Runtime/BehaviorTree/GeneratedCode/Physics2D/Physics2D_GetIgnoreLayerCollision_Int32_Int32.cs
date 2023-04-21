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
    [DisplayName("Physics2D_GetIgnoreLayerCollision")]
    [Category("Unity/Physics2D")]
    [AddComponentMenu("GetIgnoreLayerCollision(Int32, Int32)")]
    public sealed class Physics2D_GetIgnoreLayerCollision_Int32_Int32 : ConditionDecorator
    {
        [Space]
        public Megumin.Binding.RefVar_Int layer1;
        public Megumin.Binding.RefVar_Int layer2;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = UnityEngine.Physics2D.GetIgnoreLayerCollision(layer1, layer2);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }
    }
}




