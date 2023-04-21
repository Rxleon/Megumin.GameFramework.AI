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
    [Icon("ParticleSystem Icon")]
    [DisplayName("ParticleSystem_Simulate")]
    [Category("Unity/ParticleSystem")]
    [AddComponentMenu("Simulate(Single, Boolean, Boolean, Boolean)")]
    public sealed class ParticleSystem_Simulate_Single_Boolean_Boolean_Boolean : BTActionNode<UnityEngine.ParticleSystem>
    {
        [Space]
        public Megumin.Binding.RefVar_Float t;
        public Megumin.Binding.RefVar_Bool withChildren;
        public Megumin.Binding.RefVar_Bool restart;
        public Megumin.Binding.RefVar_Bool fixedTimeStep;

        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.ParticleSystem)MyAgent).Simulate(t, withChildren, restart, fixedTimeStep);
            return Status.Succeeded;
        }
    }
}




