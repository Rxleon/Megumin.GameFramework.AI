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
    [DisplayName("Physics_Linecast")]
    [Category("UnityEngine/Physics")]
    [AddComponentMenu("Linecast(Vector3, Vector3, Int32, QueryTriggerInteraction)")]
    public sealed class Physics_Linecast_Vector3_Vector3_Int32_QueryTriggerInteraction : ConditionDecorator
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 start;
        public Megumin.Binding.RefVar_Vector3 end;
        public Megumin.Binding.RefVar_Int layerMask;
        public Megumin.Binding.RefVar<UnityEngine.QueryTriggerInteraction> queryTriggerInteraction;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = UnityEngine.Physics.Linecast(start, end, layerMask, queryTriggerInteraction);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }
    }
}




