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
    [DisplayName("Set_Rigidbody_detectCollisions")]
    [Category("UnityEngine/Rigidbody")]
    [AddComponentMenu("Set_detectCollisions")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Rigidbody_detectCollisions_Set_Node : BTActionNode<UnityEngine.Rigidbody>
    {
        [Space]
        public Megumin.Binding.RefVar_Bool Value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Rigidbody)MyAgent).detectCollisions = Value;
            return Status.Succeeded;
        }

    }
}




