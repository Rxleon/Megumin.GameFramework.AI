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
    [Icon("d_CircleCollider2D Icon")]
    [DisplayName("Set_CircleCollider2D_radius")]
    [Category("UnityEngine/CircleCollider2D")]
    [AddComponentMenu("Set_radius")]
    public sealed class CircleCollider2D_radius_Set_Node : BTActionNode<UnityEngine.CircleCollider2D>
    {
        [Space]
        public Megumin.Binding.RefVar_Float Value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.CircleCollider2D)MyAgent).radius = Value;
            return Status.Succeeded;
        }

    }
}




