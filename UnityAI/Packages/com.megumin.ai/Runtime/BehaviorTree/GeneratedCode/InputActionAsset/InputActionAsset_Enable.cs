﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：Megumin.GameFramework.AI.BehaviorTree.Editor.NodeGeneraotr
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

#if ENABLE_INPUT_SYSTEM

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [Icon("DefaultAsset Icon")]
    [DisplayName("InputActionAsset_Enable")]
    [Category("Unity/InputActionAsset")]
    [AddComponentMenu("Enable")]
    public sealed class InputActionAsset_Enable : BTActionNode
    {
        [Space]
        public UnityEngine.InputSystem.InputActionAsset MyAgent;


        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.InputSystem.InputActionAsset)MyAgent).Enable();
            return Status.Succeeded;
        }
    }
}

#endif




