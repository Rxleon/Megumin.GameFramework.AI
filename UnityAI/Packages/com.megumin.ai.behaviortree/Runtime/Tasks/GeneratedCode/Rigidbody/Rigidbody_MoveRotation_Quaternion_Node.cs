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
    [Icon("d_Rigidbody Icon")]
    [DisplayName("Rigidbody_MoveRotation")]
    [Category("UnityEngine/Rigidbody")]
    [AddComponentMenu("MoveRotation(Quaternion)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Rigidbody_MoveRotation_Quaternion_Node : BTActionNode<UnityEngine.Rigidbody>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.Quaternion> rot;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Rigidbody)MyAgent).MoveRotation(rot);
            return Status.Succeeded;
        }
    }
}




