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
    [Icon("d_SphereCollider Icon")]
    [DisplayName("Get_SphereCollider_radius")]
    [Category("UnityEngine/SphereCollider")]
    [AddComponentMenu("Get_radius")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class SphereCollider_radius_Get_Node : BTActionNode<UnityEngine.SphereCollider>
    {
        [Space]
        public Megumin.Binding.RefVar_Float SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = ((UnityEngine.SphereCollider)MyAgent).radius;

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }

    }
}




