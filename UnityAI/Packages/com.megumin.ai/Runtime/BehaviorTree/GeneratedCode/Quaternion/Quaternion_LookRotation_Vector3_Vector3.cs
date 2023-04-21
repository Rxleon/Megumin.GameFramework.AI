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
    [DisplayName("Quaternion_LookRotation")]
    [Category("Unity/Quaternion")]
    [AddComponentMenu("LookRotation(Vector3, Vector3)")]
    public sealed class Quaternion_LookRotation_Vector3_Vector3 : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 forward;
        public Megumin.Binding.RefVar_Vector3 upwards;

        [Space]
        public Megumin.Binding.RefVar<UnityEngine.Quaternion> SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Quaternion.LookRotation(forward, upwards);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




