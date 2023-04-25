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
    [DisplayName("Physics_CapsuleCast")]
    [Category("UnityEngine/Physics")]
    [AddComponentMenu("CapsuleCast(Vector3, Vector3, Single, Vector3, Single, Int32)")]
    public sealed class Physics_CapsuleCast_Vector3_Vector3_Single_Vector3_Single_Int32 : ConditionDecorator
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 point1;
        public Megumin.Binding.RefVar_Vector3 point2;
        public Megumin.Binding.RefVar_Float radius;
        public Megumin.Binding.RefVar_Vector3 direction;
        public Megumin.Binding.RefVar_Float maxDistance;
        public Megumin.Binding.RefVar_Int layerMask;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }
    }
}




