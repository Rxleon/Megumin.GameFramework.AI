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
    [DisplayName("Vector2Int_Scale")]
    [Category("UnityEngine/Vector2Int")]
    [AddComponentMenu("Scale(Vector2Int)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class Vector2Int_Scale_Vector2Int_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2Int MyAgent;

        [Space]
        public Megumin.Binding.RefVar_Vector2Int scale;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Vector2Int)MyAgent).Scale(scale);
            return Status.Succeeded;
        }
    }
}




