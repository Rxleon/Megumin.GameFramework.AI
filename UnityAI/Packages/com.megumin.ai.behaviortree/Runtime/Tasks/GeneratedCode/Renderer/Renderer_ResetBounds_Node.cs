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
    [Icon("DefaultAsset Icon")]
    [DisplayName("Renderer_ResetBounds")]
    [Category("UnityEngine/Renderer")]
    [AddComponentMenu("ResetBounds")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Renderer_ResetBounds_Node : BTActionNode<UnityEngine.Renderer>
    {
        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Renderer)MyAgent).ResetBounds();
            return Status.Succeeded;
        }
    }
}




