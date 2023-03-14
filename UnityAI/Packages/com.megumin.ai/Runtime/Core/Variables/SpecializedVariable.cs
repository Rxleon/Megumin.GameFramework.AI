﻿///********************************************************************************************************************************
///本页代码由代码生成器生成，请勿手动修改。The code on this page is generated by the code generator, do not manually modify.
///生成器类型：$(CodeGenericType)
///配置源文件：$(CodeGenericSourceFilePath)
///********************************************************************************************************************************

using System;
using System.Collections.Generic;
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

    public class RefVariable_bool : RefVariable<bool> { }

    public class VariableCreator_bool : VariableCreator
    {
        public override string Name { get; set; } = "bool";

        public override IRefable Create()
        {
            return new RefVariable_bool() { RefName = "Bool" };
        }
    }

    public class RefVariable_int : RefVariable<int> { }

    public class VariableCreator_int : VariableCreator
    {
        public override string Name { get; set; } = "int";

        public override IRefable Create()
        {
            return new RefVariable_int() { RefName = "Int" };
        }
    }

    public class RefVariable_long : RefVariable<long> { }

    public class VariableCreator_long : VariableCreator
    {
        public override string Name { get; set; } = "long";

        public override IRefable Create()
        {
            return new RefVariable_long() { RefName = "Long" };
        }
    }

    public class RefVariable_string : RefVariable<string> { }

    public class VariableCreator_string : VariableCreator
    {
        public override string Name { get; set; } = "string";

        public override IRefable Create()
        {
            return new RefVariable_string() { RefName = "String" };
        }
    }

    public class RefVariable_float : RefVariable<float> { }

    public class VariableCreator_float : VariableCreator
    {
        public override string Name { get; set; } = "float";

        public override IRefable Create()
        {
            return new RefVariable_float() { RefName = "Float" };
        }
    }

    public class RefVariable_double : RefVariable<double> { }

    public class VariableCreator_double : VariableCreator
    {
        public override string Name { get; set; } = "double";

        public override IRefable Create()
        {
            return new RefVariable_double() { RefName = "Double" };
        }
    }

    public class RefVariable_Vector2 : RefVariable<Vector2> { }

    public class VariableCreator_Vector2 : VariableCreator
    {
        public override string Name { get; set; } = "Vector2";

        public override IRefable Create()
        {
            return new RefVariable_Vector2() { RefName = "Vector2" };
        }
    }

    public class RefVariable_Vector2Int : RefVariable<Vector2Int> { }

    public class VariableCreator_Vector2Int : VariableCreator
    {
        public override string Name { get; set; } = "Vector2Int";

        public override IRefable Create()
        {
            return new RefVariable_Vector2Int() { RefName = "Vector2Int" };
        }
    }

    public class RefVariable_Vector3 : RefVariable<Vector3> { }

    public class VariableCreator_Vector3 : VariableCreator
    {
        public override string Name { get; set; } = "Vector3";

        public override IRefable Create()
        {
            return new RefVariable_Vector3() { RefName = "Vector3" };
        }
    }

    public class RefVariable_Vector3Int : RefVariable<Vector3Int> { }

    public class VariableCreator_Vector3Int : VariableCreator
    {
        public override string Name { get; set; } = "Vector3Int";

        public override IRefable Create()
        {
            return new RefVariable_Vector3Int() { RefName = "Vector3Int" };
        }
    }

    public class RefVariable_Vector4 : RefVariable<Vector4> { }

    public class VariableCreator_Vector4 : VariableCreator
    {
        public override string Name { get; set; } = "Vector4";

        public override IRefable Create()
        {
            return new RefVariable_Vector4() { RefName = "Vector4" };
        }
    }

    public class RefVariable_Rect : RefVariable<Rect> { }

    public class VariableCreator_Rect : VariableCreator
    {
        public override string Name { get; set; } = "Rect";

        public override IRefable Create()
        {
            return new RefVariable_Rect() { RefName = "Rect" };
        }
    }

    public class RefVariable_RectInt : RefVariable<RectInt> { }

    public class VariableCreator_RectInt : VariableCreator
    {
        public override string Name { get; set; } = "RectInt";

        public override IRefable Create()
        {
            return new RefVariable_RectInt() { RefName = "RectInt" };
        }
    }

    public class RefVariable_Bounds : RefVariable<Bounds> { }

    public class VariableCreator_Bounds : VariableCreator
    {
        public override string Name { get; set; } = "Bounds";

        public override IRefable Create()
        {
            return new RefVariable_Bounds() { RefName = "Bounds" };
        }
    }

    public class RefVariable_BoundsInt : RefVariable<BoundsInt> { }

    public class VariableCreator_BoundsInt : VariableCreator
    {
        public override string Name { get; set; } = "BoundsInt";

        public override IRefable Create()
        {
            return new RefVariable_BoundsInt() { RefName = "BoundsInt" };
        }
    }

    public class RefVariable_GameObject : RefVariable<GameObject> { }

    public class VariableCreator_GameObject : VariableCreator
    {
        public override string Name { get; set; } = "GameObject";

        public override IRefable Create()
        {
            return new RefVariable_GameObject() { RefName = "GameObject" };
        }
    }

    public class RefVariable_ScriptableObject : RefVariable<ScriptableObject> { }

    public class VariableCreator_ScriptableObject : VariableCreator
    {
        public override string Name { get; set; } = "ScriptableObject";

        public override IRefable Create()
        {
            return new RefVariable_ScriptableObject() { RefName = "ScriptableObject" };
        }
    }

    public class RefVariable_Trigger : RefVariable<Trigger> { }

    public class VariableCreator_Trigger : VariableCreator
    {
        public override string Name { get; set; } = "Trigger";

        public override IRefable Create()
        {
            return new RefVariable_Trigger() { RefName = "Trigger" };
        }
    }

    public class RefVariable_Color : RefVariable<Color> { }

    public class VariableCreator_Color : VariableCreator
    {
        public override string Name { get; set; } = "Color";

        public override IRefable Create()
        {
            return new RefVariable_Color() { RefName = "Color" };
        }
    }

    public class RefVariable_Gradient : RefVariable<Gradient> { }

    public class VariableCreator_Gradient : VariableCreator
    {
        public override string Name { get; set; } = "Gradient";

        public override IRefable Create()
        {
            return new RefVariable_Gradient() { RefName = "Gradient" };
        }
    }

    public class RefVariable_Texture2D : RefVariable<Texture2D> { }

    public class VariableCreator_Texture2D : VariableCreator
    {
        public override string Name { get; set; } = "Texture2D";

        public override IRefable Create()
        {
            return new RefVariable_Texture2D() { RefName = "Texture2D" };
        }
    }

    public class RefVariable_RenderTexture : RefVariable<RenderTexture> { }

    public class VariableCreator_RenderTexture : VariableCreator
    {
        public override string Name { get; set; } = "RenderTexture";

        public override IRefable Create()
        {
            return new RefVariable_RenderTexture() { RefName = "RenderTexture" };
        }
    }

    public class RefVariable_AnimationCurve : RefVariable<AnimationCurve> { }

    public class VariableCreator_AnimationCurve : VariableCreator
    {
        public override string Name { get; set; } = "AnimationCurve";

        public override IRefable Create()
        {
            return new RefVariable_AnimationCurve() { RefName = "AnimationCurve" };
        }
    }

    public class RefVariable_Mesh : RefVariable<Mesh> { }

    public class VariableCreator_Mesh : VariableCreator
    {
        public override string Name { get; set; } = "Mesh";

        public override IRefable Create()
        {
            return new RefVariable_Mesh() { RefName = "Mesh" };
        }
    }

    public class RefVariable_SkinnedMeshRenderer : RefVariable<SkinnedMeshRenderer> { }

    public class VariableCreator_SkinnedMeshRenderer : VariableCreator
    {
        public override string Name { get; set; } = "SkinnedMeshRenderer";

        public override IRefable Create()
        {
            return new RefVariable_SkinnedMeshRenderer() { RefName = "SkinnedMeshRenderer" };
        }
    }

    public class RefVariable_Material : RefVariable<Material> { }

    public class VariableCreator_Material : VariableCreator
    {
        public override string Name { get; set; } = "Material";

        public override IRefable Create()
        {
            return new RefVariable_Material() { RefName = "Material" };
        }
    }
}
