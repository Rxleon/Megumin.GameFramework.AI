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
    [DisplayName("SceneManager_GetSceneAt")]
    [Category("UnityEngine/SceneManager")]
    [AddComponentMenu("GetSceneAt(Int32)")]
    public sealed class SceneManager_GetSceneAt_Int32 : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_Int index;

        [Space]
        public Megumin.Binding.RefVar<UnityEngine.SceneManagement.Scene> SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




