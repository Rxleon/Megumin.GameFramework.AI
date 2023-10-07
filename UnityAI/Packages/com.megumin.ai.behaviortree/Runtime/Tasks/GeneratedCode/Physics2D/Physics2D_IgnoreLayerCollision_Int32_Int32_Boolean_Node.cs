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
    [DisplayName("Physics2D_IgnoreLayerCollision")]
    [Category("UnityEngine/Physics2D")]
    [AddComponentMenu("IgnoreLayerCollision(Int32, Int32, Boolean)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Physics2D_IgnoreLayerCollision_Int32_Int32_Boolean_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Int layer1;
        public Megumin.Binding.RefVar_Int layer2;
        public Megumin.Binding.RefVar_Bool ignore;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.Physics2D.IgnoreLayerCollision(layer1, layer2, ignore);
            return Status.Succeeded;
        }
    }
}




