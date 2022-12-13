﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;
using System.Linq;

namespace Megumin.Binding
{
    public interface IData
    {

    }

    public interface IData<T> : IData
    {
        T Value { get; set; }
    }

    public interface IBindable
    {
        //string BindingPath { get; set; }
    }

    public interface IBindable<T> : IBindable
    {
        //T DefaultValue { get; set; }
    }

    public interface IBindingParseable
    {
        void ParseBinding(object bindInstance, bool force = false);
        string DebugParseResult();
    }

    [Flags]
    public enum ParseBindingResult
    {
        /// <summary>
        /// Get Set 均解析失败
        /// </summary>
        None = 0,
        Get = 1 << 0,
        Set = 1 << 1,
        Both = Get | Set,
    }
}