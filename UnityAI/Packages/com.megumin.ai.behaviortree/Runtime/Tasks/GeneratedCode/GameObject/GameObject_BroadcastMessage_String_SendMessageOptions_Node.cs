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
    [Icon("GameObject Icon")]
    [DisplayName("GameObject_BroadcastMessage")]
    [Category("UnityEngine/GameObject")]
    [AddComponentMenu("BroadcastMessage(String, SendMessageOptions)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class GameObject_BroadcastMessage_String_SendMessageOptions_Node : BTActionNode<UnityEngine.GameObject>
    {
        [Space]
        public Megumin.Binding.RefVar_String methodName;
        public Megumin.Binding.RefVar<UnityEngine.SendMessageOptions> options;

        protected override Status OnTick(BTNode from, object options1 = null)
        {
            ((UnityEngine.GameObject)MyAgent).BroadcastMessage(methodName, options);
            return Status.Succeeded;
        }
    }
}




