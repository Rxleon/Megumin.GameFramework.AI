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
    [DisplayName("Physics2D_alwaysShowColliders")]
    [Category("UnityEngine/Physics2D")]
    [AddComponentMenu("alwaysShowColliders")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    [Obsolete("Obsolete API in a future version of Unity", true)]
    public sealed class Physics2D_alwaysShowColliders_Decorator : ConditionDecorator
    {
        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = UnityEngine.Physics2D.alwaysShowColliders;

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

    }
}




