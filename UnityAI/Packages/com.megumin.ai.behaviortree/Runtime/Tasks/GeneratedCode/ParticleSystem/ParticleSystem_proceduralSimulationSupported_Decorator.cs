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
    [DisplayName("ParticleSystem_proceduralSimulationSupported")]
    [Category("UnityEngine/ParticleSystem")]
    [AddComponentMenu("proceduralSimulationSupported")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class ParticleSystem_proceduralSimulationSupported_Decorator : ConditionDecorator<UnityEngine.ParticleSystem>
    {
        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = ((UnityEngine.ParticleSystem)MyAgent).proceduralSimulationSupported;

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

    }
}




