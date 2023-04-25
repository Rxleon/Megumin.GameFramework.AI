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
    [DisplayName("PlayerPrefs_SetFloat")]
    [Category("UnityEngine/PlayerPrefs")]
    [AddComponentMenu("SetFloat(String, Single)")]
    public sealed class PlayerPrefs_SetFloat_String_Single : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_String key;
        public Megumin.Binding.RefVar_Float value;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.PlayerPrefs.SetFloat(key, value);
            return Status.Succeeded;
        }
    }
}




