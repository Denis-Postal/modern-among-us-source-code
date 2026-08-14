Shader "TextMeshPro/Main Menu SDF"
{
    Properties
    {
        [PerRendererData] _MainTex ("Font Atlas", 2D) = "white" {}
        _Color ("Tint", Color) = (1,1,1,1)
        _FaceColor ("Face Color", Color) = (1,1,1,1)
        _OutlineColor ("Outline Color", Color) = (0,0,0,1)
        _OutlineWidth ("Outline Width", Range(0,1)) = 0
        _FaceDilate ("Face Dilate", Range(-1,1)) = 0
        _Cutoff ("Glyph Cutoff", Range(0,1)) = 0.5
        _Sharpness ("Glyph Sharpness", Range(0.25,8)) = 3
        _ClipRect ("Clip Rect", Vector) = (-32767,-32767,32767,32767)
        _UseClipRect ("Use Clip Rect", Float) = 0

        [HideInInspector] _RendererColor ("RendererColor", Color) = (1,1,1,1)
        [HideInInspector] _VertexOffsetX ("Vertex OffsetX", Float) = 0
        [HideInInspector] _VertexOffsetY ("Vertex OffsetY", Float) = 0
        [HideInInspector] _ScaleRatioA ("Scale RatioA", Float) = 1
        [HideInInspector] _CullMode ("Cull Mode", Float) = 0

        [HideInInspector] _StencilComp ("Stencil Comparison", Float) = 8
        [HideInInspector] _Stencil ("Stencil ID", Float) = 0
        [HideInInspector] _StencilOp ("Stencil Operation", Float) = 0
        [HideInInspector] _StencilWriteMask ("Stencil Write Mask", Float) = 255
        [HideInInspector] _StencilReadMask ("Stencil Read Mask", Float) = 255
        [HideInInspector] _ColorMask ("Color Mask", Float) = 15
    }

    SubShader
    {
        Tags
        {
            "Queue"="Transparent"
            "IgnoreProjector"="True"
            "RenderType"="Transparent"
        }

        Stencil
        {
            Ref [_Stencil]
            Comp [_StencilComp]
            Pass [_StencilOp]
            ReadMask [_StencilReadMask]
            WriteMask [_StencilWriteMask]
        }

        Cull [_CullMode]
        Lighting Off
        ZWrite Off
        Blend SrcAlpha OneMinusSrcAlpha
        ColorMask [_ColorMask]

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                fixed4 color : COLOR;
                float2 texcoord : TEXCOORD0;
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
                fixed4 color : COLOR;
                float2 texcoord : TEXCOORD0;
                float2 worldPos : TEXCOORD1;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            fixed4 _Color;
            fixed4 _FaceColor;
            fixed4 _OutlineColor;
            fixed4 _RendererColor;
            float _OutlineWidth;
            float _FaceDilate;
            float _Cutoff;
            float _Sharpness;
            float _ScaleRatioA;
            float _VertexOffsetX;
            float _VertexOffsetY;
            float4 _ClipRect;
            float _UseClipRect;

            v2f vert(appdata_t v)
            {
                v2f o;
                v.vertex.x += _VertexOffsetX;
                v.vertex.y += _VertexOffsetY;
                float4 world = mul(unity_ObjectToWorld, v.vertex);
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex);
                o.color = v.color * _Color * _FaceColor * _RendererColor;
                o.worldPos = world.xy;
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                fixed4 tex = tex2D(_MainTex, i.texcoord);
                float sdf = tex.a + (_FaceDilate * 0.1);
                float edge = max(fwidth(sdf) / max(_Sharpness, 0.001), 0.001);
                float face = smoothstep(_Cutoff - edge, _Cutoff + edge, sdf);

                float outlineWidth = max(_OutlineWidth * _ScaleRatioA * 0.5, 0.0);
                float outline = smoothstep(_Cutoff - outlineWidth - edge, _Cutoff - outlineWidth + edge, sdf);

                fixed4 faceColor = i.color;
                fixed4 outlineColor = _OutlineColor;
                outlineColor.a *= i.color.a;

                fixed4 color = (outlineWidth > 0.001) ? lerp(outlineColor, faceColor, face) : faceColor;
                color.a = (outlineWidth > 0.001)
                    ? max(face * faceColor.a, outline * outlineColor.a)
                    : face * faceColor.a;

                if (_UseClipRect > 0.5)
                {
                    float2 insideMin = i.worldPos - _ClipRect.xy;
                    float2 insideMax = _ClipRect.zw - i.worldPos;
                    clip(min(min(insideMin.x, insideMin.y), min(insideMax.x, insideMax.y)));
                }

                return color;
            }
            ENDCG
        }
    }
}
