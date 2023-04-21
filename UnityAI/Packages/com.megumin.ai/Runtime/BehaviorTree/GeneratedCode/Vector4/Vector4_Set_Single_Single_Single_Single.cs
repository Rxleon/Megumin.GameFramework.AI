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
    [DisplayName("Vector4_Set")]
    [Category("Unity/Vector4")]
    [AddComponentMenu("Set(Single, Single, Single, Single)")]
    public sealed class Vector4_Set_Single_Single_Single_Single : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Vector4 MyAgent;

        [Space]
        public Megumin.Binding.RefVar_Float newX;
        public Megumin.Binding.RefVar_Float newY;
        public Megumin.Binding.RefVar_Float newZ;
        public Megumin.Binding.RefVar_Float newW;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Vector4)MyAgent).Set(newX, newY, newZ, newW);
            return Status.Succeeded;
        }
    }
}




