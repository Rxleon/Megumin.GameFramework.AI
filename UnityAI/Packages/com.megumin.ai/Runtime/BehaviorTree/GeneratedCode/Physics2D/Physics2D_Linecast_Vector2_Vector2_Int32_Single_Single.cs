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
    [DisplayName("Physics2D_Linecast")]
    [Category("UnityEngine/Physics2D")]
    [AddComponentMenu("Linecast(Vector2, Vector2, Int32, Single, Single)")]
    public sealed class Physics2D_Linecast_Vector2_Vector2_Int32_Single_Single : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2 start;
        public Megumin.Binding.RefVar_Vector2 end;
        public Megumin.Binding.RefVar_Int layerMask;
        public Megumin.Binding.RefVar_Float minDepth;
        public Megumin.Binding.RefVar_Float maxDepth;

        [Space]
        public Megumin.Binding.RefVar<UnityEngine.RaycastHit2D> SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Physics2D.Linecast(start, end, layerMask, minDepth, maxDepth);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




