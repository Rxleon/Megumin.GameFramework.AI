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
    [Icon("d_CharacterController Icon")]
    [DisplayName("Set_CharacterController_enableOverlapRecovery")]
    [Category("UnityEngine/CharacterController")]
    [AddComponentMenu("Set_enableOverlapRecovery")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class CharacterController_enableOverlapRecovery_Set_Node : BTActionNode<UnityEngine.CharacterController>
    {
        [Space]
        public Megumin.Binding.RefVar_Bool Value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.CharacterController)MyAgent).enableOverlapRecovery = Value;
            return Status.Succeeded;
        }

    }
}




