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
    [DisplayName("Camera_Render")]
    [Category("UnityEngine/Camera")]
    [AddComponentMenu("Render")]
    public sealed class Camera_Render_Node : BTActionNode<UnityEngine.Camera>
    {
        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Camera)MyAgent).Render();
            return Status.Succeeded;
        }
    }
}




