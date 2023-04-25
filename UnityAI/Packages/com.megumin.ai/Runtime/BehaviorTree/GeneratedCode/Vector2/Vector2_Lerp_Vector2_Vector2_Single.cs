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
    [DisplayName("Vector2_Lerp")]
    [Category("UnityEngine/Vector2")]
    [AddComponentMenu("Lerp(Vector2, Vector2, Single)")]
    public sealed class Vector2_Lerp_Vector2_Vector2_Single : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2 a;
        public Megumin.Binding.RefVar_Vector2 b;
        public Megumin.Binding.RefVar_Float t;

        [Space]
        public Megumin.Binding.RefVar_Vector2 SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Vector2.Lerp(a, b, t);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




