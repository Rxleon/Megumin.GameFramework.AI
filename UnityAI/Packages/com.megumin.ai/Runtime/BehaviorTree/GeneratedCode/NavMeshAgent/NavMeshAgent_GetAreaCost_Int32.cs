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
    [DisplayName("NavMeshAgent_GetAreaCost")]
    [Category("Unity/NavMeshAgent")]
    [AddComponentMenu("GetAreaCost(Int32)")]
    public sealed class NavMeshAgent_GetAreaCost_Int32 : BTActionNode<UnityEngine.AI.NavMeshAgent>
    {
        [Space]
        public Megumin.Binding.RefVar_Int areaIndex;

        [Space]
        public Megumin.Binding.RefVar_Float SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = ((UnityEngine.AI.NavMeshAgent)MyAgent).GetAreaCost(areaIndex);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




