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
    [DisplayName("Camera_ResetWorldToCameraMatrix")]
    [Category("UnityEngine/Camera")]
    [AddComponentMenu("ResetWorldToCameraMatrix")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Camera_ResetWorldToCameraMatrix_Node : BTActionNode<UnityEngine.Camera>
    {
        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Camera)MyAgent).ResetWorldToCameraMatrix();
            return Status.Succeeded;
        }
    }
}




