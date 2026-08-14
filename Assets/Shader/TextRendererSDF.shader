Shader "Unlit/TextRendererSDF"
{
	Properties
	{
		_MainTex ("Font Atlas", 2D) = "white" {}
		_Cutoff ("Cutoff", Range(0, 1)) = 0.5
		_Softness ("Softness", Range(0.001, 0.25)) = 0.08
		_Invert ("Invert", Range(0, 1)) = 0
		_OutlineWidth ("Outline Width", Range(0, 0.5)) = 0
		_OutlineColor ("Outline Color", Color) = (0, 0, 0, 1)
		_AlphaScale ("Alpha Scale", Range(1, 3)) = 1.75
		_SolidFill ("Solid Fill", Range(0, 1)) = 1
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
		LOD 100
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
			float4 _MainTex_TexelSize;
			float _Cutoff;
			float _Softness;
			float _Invert;
			float _OutlineWidth;
			float _AlphaScale;
			float _SolidFill;
			fixed4 _OutlineColor;

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
				float rawAlpha = tex2D(_MainTex, i.uv).a;
				if (_SolidFill > 0.5)
				{
					float threshold = max(_Cutoff, 0.78);
					float centerSolid = saturate(rawAlpha * _AlphaScale);
					float faceMask = step(threshold, centerSolid);

					float outlinePixels = _OutlineWidth * 16.0;
					float2 outlineUv = _MainTex_TexelSize.xy * outlinePixels;
					float neighborSolid = centerSolid;
					neighborSolid = max(neighborSolid, saturate(tex2D(_MainTex, i.uv + float2(outlineUv.x, 0)).a * _AlphaScale));
					neighborSolid = max(neighborSolid, saturate(tex2D(_MainTex, i.uv + float2(-outlineUv.x, 0)).a * _AlphaScale));
					neighborSolid = max(neighborSolid, saturate(tex2D(_MainTex, i.uv + float2(0, outlineUv.y)).a * _AlphaScale));
					neighborSolid = max(neighborSolid, saturate(tex2D(_MainTex, i.uv + float2(0, -outlineUv.y)).a * _AlphaScale));
					neighborSolid = max(neighborSolid, saturate(tex2D(_MainTex, i.uv + float2(outlineUv.x, outlineUv.y)).a * _AlphaScale));
					neighborSolid = max(neighborSolid, saturate(tex2D(_MainTex, i.uv + float2(outlineUv.x, -outlineUv.y)).a * _AlphaScale));
					neighborSolid = max(neighborSolid, saturate(tex2D(_MainTex, i.uv + float2(-outlineUv.x, outlineUv.y)).a * _AlphaScale));
					neighborSolid = max(neighborSolid, saturate(tex2D(_MainTex, i.uv + float2(-outlineUv.x, -outlineUv.y)).a * _AlphaScale));

					float outlineMask = step(threshold, neighborSolid);
					float outlineOnly = saturate(outlineMask - faceMask);
					fixed4 solidColor = (i.color * faceMask) + (_OutlineColor * outlineOnly);
					solidColor.a = saturate((i.color.a * faceMask) + (_OutlineColor.a * outlineOnly));
					return solidColor;
				}

				float center = saturate(rawAlpha * _AlphaScale);
				center = lerp(center, 1.0 - center, _Invert);
				float softness = min(max(_Softness, 0.0001), 0.035);
				float faceAlpha = smoothstep(_Cutoff - softness, _Cutoff + softness, center);

				float outlinePixels = _OutlineWidth * 16.0;
				float2 outlineUv = _MainTex_TexelSize.xy * outlinePixels;
				float neighbor = center;
				neighbor = max(neighbor, saturate(tex2D(_MainTex, i.uv + float2(outlineUv.x, 0)).a * _AlphaScale));
				neighbor = max(neighbor, saturate(tex2D(_MainTex, i.uv + float2(-outlineUv.x, 0)).a * _AlphaScale));
				neighbor = max(neighbor, saturate(tex2D(_MainTex, i.uv + float2(0, outlineUv.y)).a * _AlphaScale));
				neighbor = max(neighbor, saturate(tex2D(_MainTex, i.uv + float2(0, -outlineUv.y)).a * _AlphaScale));
				neighbor = max(neighbor, saturate(tex2D(_MainTex, i.uv + float2(outlineUv.x, outlineUv.y)).a * _AlphaScale));
				neighbor = max(neighbor, saturate(tex2D(_MainTex, i.uv + float2(outlineUv.x, -outlineUv.y)).a * _AlphaScale));
				neighbor = max(neighbor, saturate(tex2D(_MainTex, i.uv + float2(-outlineUv.x, outlineUv.y)).a * _AlphaScale));
				neighbor = max(neighbor, saturate(tex2D(_MainTex, i.uv + float2(-outlineUv.x, -outlineUv.y)).a * _AlphaScale));
				neighbor = lerp(neighbor, 1.0 - neighbor, _Invert);
				float outlineAlpha = smoothstep(_Cutoff - softness, _Cutoff + softness, neighbor);
				float outlineOnly = saturate(outlineAlpha - faceAlpha);

				fixed4 color = (i.color * faceAlpha) + (_OutlineColor * outlineOnly);
				color.a = saturate((i.color.a * faceAlpha) + (_OutlineColor.a * outlineOnly));
				return color;
			}
			ENDCG
		}
	}
}
