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
    [DisplayName("ParticleSystem_SetCustomParticleData")]
    [Category("UnityEngine/ParticleSystem")]
    [AddComponentMenu("SetCustomParticleData(List`1, ParticleSystemCustomData)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class ParticleSystem_SetCustomParticleData_List_1_Vector4_ParticleSystemCustomData_Node : BTActionNode<UnityEngine.ParticleSystem>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector4_List customData;
        public Megumin.Binding.RefVar<UnityEngine.ParticleSystemCustomData> streamIndex;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.ParticleSystem)MyAgent).SetCustomParticleData(customData, streamIndex);
            return Status.Succeeded;
        }
    }
}




