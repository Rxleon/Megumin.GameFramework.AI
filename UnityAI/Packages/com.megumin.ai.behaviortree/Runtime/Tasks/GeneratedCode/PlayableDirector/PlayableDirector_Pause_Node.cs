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
    [DisplayName("PlayableDirector_Pause")]
    [Category("UnityEngine/PlayableDirector")]
    [AddComponentMenu("Pause")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class PlayableDirector_Pause_Node : BTActionNode<UnityEngine.Playables.PlayableDirector>
    {
        protected override Status OnTick(BTNode from, object options = null)
        {
            ((UnityEngine.Playables.PlayableDirector)MyAgent).Pause();
            return Status.Succeeded;
        }
    }
}




