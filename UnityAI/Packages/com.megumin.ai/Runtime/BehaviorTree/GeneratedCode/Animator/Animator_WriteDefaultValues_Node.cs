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
    [Icon("Animator Icon")]
    [DisplayName("Animator_WriteDefaultValues")]
    [Category("UnityEngine/Animator")]
    [AddComponentMenu("WriteDefaultValues")]
    public sealed class Animator_WriteDefaultValues_Node : BTActionNode<UnityEngine.Animator>
    {
        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Animator)MyAgent).WriteDefaultValues();
            return Status.Succeeded;
        }
    }
}




