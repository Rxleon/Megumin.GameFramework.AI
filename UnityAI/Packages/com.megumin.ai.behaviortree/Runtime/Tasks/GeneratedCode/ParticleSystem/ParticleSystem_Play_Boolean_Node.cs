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
    [DisplayName("ParticleSystem_Play")]
    [Category("UnityEngine/ParticleSystem")]
    [AddComponentMenu("Play(Boolean)")]
    public sealed class ParticleSystem_Play_Boolean_Node : BTActionNode<UnityEngine.ParticleSystem>
    {
        [Space]
        public Megumin.Binding.RefVar_Bool withChildren;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.ParticleSystem)MyAgent).Play(withChildren);
            return Status.Succeeded;
        }
    }
}




