﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：$(CodeGenericType)
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

using System;
using System.Collections.Generic;
using Megumin.Binding;
using UnityEngine;

namespace Megumin.GameFramework.AI
{
    public partial class VariableCreator
    {
        /// <summary>
        /// 用户可以在这里添加参数类型到菜单。
        /// </summary>
        public static List<VariableCreator> AllCreator = new()
        {
            new VariableCreator_bool_Array(),
            new VariableCreator_int_Array(),
            new VariableCreator_long_Array(),
            new VariableCreator_string_Array(),
            new VariableCreator_float_Array(),
            new VariableCreator_double_Array(),
            new VariableCreator_Vector2_Array(),
            new VariableCreator_Vector2Int_Array(),
            new VariableCreator_Vector3_Array(),
            new VariableCreator_Vector3Int_Array(),
            new VariableCreator_Vector4_Array(),
            new VariableCreator_Rect_Array(),
            new VariableCreator_RectInt_Array(),
            new VariableCreator_Bounds_Array(),
            new VariableCreator_BoundsInt_Array(),
            new VariableCreator_GameObject_Array(),
            new VariableCreator_Transform_Array(),
            new VariableCreator_ScriptableObject_Array(),
            new VariableCreator_Trigger_Array(),
            new VariableCreator_Color_Array(),
            new VariableCreator_Gradient_Array(),
            new VariableCreator_Texture2D_Array(),
            new VariableCreator_RenderTexture_Array(),
            new VariableCreator_AnimationCurve_Array(),
            new VariableCreator_Mesh_Array(),
            new VariableCreator_SkinnedMeshRenderer_Array(),
            new VariableCreator_Material_Array(),
            new VariableCreator_bool_List(),
            new VariableCreator_int_List(),
            new VariableCreator_long_List(),
            new VariableCreator_string_List(),
            new VariableCreator_float_List(),
            new VariableCreator_double_List(),
            new VariableCreator_Vector2_List(),
            new VariableCreator_Vector2Int_List(),
            new VariableCreator_Vector3_List(),
            new VariableCreator_Vector3Int_List(),
            new VariableCreator_Vector4_List(),
            new VariableCreator_Rect_List(),
            new VariableCreator_RectInt_List(),
            new VariableCreator_Bounds_List(),
            new VariableCreator_BoundsInt_List(),
            new VariableCreator_GameObject_List(),
            new VariableCreator_Transform_List(),
            new VariableCreator_ScriptableObject_List(),
            new VariableCreator_Trigger_List(),
            new VariableCreator_Color_List(),
            new VariableCreator_Gradient_List(),
            new VariableCreator_Texture2D_List(),
            new VariableCreator_RenderTexture_List(),
            new VariableCreator_AnimationCurve_List(),
            new VariableCreator_Mesh_List(),
            new VariableCreator_SkinnedMeshRenderer_List(),
            new VariableCreator_Material_List(),
            new VariableCreator_bool(),
            new VariableCreator_int(),
            new VariableCreator_long(),
            new VariableCreator_string(),
            new VariableCreator_float(),
            new VariableCreator_double(),
            new Separator(),
            new VariableCreator_Vector2(),
            new VariableCreator_Vector2Int(),
            new VariableCreator_Vector3(),
            new VariableCreator_Vector3Int(),
            new VariableCreator_Vector4(),
            new VariableCreator_Rect(),
            new VariableCreator_RectInt(),
            new VariableCreator_Bounds(),
            new VariableCreator_BoundsInt(),
            new Separator(),
            new VariableCreator_GameObject(),
            new VariableCreator_Transform(),
            new VariableCreator_ScriptableObject(),
            new VariableCreator_Trigger(),
            new VariableCreator_Color(),
            new VariableCreator_Gradient(),
            new VariableCreator_Texture2D(),
            new VariableCreator_RenderTexture(),
            new VariableCreator_AnimationCurve(),
            new VariableCreator_Mesh(),
            new VariableCreator_SkinnedMeshRenderer(),
            new VariableCreator_Material(),
        };
    }

