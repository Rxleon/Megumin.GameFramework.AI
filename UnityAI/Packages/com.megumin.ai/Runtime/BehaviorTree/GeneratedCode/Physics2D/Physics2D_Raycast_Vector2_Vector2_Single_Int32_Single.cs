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
    [DisplayName("Physics2D_Raycast")]
    [Category("UnityEngine/Physics2D")]
    [AddComponentMenu("Raycast(Vector2, Vector2, Single, Int32, Single)")]
    public sealed class Physics2D_Raycast_Vector2_Vector2_Single_Int32_Single : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2 origin;
        public Megumin.Binding.RefVar_Vector2 direction;
        public Megumin.Binding.RefVar_Float distance;
        public Megumin.Binding.RefVar_Int layerMask;
        public Megumin.Binding.RefVar_Float minDepth;

        [Space]
        public Megumin.Binding.RefVar<UnityEngine.RaycastHit2D> SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Physics2D.Raycast(origin, direction, distance, layerMask, minDepth);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




