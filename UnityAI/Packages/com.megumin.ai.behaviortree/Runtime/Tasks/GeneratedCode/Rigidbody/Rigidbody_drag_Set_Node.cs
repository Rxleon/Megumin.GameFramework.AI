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
    [Icon("Rigidbody Icon")]
    [DisplayName("Set_Rigidbody_drag")]
    [Category("UnityEngine/Rigidbody")]
    [AddComponentMenu("Set_drag")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Rigidbody_drag_Set_Node : BTActionNode<UnityEngine.Rigidbody>
    {
        [Space]
        public Megumin.Binding.RefVar_Float Value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Rigidbody)MyAgent).drag = Value;
            return Status.Succeeded;
        }

    }
}




