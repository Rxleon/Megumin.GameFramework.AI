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
    [Icon("d_ParticleSystem Icon")]
    [DisplayName("Get_ParticleSystem_isPaused")]
    [Category("UnityEngine/ParticleSystem")]
    [AddComponentMenu("Get_isPaused")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class ParticleSystem_isPaused_Get_Node : BTActionNode<UnityEngine.ParticleSystem>
    {
        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = ((UnityEngine.ParticleSystem)MyAgent).isPaused;

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }

    }
}




