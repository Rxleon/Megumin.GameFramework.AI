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
    [Icon("Animation Icon")]
    [DisplayName("Animation_Rewind")]
    [Category("UnityEngine/Animation")]
    [AddComponentMenu("Rewind")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Animation_Rewind_Node : BTActionNode<UnityEngine.Animation>
    {
        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animation)MyAgent).Rewind();
            return Status.Succeeded;
        }
    }
}




