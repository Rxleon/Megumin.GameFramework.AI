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
    [Icon("Camera Icon")]
    [DisplayName("Camera_RemoveAllCommandBuffers")]
    [Category("Unity/Camera")]
    [AddComponentMenu("RemoveAllCommandBuffers")]
    public sealed class Camera_RemoveAllCommandBuffers : BTActionNode<UnityEngine.Camera>
    {

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Camera)MyAgent).RemoveAllCommandBuffers();
            return Status.Succeeded;
        }
    }
}




