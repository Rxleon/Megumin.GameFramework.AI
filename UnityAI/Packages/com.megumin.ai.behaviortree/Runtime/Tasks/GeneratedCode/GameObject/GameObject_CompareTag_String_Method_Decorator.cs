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
    [DisplayName("GameObject_CompareTag")]
    [Category("UnityEngine/GameObject")]
    [AddComponentMenu("CompareTag(String)")]
    public sealed class GameObject_CompareTag_String_Method_Decorator : ConditionDecorator<UnityEngine.GameObject>
    {
        [Space]
        public Megumin.Binding.RefVar_String tag;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = ((UnityEngine.GameObject)MyAgent).CompareTag(tag);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

    }
}




