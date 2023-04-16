﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Megumin.Binding;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [Icon("console.infoicon@2x")]
    [Category("Debug")]
    internal class DecoratorLog : BTDecorator, IPreDecorator, IPostDecorator, IAbortDecorator
    {
        public bool PreLog = false;
        public bool PostLog = false;
        public bool AbortLog = false;

        public RefVar_String LogStr = new() { value = "Hello world!" };

        public void BeforeNodeEnter()
        {
            if (PreLog)
            {
                Debug.Log($"PreDeco: {Owner}  {(string)LogStr}");
            }
        }

        public Status AfterNodeExit(Status result)
        {
            if (PostLog)
            {
                Debug.Log($"PostDeco: {Owner}  {result}  {(string)LogStr}");
            }
            return result;
        }

        public void OnNodeAbort()
        {
            if (AbortLog)
            {
                Debug.Log($"AbortDeco: {Owner}  {(string)LogStr}");
            }
        }
    }
}
