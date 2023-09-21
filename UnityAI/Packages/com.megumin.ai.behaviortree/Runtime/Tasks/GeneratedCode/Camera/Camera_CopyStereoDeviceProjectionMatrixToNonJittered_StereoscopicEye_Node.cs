﻿///********************************************************************************************************************************
///The code on this page is generated by the code generator, do not manually modify.
///CodeGenerator: Megumin.CSCodeGenerator.  Version: 1.0.2
///CodeGenericBy: Megumin.AI.BehaviorTree.Editor.NodeGenerator
///CodeGenericSourceFilePath: Packages/com.megumin.ai.behaviortree/Editor/Generator/NodeGeneraotr.asset
///********************************************************************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.AI.BehaviorTree
{
    [Icon("d_Camera Icon")]
    [DisplayName("Camera_CopyStereoDeviceProjectionMatrixToNonJittered")]
    [Category("UnityEngine/Camera")]
    [AddComponentMenu("CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye)")]
    public sealed class Camera_CopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye_Node : BTActionNode<UnityEngine.Camera>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.Camera.StereoscopicEye> eye;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Camera)MyAgent).CopyStereoDeviceProjectionMatrixToNonJittered(eye);
            return Status.Succeeded;
        }
    }
}




