﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    [Category("CategoryTest")]
    [Icon("ICONS/sg_graph_icon.png")]
    public class Wait : ActionTaskNode
    {
        public float waitTime = 3f;
        public GameObject TestRef;
        public List<GameObject> TestList;
        public List<int> TestList2;

        float entertime;
        protected override void OnEnter()
        {
            entertime = Time.time;
        }

        protected override Status OnTick()
        {
            //Debug.Log($"Wait Time :{Time.time - entertime}");
            if (Time.time - entertime > waitTime)
            {
                return Status.Succeeded;
            }
            return Status.Running;
        }
    }
}
