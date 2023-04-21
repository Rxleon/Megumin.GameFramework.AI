﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：Megumin.GameFramework.AI.BehaviorTree.Editor.NodeGeneraotr
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [DisplayName("Vector2Int_Clamp")]
    [Category("Unity/Vector2Int")]
    [AddComponentMenu("Clamp(Vector2Int, Vector2Int)")]
    public sealed class Vector2Int_Clamp_Vector2Int_Vector2Int : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector2Int MyAgent;

        [Space]
        public Megumin.Binding.RefVar_Vector2Int min;
        public Megumin.Binding.RefVar_Vector2Int max;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Vector2Int)MyAgent).Clamp(min, max);
            return Status.Succeeded;
        }
    }
}




