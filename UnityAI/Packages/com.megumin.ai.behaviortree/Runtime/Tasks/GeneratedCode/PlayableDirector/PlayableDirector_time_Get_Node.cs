﻿///********************************************************************************************************************************
///The code on this page is generated by the code generator, do not manually modify.
///CodeGenerator: Megumin.CSCodeGenerator.  Version: 1.0.2
///CodeGenericBy: Megumin.AI.BehaviorTree.Editor.NodeGenerator
///CodeGenericSourceFilePath: Packages/com.megumin.ai.behaviortree/Editor/Generator/NodeGeneraotr.asset
///********************************************************************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Megumin.AI.BehaviorTree
{
    [Icon("d_PlayableDirector Icon")]
    [DisplayName("Get_PlayableDirector_time")]
    [Category("UnityEngine/PlayableDirector")]
    [AddComponentMenu("Get_time")]
    public sealed class PlayableDirector_time_Get_Node : BTActionNode<UnityEngine.Playables.PlayableDirector>
    {
        [Space]
        public Megumin.Binding.RefVar_Double SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = ((UnityEngine.Playables.PlayableDirector)MyAgent).time;

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }

    }
}




