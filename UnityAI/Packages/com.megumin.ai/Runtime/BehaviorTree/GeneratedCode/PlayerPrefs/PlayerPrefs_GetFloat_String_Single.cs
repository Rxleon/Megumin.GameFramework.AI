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
    [DisplayName("PlayerPrefs_GetFloat")]
    [Category("UnityEngine/PlayerPrefs")]
    [AddComponentMenu("GetFloat(String, Single)")]
    public sealed class PlayerPrefs_GetFloat_String_Single : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_String key;
        public Megumin.Binding.RefVar_Float defaultValue;

        [Space]
        public Megumin.Binding.RefVar_Float SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.PlayerPrefs.GetFloat(key, defaultValue);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