    [Serializable]
    public class RefVar_bool : RefVar<bool> { }

    public class VariableCreator_bool : VariableCreator
    {
        public override string Name { get; set; } = "bool";

        public override IRefable Create()
        {
            return new RefVar_bool() { RefName = "Bool" };
        }
    }

    [Serializable]
    public class RefVar_bool_List : RefVar<List<bool>> { }

    public class VariableCreator_bool_List : VariableCreator
    {
        public override string Name { get; set; } = "List/bool";

        public override IRefable Create()
        {
            return new RefVar_bool_List() { RefName = "List<Bool>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_bool_Array : RefVar<bool[]> { }

    public class VariableCreator_bool_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/bool";

        public override IRefable Create()
        {
            return new RefVar_bool_Array() { RefName = "Array<Bool>" };
        }
    }

    [Serializable]
    public class RefVar_int : RefVar<int> { }

    public class VariableCreator_int : VariableCreator
    {
        public override string Name { get; set; } = "int";

        public override IRefable Create()
        {
            return new RefVar_int() { RefName = "Int" };
        }
    }

    [Serializable]
    public class RefVar_int_List : RefVar<List<int>> { }

    public class VariableCreator_int_List : VariableCreator
    {
        public override string Name { get; set; } = "List/int";

        public override IRefable Create()
        {
            return new RefVar_int_List() { RefName = "List<Int>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_int_Array : RefVar<int[]> { }

    public class VariableCreator_int_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/int";

        public override IRefable Create()
        {
            return new RefVar_int_Array() { RefName = "Array<Int>" };
        }
    }

    [Serializable]
    public class RefVar_long : RefVar<long> { }

    public class VariableCreator_long : VariableCreator
    {
        public override string Name { get; set; } = "long";

        public override IRefable Create()
        {
            return new RefVar_long() { RefName = "Long" };
        }
    }

    [Serializable]
    public class RefVar_long_List : RefVar<List<long>> { }

    public class VariableCreator_long_List : VariableCreator
    {
        public override string Name { get; set; } = "List/long";

        public override IRefable Create()
        {
            return new RefVar_long_List() { RefName = "List<Long>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_long_Array : RefVar<long[]> { }

    public class VariableCreator_long_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/long";

        public override IRefable Create()
        {
            return new RefVar_long_Array() { RefName = "Array<Long>" };
        }
    }

    [Serializable]
    public class RefVar_string : RefVar<string> { }

    public class VariableCreator_string : VariableCreator
    {
        public override string Name { get; set; } = "string";

        public override IRefable Create()
        {
            return new RefVar_string() { RefName = "String" };
        }
    }

    [Serializable]
    public class RefVar_string_List : RefVar<List<string>> { }

    public class VariableCreator_string_List : VariableCreator
    {
        public override string Name { get; set; } = "List/string";

        public override IRefable Create()
        {
            return new RefVar_string_List() { RefName = "List<String>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_string_Array : RefVar<string[]> { }

    public class VariableCreator_string_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/string";

        public override IRefable Create()
        {
            return new RefVar_string_Array() { RefName = "Array<String>" };
        }
    }

    [Serializable]
    public class RefVar_float : RefVar<float> { }

    public class VariableCreator_float : VariableCreator
    {
        public override string Name { get; set; } = "float";

        public override IRefable Create()
        {
            return new RefVar_float() { RefName = "Float" };
        }
    }

    [Serializable]
    public class RefVar_float_List : RefVar<List<float>> { }

    public class VariableCreator_float_List : VariableCreator
    {
        public override string Name { get; set; } = "List/float";

        public override IRefable Create()
        {
            return new RefVar_float_List() { RefName = "List<Float>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_float_Array : RefVar<float[]> { }

    public class VariableCreator_float_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/float";

        public override IRefable Create()
        {
            return new RefVar_float_Array() { RefName = "Array<Float>" };
        }
    }

    [Serializable]
    public class RefVar_double : RefVar<double> { }

    public class VariableCreator_double : VariableCreator
    {
        public override string Name { get; set; } = "double";

        public override IRefable Create()
        {
            return new RefVar_double() { RefName = "Double" };
        }
    }

    [Serializable]
    public class RefVar_double_List : RefVar<List<double>> { }

    public class VariableCreator_double_List : VariableCreator
    {
        public override string Name { get; set; } = "List/double";

        public override IRefable Create()
        {
            return new RefVar_double_List() { RefName = "List<Double>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_double_Array : RefVar<double[]> { }

    public class VariableCreator_double_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/double";

        public override IRefable Create()
        {
            return new RefVar_double_Array() { RefName = "Array<Double>" };
        }
    }

    [Serializable]
    public class RefVar_Vector2 : RefVar<Vector2> { }

    public class VariableCreator_Vector2 : VariableCreator
    {
        public override string Name { get; set; } = "Vector2";

        public override IRefable Create()
        {
            return new RefVar_Vector2() { RefName = "Vector2" };
        }
    }

    [Serializable]
    public class RefVar_Vector2_List : RefVar<List<Vector2>> { }

    public class VariableCreator_Vector2_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Vector2";

        public override IRefable Create()
        {
            return new RefVar_Vector2_List() { RefName = "List<Vector2>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Vector2_Array : RefVar<Vector2[]> { }

    public class VariableCreator_Vector2_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Vector2";

        public override IRefable Create()
        {
            return new RefVar_Vector2_Array() { RefName = "Array<Vector2>" };
        }
    }

    [Serializable]
    public class RefVar_Vector2Int : RefVar<Vector2Int> { }

    public class VariableCreator_Vector2Int : VariableCreator
    {
        public override string Name { get; set; } = "Vector2Int";

        public override IRefable Create()
        {
            return new RefVar_Vector2Int() { RefName = "Vector2Int" };
        }
    }

    [Serializable]
    public class RefVar_Vector2Int_List : RefVar<List<Vector2Int>> { }

    public class VariableCreator_Vector2Int_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Vector2Int";

        public override IRefable Create()
        {
            return new RefVar_Vector2Int_List() { RefName = "List<Vector2Int>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Vector2Int_Array : RefVar<Vector2Int[]> { }

    public class VariableCreator_Vector2Int_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Vector2Int";

        public override IRefable Create()
        {
            return new RefVar_Vector2Int_Array() { RefName = "Array<Vector2Int>" };
        }
    }

    [Serializable]
    public class RefVar_Vector3 : RefVar<Vector3> { }

    public class VariableCreator_Vector3 : VariableCreator
    {
        public override string Name { get; set; } = "Vector3";

        public override IRefable Create()
        {
            return new RefVar_Vector3() { RefName = "Vector3" };
        }
    }

    [Serializable]
    public class RefVar_Vector3_List : RefVar<List<Vector3>> { }

    public class VariableCreator_Vector3_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Vector3";

        public override IRefable Create()
        {
            return new RefVar_Vector3_List() { RefName = "List<Vector3>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Vector3_Array : RefVar<Vector3[]> { }

    public class VariableCreator_Vector3_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Vector3";

        public override IRefable Create()
        {
            return new RefVar_Vector3_Array() { RefName = "Array<Vector3>" };
        }
    }

    [Serializable]
    public class RefVar_Vector3Int : RefVar<Vector3Int> { }

    public class VariableCreator_Vector3Int : VariableCreator
    {
        public override string Name { get; set; } = "Vector3Int";

        public override IRefable Create()
        {
            return new RefVar_Vector3Int() { RefName = "Vector3Int" };
        }
    }

    [Serializable]
    public class RefVar_Vector3Int_List : RefVar<List<Vector3Int>> { }

    public class VariableCreator_Vector3Int_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Vector3Int";

        public override IRefable Create()
        {
            return new RefVar_Vector3Int_List() { RefName = "List<Vector3Int>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Vector3Int_Array : RefVar<Vector3Int[]> { }

    public class VariableCreator_Vector3Int_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Vector3Int";

        public override IRefable Create()
        {
            return new RefVar_Vector3Int_Array() { RefName = "Array<Vector3Int>" };
        }
    }

    [Serializable]
    public class RefVar_Vector4 : RefVar<Vector4> { }

    public class VariableCreator_Vector4 : VariableCreator
    {
        public override string Name { get; set; } = "Vector4";

        public override IRefable Create()
        {
            return new RefVar_Vector4() { RefName = "Vector4" };
        }
    }

    [Serializable]
    public class RefVar_Vector4_List : RefVar<List<Vector4>> { }

    public class VariableCreator_Vector4_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Vector4";

        public override IRefable Create()
        {
            return new RefVar_Vector4_List() { RefName = "List<Vector4>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Vector4_Array : RefVar<Vector4[]> { }

    public class VariableCreator_Vector4_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Vector4";

        public override IRefable Create()
        {
            return new RefVar_Vector4_Array() { RefName = "Array<Vector4>" };
        }
    }

    [Serializable]
    public class RefVar_Rect : RefVar<Rect> { }

    public class VariableCreator_Rect : VariableCreator
    {
        public override string Name { get; set; } = "Rect";

        public override IRefable Create()
        {
            return new RefVar_Rect() { RefName = "Rect" };
        }
    }

    [Serializable]
    public class RefVar_Rect_List : RefVar<List<Rect>> { }

    public class VariableCreator_Rect_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Rect";

        public override IRefable Create()
        {
            return new RefVar_Rect_List() { RefName = "List<Rect>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Rect_Array : RefVar<Rect[]> { }

    public class VariableCreator_Rect_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Rect";

        public override IRefable Create()
        {
            return new RefVar_Rect_Array() { RefName = "Array<Rect>" };
        }
    }

    [Serializable]
    public class RefVar_RectInt : RefVar<RectInt> { }

    public class VariableCreator_RectInt : VariableCreator
    {
        public override string Name { get; set; } = "RectInt";

        public override IRefable Create()
        {
            return new RefVar_RectInt() { RefName = "RectInt" };
        }
    }

    [Serializable]
    public class RefVar_RectInt_List : RefVar<List<RectInt>> { }

    public class VariableCreator_RectInt_List : VariableCreator
    {
        public override string Name { get; set; } = "List/RectInt";

        public override IRefable Create()
        {
            return new RefVar_RectInt_List() { RefName = "List<RectInt>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_RectInt_Array : RefVar<RectInt[]> { }

    public class VariableCreator_RectInt_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/RectInt";

        public override IRefable Create()
        {
            return new RefVar_RectInt_Array() { RefName = "Array<RectInt>" };
        }
    }

    [Serializable]
    public class RefVar_Bounds : RefVar<Bounds> { }

    public class VariableCreator_Bounds : VariableCreator
    {
        public override string Name { get; set; } = "Bounds";

        public override IRefable Create()
        {
            return new RefVar_Bounds() { RefName = "Bounds" };
        }
    }

    [Serializable]
    public class RefVar_Bounds_List : RefVar<List<Bounds>> { }

    public class VariableCreator_Bounds_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Bounds";

        public override IRefable Create()
        {
            return new RefVar_Bounds_List() { RefName = "List<Bounds>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Bounds_Array : RefVar<Bounds[]> { }

    public class VariableCreator_Bounds_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Bounds";

        public override IRefable Create()
        {
            return new RefVar_Bounds_Array() { RefName = "Array<Bounds>" };
        }
    }

    [Serializable]
    public class RefVar_BoundsInt : RefVar<BoundsInt> { }

    public class VariableCreator_BoundsInt : VariableCreator
    {
        public override string Name { get; set; } = "BoundsInt";

        public override IRefable Create()
        {
            return new RefVar_BoundsInt() { RefName = "BoundsInt" };
        }
    }

    [Serializable]
    public class RefVar_BoundsInt_List : RefVar<List<BoundsInt>> { }

    public class VariableCreator_BoundsInt_List : VariableCreator
    {
        public override string Name { get; set; } = "List/BoundsInt";

        public override IRefable Create()
        {
            return new RefVar_BoundsInt_List() { RefName = "List<BoundsInt>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_BoundsInt_Array : RefVar<BoundsInt[]> { }

    public class VariableCreator_BoundsInt_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/BoundsInt";

        public override IRefable Create()
        {
            return new RefVar_BoundsInt_Array() { RefName = "Array<BoundsInt>" };
        }
    }

    [Serializable]
    public class RefVar_GameObject : RefVar<GameObject> { }

    public class VariableCreator_GameObject : VariableCreator
    {
        public override string Name { get; set; } = "GameObject";

        public override IRefable Create()
        {
            return new RefVar_GameObject() { RefName = "GameObject" };
        }
    }

    [Serializable]
    public class RefVar_GameObject_List : RefVar<List<GameObject>> { }

    public class VariableCreator_GameObject_List : VariableCreator
    {
        public override string Name { get; set; } = "List/GameObject";

        public override IRefable Create()
        {
            return new RefVar_GameObject_List() { RefName = "List<GameObject>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_GameObject_Array : RefVar<GameObject[]> { }

    public class VariableCreator_GameObject_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/GameObject";

        public override IRefable Create()
        {
            return new RefVar_GameObject_Array() { RefName = "Array<GameObject>" };
        }
    }

    [Serializable]
    public class RefVar_Transform : RefVar<Transform> { }

    public class VariableCreator_Transform : VariableCreator
    {
        public override string Name { get; set; } = "Transform";

        public override IRefable Create()
        {
            return new RefVar_Transform() { RefName = "Transform" };
        }
    }

    [Serializable]
    public class RefVar_Transform_List : RefVar<List<Transform>> { }

    public class VariableCreator_Transform_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Transform";

        public override IRefable Create()
        {
            return new RefVar_Transform_List() { RefName = "List<Transform>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Transform_Array : RefVar<Transform[]> { }

    public class VariableCreator_Transform_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Transform";

        public override IRefable Create()
        {
            return new RefVar_Transform_Array() { RefName = "Array<Transform>" };
        }
    }

    [Serializable]
    public class RefVar_ScriptableObject : RefVar<ScriptableObject> { }

    public class VariableCreator_ScriptableObject : VariableCreator
    {
        public override string Name { get; set; } = "ScriptableObject";

        public override IRefable Create()
        {
            return new RefVar_ScriptableObject() { RefName = "ScriptableObject" };
        }
    }

    [Serializable]
    public class RefVar_ScriptableObject_List : RefVar<List<ScriptableObject>> { }

    public class VariableCreator_ScriptableObject_List : VariableCreator
    {
        public override string Name { get; set; } = "List/ScriptableObject";

        public override IRefable Create()
        {
            return new RefVar_ScriptableObject_List() { RefName = "List<ScriptableObject>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_ScriptableObject_Array : RefVar<ScriptableObject[]> { }

    public class VariableCreator_ScriptableObject_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/ScriptableObject";

        public override IRefable Create()
        {
            return new RefVar_ScriptableObject_Array() { RefName = "Array<ScriptableObject>" };
        }
    }

    [Serializable]
    public class RefVar_Trigger : RefVar<Trigger> { }

    public class VariableCreator_Trigger : VariableCreator
    {
        public override string Name { get; set; } = "Trigger";

        public override IRefable Create()
        {
            return new RefVar_Trigger() { RefName = "Trigger" };
        }
    }

    [Serializable]
    public class RefVar_Trigger_List : RefVar<List<Trigger>> { }

    public class VariableCreator_Trigger_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Trigger";

        public override IRefable Create()
        {
            return new RefVar_Trigger_List() { RefName = "List<Trigger>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Trigger_Array : RefVar<Trigger[]> { }

    public class VariableCreator_Trigger_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Trigger";

        public override IRefable Create()
        {
            return new RefVar_Trigger_Array() { RefName = "Array<Trigger>" };
        }
    }

    [Serializable]
    public class RefVar_Color : RefVar<Color> { }

    public class VariableCreator_Color : VariableCreator
    {
        public override string Name { get; set; } = "Color";

        public override IRefable Create()
        {
            return new RefVar_Color() { RefName = "Color" };
        }
    }

    [Serializable]
    public class RefVar_Color_List : RefVar<List<Color>> { }

    public class VariableCreator_Color_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Color";

        public override IRefable Create()
        {
            return new RefVar_Color_List() { RefName = "List<Color>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Color_Array : RefVar<Color[]> { }

    public class VariableCreator_Color_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Color";

        public override IRefable Create()
        {
            return new RefVar_Color_Array() { RefName = "Array<Color>" };
        }
    }

    [Serializable]
    public class RefVar_Gradient : RefVar<Gradient> { }

    public class VariableCreator_Gradient : VariableCreator
    {
        public override string Name { get; set; } = "Gradient";

        public override IRefable Create()
        {
            return new RefVar_Gradient() { RefName = "Gradient" };
        }
    }

    [Serializable]
    public class RefVar_Gradient_List : RefVar<List<Gradient>> { }

    public class VariableCreator_Gradient_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Gradient";

        public override IRefable Create()
        {
            return new RefVar_Gradient_List() { RefName = "List<Gradient>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Gradient_Array : RefVar<Gradient[]> { }

    public class VariableCreator_Gradient_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Gradient";

        public override IRefable Create()
        {
            return new RefVar_Gradient_Array() { RefName = "Array<Gradient>" };
        }
    }

    [Serializable]
    public class RefVar_Texture2D : RefVar<Texture2D> { }

    public class VariableCreator_Texture2D : VariableCreator
    {
        public override string Name { get; set; } = "Texture2D";

        public override IRefable Create()
        {
            return new RefVar_Texture2D() { RefName = "Texture2D" };
        }
    }

    [Serializable]
    public class RefVar_Texture2D_List : RefVar<List<Texture2D>> { }

    public class VariableCreator_Texture2D_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Texture2D";

        public override IRefable Create()
        {
            return new RefVar_Texture2D_List() { RefName = "List<Texture2D>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Texture2D_Array : RefVar<Texture2D[]> { }

    public class VariableCreator_Texture2D_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Texture2D";

        public override IRefable Create()
        {
            return new RefVar_Texture2D_Array() { RefName = "Array<Texture2D>" };
        }
    }

    [Serializable]
    public class RefVar_RenderTexture : RefVar<RenderTexture> { }

    public class VariableCreator_RenderTexture : VariableCreator
    {
        public override string Name { get; set; } = "RenderTexture";

        public override IRefable Create()
        {
            return new RefVar_RenderTexture() { RefName = "RenderTexture" };
        }
    }

    [Serializable]
    public class RefVar_RenderTexture_List : RefVar<List<RenderTexture>> { }

    public class VariableCreator_RenderTexture_List : VariableCreator
    {
        public override string Name { get; set; } = "List/RenderTexture";

        public override IRefable Create()
        {
            return new RefVar_RenderTexture_List() { RefName = "List<RenderTexture>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_RenderTexture_Array : RefVar<RenderTexture[]> { }

    public class VariableCreator_RenderTexture_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/RenderTexture";

        public override IRefable Create()
        {
            return new RefVar_RenderTexture_Array() { RefName = "Array<RenderTexture>" };
        }
    }

    [Serializable]
    public class RefVar_AnimationCurve : RefVar<AnimationCurve> { }

    public class VariableCreator_AnimationCurve : VariableCreator
    {
        public override string Name { get; set; } = "AnimationCurve";

        public override IRefable Create()
        {
            return new RefVar_AnimationCurve() { RefName = "AnimationCurve" };
        }
    }

    [Serializable]
    public class RefVar_AnimationCurve_List : RefVar<List<AnimationCurve>> { }

    public class VariableCreator_AnimationCurve_List : VariableCreator
    {
        public override string Name { get; set; } = "List/AnimationCurve";

        public override IRefable Create()
        {
            return new RefVar_AnimationCurve_List() { RefName = "List<AnimationCurve>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_AnimationCurve_Array : RefVar<AnimationCurve[]> { }

    public class VariableCreator_AnimationCurve_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/AnimationCurve";

        public override IRefable Create()
        {
            return new RefVar_AnimationCurve_Array() { RefName = "Array<AnimationCurve>" };
        }
    }

    [Serializable]
    public class RefVar_Mesh : RefVar<Mesh> { }

    public class VariableCreator_Mesh : VariableCreator
    {
        public override string Name { get; set; } = "Mesh";

        public override IRefable Create()
        {
            return new RefVar_Mesh() { RefName = "Mesh" };
        }
    }

    [Serializable]
    public class RefVar_Mesh_List : RefVar<List<Mesh>> { }

    public class VariableCreator_Mesh_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Mesh";

        public override IRefable Create()
        {
            return new RefVar_Mesh_List() { RefName = "List<Mesh>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Mesh_Array : RefVar<Mesh[]> { }

    public class VariableCreator_Mesh_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Mesh";

        public override IRefable Create()
        {
            return new RefVar_Mesh_Array() { RefName = "Array<Mesh>" };
        }
    }

    [Serializable]
    public class RefVar_SkinnedMeshRenderer : RefVar<SkinnedMeshRenderer> { }

    public class VariableCreator_SkinnedMeshRenderer : VariableCreator
    {
        public override string Name { get; set; } = "SkinnedMeshRenderer";

        public override IRefable Create()
        {
            return new RefVar_SkinnedMeshRenderer() { RefName = "SkinnedMeshRenderer" };
        }
    }

    [Serializable]
    public class RefVar_SkinnedMeshRenderer_List : RefVar<List<SkinnedMeshRenderer>> { }

    public class VariableCreator_SkinnedMeshRenderer_List : VariableCreator
    {
        public override string Name { get; set; } = "List/SkinnedMeshRenderer";

        public override IRefable Create()
        {
            return new RefVar_SkinnedMeshRenderer_List() { RefName = "List<SkinnedMeshRenderer>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_SkinnedMeshRenderer_Array : RefVar<SkinnedMeshRenderer[]> { }

    public class VariableCreator_SkinnedMeshRenderer_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/SkinnedMeshRenderer";

        public override IRefable Create()
        {
            return new RefVar_SkinnedMeshRenderer_Array() { RefName = "Array<SkinnedMeshRenderer>" };
        }
    }

    [Serializable]
    public class RefVar_Material : RefVar<Material> { }

    public class VariableCreator_Material : VariableCreator
    {
        public override string Name { get; set; } = "Material";

        public override IRefable Create()
        {
            return new RefVar_Material() { RefName = "Material" };
        }
    }

    [Serializable]
    public class RefVar_Material_List : RefVar<List<Material>> { }

    public class VariableCreator_Material_List : VariableCreator
    {
        public override string Name { get; set; } = "List/Material";

        public override IRefable Create()
        {
            return new RefVar_Material_List() { RefName = "List<Material>", value = new() };
        }
    }

    [Serializable]
    public class RefVar_Material_Array : RefVar<Material[]> { }

    public class VariableCreator_Material_Array : VariableCreator
    {
        public override string Name { get; set; } = "Array/Material";

        public override IRefable Create()
        {
            return new RefVar_Material_Array() { RefName = "Array<Material>" };
        }
    }
}
