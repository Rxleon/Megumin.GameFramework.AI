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
    [Icon("PlayableDirector Icon")]
    [DisplayName("PlayableDirector_ClearReferenceValue")]
    [Category("UnityEngine/PlayableDirector")]
    [AddComponentMenu("ClearReferenceValue(PropertyName)")]
    public sealed class PlayableDirector_ClearReferenceValue_PropertyName_Node : BTActionNode<UnityEngine.Playables.PlayableDirector>
    {
        [Space]
        public Megumin.Binding.RefVar<UnityEngine.PropertyName> id;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Playables.PlayableDirector)MyAgent).ClearReferenceValue(id);
            return Status.Succeeded;
        }
    }
}




