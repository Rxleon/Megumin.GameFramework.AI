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
    [Icon("d_GameObject Icon")]
    [DisplayName("GameObject_BroadcastMessage")]
    [Category("UnityEngine/GameObject")]
    [AddComponentMenu("BroadcastMessage(String)")]
    public sealed class GameObject_BroadcastMessage_String_Node : BTActionNode<UnityEngine.GameObject>
    {
        [Space]
        public Megumin.Binding.RefVar_String methodName;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.GameObject)MyAgent).BroadcastMessage(methodName);
            return Status.Succeeded;
        }
    }
}




