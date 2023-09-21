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
    [DisplayName("SceneManager_LoadScene")]
    [Category("UnityEngine/SceneManager")]
    [AddComponentMenu("LoadScene(String, LoadSceneMode)")]
    public sealed class SceneManager_LoadScene_String_LoadSceneMode_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_String sceneName;
        public Megumin.Binding.RefVar<UnityEngine.SceneManagement.LoadSceneMode> mode;

        protected override Status OnTick(BTNode from, object options = null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName, mode);
            return Status.Succeeded;
        }
    }
}




