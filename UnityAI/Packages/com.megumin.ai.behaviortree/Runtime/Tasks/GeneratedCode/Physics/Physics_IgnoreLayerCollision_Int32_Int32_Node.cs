﻿///********************************************************************************************************************************
///The code on this page is generated by the code generator, do not manually modify.
///CodeGenerator: Megumin.CSCodeGenerator.  Version: 1.0.1
///CodeGenericBy: Megumin.AI.BehaviorTree.Editor.NodeGenerator
///CodeGenericSourceFilePath: Packages/com.megumin.ai/Editor/BehaviorTree/Generator/NodeGeneraotr.asset
///********************************************************************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.AI.BehaviorTree
{
    [DisplayName("Physics_IgnoreLayerCollision")]
    [Category("UnityEngine/Physics")]
    [AddComponentMenu("IgnoreLayerCollision(Int32, Int32)")]
    public sealed class Physics_IgnoreLayerCollision_Int32_Int32_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Int layer1;
        public Megumin.Binding.RefVar_Int layer2;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.Physics.IgnoreLayerCollision(layer1, layer2);
            return Status.Succeeded;
        }
    }
}



