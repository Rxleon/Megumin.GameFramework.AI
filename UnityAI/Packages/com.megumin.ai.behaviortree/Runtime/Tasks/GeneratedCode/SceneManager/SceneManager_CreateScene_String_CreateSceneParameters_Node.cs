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
    [DisplayName("SceneManager_CreateScene")]
    [Category("UnityEngine/SceneManager")]
    [AddComponentMenu("CreateScene(String, CreateSceneParameters)")]
    [CodeGeneratorInfo(Name = "Megumin.CSCodeGenerator")]
    public sealed class SceneManager_CreateScene_String_CreateSceneParameters_Node : BTActionNode
    {
        [Space]
        public Megumin.Binding.RefVar_String sceneName;
        public Megumin.Binding.RefVar<UnityEngine.SceneManagement.CreateSceneParameters> parameters;

        [Space]
        public Megumin.Binding.RefVar<UnityEngine.SceneManagement.Scene> SaveValueTo;

        protected override Status OnTick(BTNode from, object options = null)
        {
            var result = UnityEngine.SceneManagement.SceneManager.CreateScene(sceneName, parameters);

            if (SaveValueTo != null)
            {
                SaveValueTo.Value = result;
            }

            return Status.Succeeded;
        }
    }
}




