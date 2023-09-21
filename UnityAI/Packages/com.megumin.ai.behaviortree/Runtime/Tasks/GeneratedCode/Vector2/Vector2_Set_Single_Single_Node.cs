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
    [DisplayName("Vector2_Set")]
    [Category("UnityEngine/Vector2")]
    [AddComponentMenu("Set(Single, Single)")]
    public sealed class Vector2_Set_Single_Single_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2 MyAgent;

        [Space]
        public Megumin.Binding.RefVar_Float newX;
        public Megumin.Binding.RefVar_Float newY;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Vector2)MyAgent).Set(newX, newY);
            return Status.Succeeded;
        }
    }
}




