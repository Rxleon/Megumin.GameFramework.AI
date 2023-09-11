﻿using System.Collections;
using System.Collections.Generic;
using Megumin.Binding;
using UnityEngine;

namespace Megumin.AI.BehaviorTree
{
    /// <summary>
    /// 巡逻节点
    /// </summary>
    public class Patrol_1 : BTActionNode<IMoveToable<Vector3>>
    {
        [Space]
        public float StopingDistance = 0.25f;

        public bool IgnoreYAxis = false;
        public RefVar_Transform_List DestinationList;


        Transform lastDes;
        int lastDesIndex = 0;
        protected override Status OnTick(BTNode from, object options = null)
        {
            if (lastDes == null && TryMoveNext() == false)
            {
                return Status.Failed;
            }

            if (Transform.IsArrive(lastDes.position, StopingDistance, IgnoreYAxis))
            {
                if (TryMoveNext())
                {
                    return Status.Running;
                }
                else
                {
                    return Status.Succeeded;
                }
            }

            return Status.Running;
        }

        public bool TryMoveNext()
        {
            if (!lastDes)
            {

                var list = DestinationList?.Value;
                if (list != null && list.Count != 0)
                {
                    lastDes = list[lastDesIndex % list.Count].transform;
                    lastDesIndex++;
                    return MyAgent.MoveTo(lastDes.position);
                }
            }

            if (!lastDes)
            {
                return false;
            }

            return true;
        }
    }

    public class Patrol_2 : BTActionNode<IMoveToable<Vector3>>
    {
        [Space]
        public float StopingDistance = 0.25f;

        public bool IgnoreYAxis = false;

        Vector3 start;
        protected override void OnEnter(object options = null)
        {
            start = Transform.position;
            TryMoveNext();
        }


        Vector3 lastDes;
        protected override Status OnTick(BTNode from, object options = null)
        {
            if (Transform.IsArrive(lastDes, StopingDistance, IgnoreYAxis))
            {
                //IDEL
                if (TryMoveNext())
                {
                    return Status.Running;
                }
                else
                {
                    return Status.Succeeded;
                }
            }

            return Status.Running;
        }

        public bool TryMoveNext()
        {
            var random = Random.insideUnitSphere;
            if (IgnoreYAxis)
            {
                random.y = 0;
            }

            var next = start + random * 2;
            MyAgent.MoveTo(next);
            return true;
        }
    }
}
