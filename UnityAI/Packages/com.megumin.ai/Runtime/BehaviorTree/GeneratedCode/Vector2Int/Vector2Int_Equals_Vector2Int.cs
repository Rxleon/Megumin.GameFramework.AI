﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：Megumin.GameFramework.AI.BehaviorTree.Editor.NodeGenerator
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [DisplayName("Vector2Int_Equals")]
    [Category("UnityEngine/Vector2Int")]
    [AddComponentMenu("Equals(Vector2Int)")]
    public sealed class Vector2Int_Equals_Vector2Int : ConditionDecorator
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2Int MyAgent;

        [Space]
        public Megumin.Binding.RefVar_Vector2Int other;

        [Space]
        public Megumin.Binding.RefVar_Bool SaveValueTo;

        public override bool CheckCondition(object options = null)
        {
            var result = ((UnityEngine.Vector2Int)MyAgent).Equals(other);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }
    }
}




