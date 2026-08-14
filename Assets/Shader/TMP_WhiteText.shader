Shader "TextMeshPro/WhiteTextSimple"
{
	Properties
	{
		_MainTex ("Font Atlas", 2D) = "white" {}
		_FaceColor ("Face Color", Color) = (1,1,1,1)
		_Color ("Color", Color) = (1,1,1,1)
		_Cutoff ("Cutoff", Range(0, 1)) = 0.5
		_Softness ("Softness", Range(0.001, 0.25)) = 0.04
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
			"Queue" = "Transparent"
			"RenderType" = "Transparent"
			"IgnoreProjector" = "True"
		}
		Cull Off
		Lighting Off
		ZWrite Off
		ZTest LEqual
		Blend SrcAlpha OneMinusSrcAlpha
		ColorMask [_ColorMask]

		Stencil
		{
			Ref [_Stencil]
			Comp [_StencilComp]
			Pass [_StencilOp]
			ReadMask [_StencilReadMask]
			WriteMask [_StencilWriteMask]
		}

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
				fixed4 color : COLOR;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				float2 uv : TEXCOORD0;
				fixed4 color : COLOR;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			fixed4 _FaceColor;
			fixed4 _Color;
			float _Cutoff;
			float _Softness;

			v2f vert(appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				o.color = v.color;
				return o;
			}

			fixed4 frag(v2f i) : SV_Target
			{
				fixed4 sample = tex2D(_MainTex, i.uv);
				float sdf = max(max(sample.r, sample.g), max(sample.b, sample.a));
				float alpha = smoothstep(_Cutoff - _Softness, _Cutoff + _Softness, sdf);
				return fixed4(1, 1, 1, alpha);
			}
			ENDCG
		}
	}
}
