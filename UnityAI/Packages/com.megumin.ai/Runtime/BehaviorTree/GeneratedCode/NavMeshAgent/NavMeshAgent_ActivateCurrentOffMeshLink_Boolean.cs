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
    [Icon("NavMeshAgent Icon")]
    [DisplayName("NavMeshAgent_ActivateCurrentOffMeshLink")]
    [Category("Unity/NavMeshAgent")]
    [AddComponentMenu("ActivateCurrentOffMeshLink(Boolean)")]
    public sealed class NavMeshAgent_ActivateCurrentOffMeshLink_Boolean : BTActionNode<UnityEngine.AI.NavMeshAgent>
    {
        [Space]
        public Megumin.Binding.RefVar_Bool activated;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.AI.NavMeshAgent)MyAgent).ActivateCurrentOffMeshLink(activated);
            return Status.Succeeded;
        }
    }
}




