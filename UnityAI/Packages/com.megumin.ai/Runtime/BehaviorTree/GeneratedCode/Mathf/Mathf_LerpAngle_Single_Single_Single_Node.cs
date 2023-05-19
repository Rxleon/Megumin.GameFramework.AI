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
    [Icon("d_collabcreate icon")]
    [DisplayName("Mathf_LerpAngle")]
    [Category("UnityEngine/Mathf")]
    [AddComponentMenu("LerpAngle(Single, Single, Single)")]
    public sealed class Mathf_LerpAngle_Single_Single_Single_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Float a;
        public Megumin.Binding.RefVar_Float b;
        public Megumin.Binding.RefVar_Float t;

        [Space]
        public Megumin.Binding.RefVar_Float SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Mathf.LerpAngle(a, b, t);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




