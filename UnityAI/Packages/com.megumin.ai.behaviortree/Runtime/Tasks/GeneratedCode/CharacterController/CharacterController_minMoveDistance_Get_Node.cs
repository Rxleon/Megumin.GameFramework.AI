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
    [DisplayName("Get_CharacterController_minMoveDistance")]
    [Category("UnityEngine/CharacterController")]
    [AddComponentMenu("Get_minMoveDistance")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class CharacterController_minMoveDistance_Get_Node : BTActionNode<UnityEngine.CharacterController>
    {
        [Space]
        public Megumin.Binding.RefVar_Float SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = ((UnityEngine.CharacterController)MyAgent).minMoveDistance;

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }

    }
}




