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
    [Icon("DefaultAsset Icon")]
    [DisplayName("Renderer_GetSharedMaterials")]
    [Category("UnityEngine/Renderer")]
    [AddComponentMenu("GetSharedMaterials(List`1)")]
    public sealed class Renderer_GetSharedMaterials_List_1_Material : BTActionNode<UnityEngine.Renderer>
    {
        [Space]
        public Megumin.Binding.RefVar_Material_List m;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Renderer)MyAgent).GetSharedMaterials(m);
            return Status.Succeeded;
        }
    }
}




