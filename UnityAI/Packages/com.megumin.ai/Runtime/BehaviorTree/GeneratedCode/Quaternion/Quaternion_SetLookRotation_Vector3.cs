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
    [DisplayName("Quaternion_SetLookRotation")]
    [Category("UnityEngine/Quaternion")]
    [AddComponentMenu("SetLookRotation(Vector3)")]
    public sealed class Quaternion_SetLookRotation_Vector3 : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.Quaternion> MyAgent;

        [Space]
        public Megumin.Binding.RefVar_Vector3 view;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Quaternion)MyAgent).SetLookRotation(view);
            return Status.Succeeded;
        }
    }
}




