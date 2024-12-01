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
    [Icon("ParticleSystem Icon")]
    [DisplayName("ParticleSystem_GetCustomParticleData")]
    [Category("UnityEngine/ParticleSystem")]
    [AddComponentMenu("GetCustomParticleData(List`1, ParticleSystemCustomData)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class ParticleSystem_GetCustomParticleData_List_1_Vector4_ParticleSystemCustomData_Method_Decorator : CompareDecorator<UnityEngine.ParticleSystem, int>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector4_List customData;
        public Megumin.Binding.RefVar<UnityEngine.ParticleSystemCustomData> streamIndex;

        [Space]
        public Megumin.Binding.RefVar_Int CompareTo;

        [Space]
        public Megumin.Binding.RefVar_Int SaveValueTo;

        public override int GetResult()
        {
            var result = ((UnityEngine.ParticleSystem)MyAgent).GetCustomParticleData(customData, streamIndex);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

        public override int GetCompareTo()
        {
            return CompareTo;
        }

    }
}




