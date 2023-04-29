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
    [Icon("GameObject Icon")]
    [DisplayName("GameObject_Find")]
    [Category("UnityEngine/GameObject")]
    [AddComponentMenu("Find(String)")]
    public sealed class GameObject_Find_String : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_String name;

        [Space]
        public Megumin.Binding.RefVar_GameObject SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.GameObject.Find(name);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}



