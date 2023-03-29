﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megumin.GameFramework.AI.BehaviorTree
{
    /// <summary>
    /// 为什么是Sequence不是Sequencer，因为Sequence字符串长度和Selector一样。
    /// </summary>
    public class Sequence : CompositeNode
    {
        protected override Status OnTick(BTNode from)
        {
            for (int i = 0; i < children.Count; i++)
            {
                BTNode target = null;
                var child = children[i];

                if (i >= current)
                {
                    target = child;
                }
                else
                {
                    if (Dynamic)
                    {
                        //需要保持前面的节点结果值一直是Succeeded。
                        if (child.CanExecute())
                        {
                            //条件装饰器成功，
                            //Q：这里到底还要不要继续检查节点本身是否成功？？？
                            //A：与AbortLowerPriority不同，这里设计为 也检查节点本身。
                            //通常情况，这里的节点都是条件节点，只有Sequence的最后一个节点是非条件节点。
                            //所以检查节点本身并会阻塞非条件节点的运行。

                            //但是：如果当前Sequence含有多于一个非条件节点，并且dynamic，
                            //那么第一个非条件节点总是会终止后面的非条件节点，并重新运行。
                            //等同于第一个非条件节点无限循环。

                            target = child;
                            //这里标记一下已经检查过了，马上下一次Tick就不要重复检查，防止连续调用2次。
                            target.IsCheckedCanExecute = true;
                        }
                        else
                        {
                            //前面的节点条件装饰器失败，不需要继续检查节点本身，等于节点结果失败。直接终止。
                            TryAbortLastRunning();
                            current = i;
                            return Status.Failed;
                        }
                    }
                    else
                    {
                        //需要保持前面的节点结果值一直是Succeeded。

                        //这里不处理所有的条件装饰器，仅仅考虑终止低优先级条件装饰器，其他的忽略，不在重复检查
                        if (child.ExecuteConditionDecoratorCheckAbortLowerPriority())
                        {
                            //终止低优先级条件装饰器成功，
                            //Q：这里到底还要不要继续检查节点本身是否成功？？？
                            //A：这里设计为不在继续检查节点本身。默认为节点本身也成功，跳过节点本身。
                            //A：这样设计等价于，前面所有节点的终止低优先级条件装饰器，附加到running节点变为AbortSelf。

                            //如果这里设计为 也检查节点本身，如果节点是复合节点，下面一堆子节点，
                            //那么序列节点每次需要执行的东西太多，相当于每次执行都把前面所有的节点都执行一遍。

                            //target = child;
                            //这里标记一下已经检查过了，马上下一次Tick就不要重复检查，防止连续调用2次。
                            //target.IsCheckedCanExecute = true;

                            //注意，这里马上会Tick这个child，会继续调用 CanExecute，
                            //所以标记AbortLowerPriority的条件装饰器被连续调用2次，这是无法避免的。
                            //可能优化方式是记录求值时的帧号，但是开销反而更大，所以目前保持现状。
                        }
                        else
                        {
                            //前面的节点条件装饰器失败，不需要继续检查节点本身，等于节点结果失败。直接终止。
                            TryAbortLastRunning();
                            current = i;
                            return Status.Failed;
                        }
                    }
                }

                void TryAbortLastRunning()
                {
                    if (i < current)
                    {
                        //终止成功
                        var lastRunning = children[current];
                        Log($"{child} AbortLowerPriority {lastRunning}");
                        lastRunning.Abort(this);
                    }
                }

                if (target != null)
                {
                    var result = target.Tick(this);
                    if (result == Status.Running)
                    {
                        TryAbortLastRunning();
                        current = i;
                        return Status.Running;
                    }
                    else if (result == Status.Failed)
                    {
                        TryAbortLastRunning();
                        current = i;
                        return Status.Failed;
                    }

                    //指针只能向右移动
                    current = Math.Max(current, i);
                }
            }

            return Status.Succeeded;
        }
    }
}
