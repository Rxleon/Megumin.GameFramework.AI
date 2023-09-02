using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Megumin;
using Megumin.Binding;
using UnityEngine;
using UnityEngine.AI;

namespace Megumin.AI.BehaviorTree
{
    [Icon("d_NavMeshAgent Icon")]
    [DisplayName("MoveTo")]
    [Category("UnityEngine/NavMeshAgent")]
    [AddComponentMenu("MoveTo(SetDestination)")]
    public class MoveTo_SetDestination : MoveToBase<NavMeshAgent>
    {
        [Space]
        public Destination destination;

        protected override void InternalMoveTo()
        {
            Last = GetDestination();
            MyAgent.SetDestination(Last);
            this.Transform.LookAt(Last);

            GetLogger()?.WriteLine($"MyAgent : {MyAgent}  <color=#89CFF0>MoveTo</color>  Des : {destination?.Dest_Transform?.Value.name}    {Last}");
        }


        protected override Vector3 GetDestination()
        {
            return destination.GetDestination();
        }
    }
}
