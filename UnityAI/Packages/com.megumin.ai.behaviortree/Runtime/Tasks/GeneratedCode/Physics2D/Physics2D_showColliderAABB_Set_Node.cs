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
    [DisplayName("Set_Physics2D_showColliderAABB")]
    [Category("UnityEngine/Physics2D")]
    [AddComponentMenu("Set_showColliderAABB")]
    [Obsolete("Obsolete API in a future version of Unity", true)]
    public sealed class Physics2D_showColliderAABB_Set_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Bool Value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.Physics2D.showColliderAABB = Value;
            return Status.Succeeded;
        }

    }
}




