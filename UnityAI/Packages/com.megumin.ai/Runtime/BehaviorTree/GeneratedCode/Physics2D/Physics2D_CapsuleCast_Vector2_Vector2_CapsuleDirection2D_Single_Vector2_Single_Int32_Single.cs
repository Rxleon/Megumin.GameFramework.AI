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
    [DisplayName("Physics2D_CapsuleCast")]
    [Category("Unity/Physics2D")]
    [AddComponentMenu("CapsuleCast(Vector2, Vector2, CapsuleDirection2D, Single, Vector2, Single, Int32, Single)")]
    public sealed class Physics2D_CapsuleCast_Vector2_Vector2_CapsuleDirection2D_Single_Vector2_Single_Int32_Single : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2 origin;
        public Megumin.Binding.RefVar_Vector2 size;
        public Megumin.Binding.RefVar<UnityEngine.CapsuleDirection2D> capsuleDirection;
        public Megumin.Binding.RefVar_Float angle;
        public Megumin.Binding.RefVar_Vector2 direction;
        public Megumin.Binding.RefVar_Float distance;
        public Megumin.Binding.RefVar_Int layerMask;
        public Megumin.Binding.RefVar_Float minDepth;

        [Space]
        public Megumin.Binding.RefVar<UnityEngine.RaycastHit2D> SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Physics2D.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, layerMask, minDepth);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




