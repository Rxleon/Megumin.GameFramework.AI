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
    [DisplayName("Rigidbody_AddTorque")]
    [Category("UnityEngine/Rigidbody")]
    [AddComponentMenu("AddTorque(Vector3, ForceMode)")]
    public sealed class Rigidbody_AddTorque_Vector3_ForceMode : BTActionNode<UnityEngine.Rigidbody>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3 torque;
        public Megumin.Binding.RefVar<UnityEngine.ForceMode> mode;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Rigidbody)MyAgent).AddTorque(torque, mode);
            return Status.Succeeded;
        }
    }
}




