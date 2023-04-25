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
    [DisplayName("Quaternion_RotateTowards")]
    [Category("UnityEngine/Quaternion")]
    [AddComponentMenu("RotateTowards(Quaternion, Quaternion, Single)")]
    public sealed class Quaternion_RotateTowards_Quaternion_Quaternion_Single : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.Quaternion> from;
        public Megumin.Binding.RefVar<UnityEngine.Quaternion> to;
        public Megumin.Binding.RefVar_Float maxDegreesDelta;

        [Space]
        public Megumin.Binding.RefVar<UnityEngine.Quaternion> SaveValueTo;

        protected override Status OnTick(BTNode from1, object options = null)
        {
            var result = UnityEngine.Quaternion.RotateTowards(from, to, maxDegreesDelta);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




