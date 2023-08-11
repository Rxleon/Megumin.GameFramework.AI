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
    [DisplayName("Vector2Int_Min")]
    [Category("UnityEngine/Vector2Int")]
    [AddComponentMenu("Min(Vector2Int, Vector2Int)")]
    public sealed class Vector2Int_Min_Vector2Int_Vector2Int_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2Int lhs;
        public Megumin.Binding.RefVar_Vector2Int rhs;

        [Space]
        public Megumin.Binding.RefVar_Vector2Int SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Vector2Int.Min(lhs, rhs);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}



