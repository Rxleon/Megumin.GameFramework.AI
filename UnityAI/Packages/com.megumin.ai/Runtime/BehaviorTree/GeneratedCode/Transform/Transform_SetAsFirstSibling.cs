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
    [Icon("Transform Icon")]
    [DisplayName("Transform_SetAsFirstSibling")]
    [Category("Unity/Transform")]
    [AddComponentMenu("SetAsFirstSibling")]
    public sealed class Transform_SetAsFirstSibling : BTActionNode<UnityEngine.Transform>
    {

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Transform)MyAgent).SetAsFirstSibling();
            return Status.Succeeded;
        }
    }
}




