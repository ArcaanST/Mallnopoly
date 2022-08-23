Shader "Toon Shader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Brightness("Brightness", Range(0,1)) = 0.3
        _Strength("Strength", Range(0,1)) = 0.5
        _Color("Color", COLOR) = (1,1,1,1)
        _Detail("Detail", Range(0,1)) = 0.3
    }

    SubShader
    {
        Tags {"Render type" = "Opaque"}
        LOD 100
        Pass
        {
            CGPROGRAM
            #pragma vertex vertexMain
            #pragma fragment fragmentMain

            #include "UnityCG.cginc"
        
            struct appdata
            {
                float4 pos : POSITION; 
                float3 normal : NORMAL;
                float2 uv : TEXCOORD0;
            };

            struct v2f //vertex to fragment
            {
                float4 pos : SV_POSITION; 
                float2 uv : TEXCOORD0;
                half3 WorldNormal : NORMAL;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float _Brightness;
            float _Strength;
            float4 _Color;
            float _Detail;

            float Toon(float3 normal, float3 lightDir)
            {
                float NorDotL = max(0.0,dot(normalize(normal), normalize(lightDir)));

                return floor(NorDotL/_Detail);
            }

            v2f vertexMain(appdata inputFromApp)
            {
                v2f output;
                output.pos = UnityObjectToClipPos(inputFromApp.pos);
                output.uv = TRANSFORM_TEX(inputFromApp.uv, _MainTex);
                output.WorldNormal = UnityObjectToWorldNormal(inputFromApp.normal);
                return output;
            }

            fixed4 fragmentMain(v2f i): SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv);
                col *= Toon(i.WorldNormal, _WorldSpaceLightPos0.xyz) * _Strength * _Color + _Brightness;
                return col;
            }
            ENDCG
        }
    }
}