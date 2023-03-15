﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Megumin.Binding
{
    [Serializable]
    public class Variable : IVariable
    {
        public virtual object GetValue()
        {
            return null;
        }

        public virtual void SetValue(object value)
        {

        }
    }

    /// <summary>
    /// 有Value 不一定有Path ，有Path 不一定有 RefName
    /// 需要特化类型，不然不支持泛型序列化的版本没办法UndoRecode。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class Variable<T> : Variable, IVariable<T>, IBindableFallback, IVariableSpecializedType
    {
        [field: SerializeField]
        protected T value;

        public virtual Type SpecializedType => typeof(T);

        public virtual T Value { get => value; set => this.value = value; }

        public override object GetValue()
        {
            return Value;
        }

        public override void SetValue(object value)
        {
            Value = (T)value;
        }

        public virtual object GetFallbackValue()
        {
            return value;
        }

        public virtual void SetFallbackValue(object value)
        {
            this.value = (T)value;
        }
    }

    /// <summary>
    /// Get,Set 分别设置
    /// </summary>
    [Flags]
    public enum ParseMode
    {
        None = 0,
        Log = 1 << 0,
        Worning = 1 << 1,
        Error = 1 << 2,
        ThrowException = 1 << 3,
        FallbackValue = 1 << 4,
        FallbackTypeDefault = 1 << 5,
    }

    /// <summary>
    /// 绑定到一个组件。但是不能存到参数表中，也不能共享
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class BindingVariable<T> : Variable<T>, IBindable, IBindingParseable
    {
        [field: BindingPathSetter]
        [field: SerializeField]
        public string BindingPath { get; set; }
        public ParseMode GetMode = ParseMode.FallbackValue;
        public ParseMode SetMode = ParseMode.FallbackValue;

        public override T Value
        {
            get
            {
                if (ParseResult.HasValue)
                {
                    if (ParseResult.Value.HasFlag(ParseBindingResult.Get))
                    {
                        //解析成功
                        return Getter();
                    }
                    else
                    {
                        //解析失败
                        if (GetMode.HasFlag(ParseMode.Log))
                        {
                            string message = $"ParseResult:{ParseResult}  |  {typeof(T)}  |  {BindingPath}";
                            Debug.Log(message);
                        }

                        if (GetMode.HasFlag(ParseMode.FallbackValue))
                        {
                            return base.value;
                        }

                        if (GetMode.HasFlag(ParseMode.FallbackTypeDefault))
                        {
                            return default;
                        }

                        throw new Exception();
                    }

                }
                else
                {
                    //还未解析
                    if (GetMode.HasFlag(ParseMode.Log))
                    {
                        string message = $"ParseResult:{ParseResult}  |  {typeof(T)}  |  {BindingPath}";
                        Debug.Log(message);
                    }
                    return default;
                }
            }

            set
            {
                base.Value = value;
            }
        }

        /// <summary>
        /// null表示还没有解析绑定
        /// </summary>
        [NonSerialized]
        protected ParseBindingResult? ParseResult = null;
        protected Func<T> Getter;
        protected Action<T> Setter;
        static readonly object parseLock = new object();
        public ParseBindingResult ParseBinding(object bindInstance, bool force = false)
        {
            lock (parseLock)
            {
                if (ParseResult == null || force)
                {
                    object instance = bindInstance;

                    (ParseResult, Getter, Setter) =
                        BindingParser.Instance.ParseBinding<T>(BindingPath, instance);
                }

                return ParseResult ?? ParseBindingResult.None;
            }
        }

        public string DebugParseResult()
        {
            string message = $"ParseResult:{ParseResult}  |  {typeof(T)}  |  {BindingPath}";
            Debug.Log(message);
            return message;
        }
    }
}


