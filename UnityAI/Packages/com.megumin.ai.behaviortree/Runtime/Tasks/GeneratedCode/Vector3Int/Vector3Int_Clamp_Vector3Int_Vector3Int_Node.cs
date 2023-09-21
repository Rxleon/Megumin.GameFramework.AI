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
    [DisplayName("Vector3Int_Clamp")]
    [Category("UnityEngine/Vector3Int")]
    [AddComponentMenu("Clamp(Vector3Int, Vector3Int)")]
    public sealed class Vector3Int_Clamp_Vector3Int_Vector3Int_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector3Int MyAgent;

        [Space]
        public Megumin.Binding.RefVar_Vector3Int min;
        public Megumin.Binding.RefVar_Vector3Int max;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Vector3Int)MyAgent).Clamp(min, max);
            return Status.Succeeded;
        }
    }
}




