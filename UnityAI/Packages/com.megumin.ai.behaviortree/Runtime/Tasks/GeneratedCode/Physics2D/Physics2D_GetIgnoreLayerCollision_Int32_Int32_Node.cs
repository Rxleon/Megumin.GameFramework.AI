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
    [DisplayName("Physics2D_GetIgnoreLayerCollision")]
    [Category("UnityEngine/Physics2D")]
    [AddComponentMenu("GetIgnoreLayerCollision(Int32, Int32)")]
    public sealed class Physics2D_GetIgnoreLayerCollision_Int32_Int32_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Int layer1;
        public Megumin.Binding.RefVar_Int layer2;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.Physics2D.GetIgnoreLayerCollision(layer1, layer2);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




