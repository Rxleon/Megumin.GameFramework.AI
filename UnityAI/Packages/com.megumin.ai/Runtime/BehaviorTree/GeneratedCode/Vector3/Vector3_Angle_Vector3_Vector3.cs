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
    [DisplayName("Vector3_Angle")]
    [Category("Unity/Vector3")]
    [AddComponentMenu("Angle(Vector3, Vector3)")]
    public sealed class Vector3_Angle_Vector3_Vector3 : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 from;
        public Megumin.Binding.RefVar_Vector3 to;

        [Space]
        public Megumin.Binding.RefVar_Float SaveValueTo;

        protected override Status OnTick(BTNode from1, object options = null)
        {
            var result = UnityEngine.Vector3.Angle(from, to);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




