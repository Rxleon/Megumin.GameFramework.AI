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
    [Icon("Rigidbody2D Icon")]
    [DisplayName("Rigidbody2D_MoveRotation")]
    [Category("UnityEngine/Rigidbody2D")]
    [AddComponentMenu("MoveRotation(Single)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Rigidbody2D_MoveRotation_Single_Node : BTActionNode<UnityEngine.Rigidbody2D>
    {
        [Space]
        public Megumin.Binding.RefVar_Float angle;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Rigidbody2D)MyAgent).MoveRotation(angle);
            return Status.Succeeded;
        }
    }
}




