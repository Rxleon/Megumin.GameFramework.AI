﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：$(CodeGenericType)
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

using System;
using Megumin.Serialization;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    public sealed partial class BT_WaitAndLog_71ad0dfc_da1a_4b3c_b95d_b4276312641a_Creator : BehaviorTreeCreator
    {
        static readonly Unity.Profiling.ProfilerMarker instantiateMarker = new("WaitAndLog_Init");
        public override BehaviorTree Instantiate(InitOption initOption, IRefFinder refFinder = null)
        {
            using var profiler = instantiateMarker.Auto();

            if (initOption == null)
            {
                return null;
            }

            BehaviorTree tree = new();
            tree.GUID = "71ad0dfc-da1a-4b3c-b95d-b4276312641a";
            tree.RootTree = tree;
            tree.InitOption = initOption;

            //生成节点
            var temp_2f7d3ba7_cfbb_416a_a003_e1d3ed6f0707 = new Megumin.GameFramework.AI.BehaviorTree.Log();
            var temp_46091aac_2293_44bf_881e_5e3476886543 = new Megumin.GameFramework.AI.BehaviorTree.Wait();
            var temp_62f41474_7568_45c7_946e_cdf5ad45fff4 = new Megumin.GameFramework.AI.BehaviorTree.Wait();
            var temp_a734621c_96b6_4a26_898c_0e4d45f5dba2 = new Megumin.GameFramework.AI.BehaviorTree.Sequence();
            return tree;
        }
    }
}
