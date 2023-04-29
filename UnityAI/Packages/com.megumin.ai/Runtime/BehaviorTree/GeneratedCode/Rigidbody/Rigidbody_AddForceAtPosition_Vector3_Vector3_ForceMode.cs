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
    [Icon("Rigidbody Icon")]
    [DisplayName("Rigidbody_AddForceAtPosition")]
    [Category("UnityEngine/Rigidbody")]
    [AddComponentMenu("AddForceAtPosition(Vector3, Vector3, ForceMode)")]
    public sealed class Rigidbody_AddForceAtPosition_Vector3_Vector3_ForceMode : BTActionNode<UnityEngine.Rigidbody>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 force;
        public Megumin.Binding.RefVar_Vector3 position;
        public Megumin.Binding.RefVar<UnityEngine.ForceMode> mode;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Rigidbody)MyAgent).AddForceAtPosition(force, position, mode);
            return Status.Succeeded;
        }
    }
}



