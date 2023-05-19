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
    [DisplayName("Vector2Int_ToString")]
    [Category("UnityEngine/Vector2Int")]
    [AddComponentMenu("ToString(String)")]
    public sealed class Vector2Int_ToString_String_Method_Decorator : CompareDecorator<string>
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2Int MyAgent;

        [Space]
        public Megumin.Binding.RefVar_String format;

        [Space]
        public Megumin.Binding.RefVar_String CompareTo;

        [Space]
        public Megumin.Binding.RefVar_String SaveValueTo;

        public override string GetResult()
        {
            var result = ((UnityEngine.Vector2Int)MyAgent).ToString(format);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return result;
        }

        public override string GetCompareTo()
        {
            return CompareTo;
        }

    }
}




