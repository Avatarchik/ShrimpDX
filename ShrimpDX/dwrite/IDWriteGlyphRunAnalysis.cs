// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDWriteGlyphRunAnalysis: IUnknown
    {
        static Guid s_uuid = new Guid("7d97dbf7-e085-42d4-81e3-6a883bded118");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int GetAlphaTextureBounds(
            DWRITE_TEXTURE_TYPE textureType,
            out tagRECT textureBounds
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetAlphaTextureBoundsFunc==null) m_GetAlphaTextureBoundsFunc = (GetAlphaTextureBoundsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAlphaTextureBoundsFunc));
            
            return m_GetAlphaTextureBoundsFunc(m_ptr, textureType, out textureBounds);
        }
        delegate int GetAlphaTextureBoundsFunc(IntPtr self, DWRITE_TEXTURE_TYPE textureType, out tagRECT textureBounds);
        GetAlphaTextureBoundsFunc m_GetAlphaTextureBoundsFunc;

        public virtual int CreateAlphaTexture(
            DWRITE_TEXTURE_TYPE textureType,
            ref tagRECT textureBounds,
            out byte alphaValues,
            uint bufferSize
        ){
            var fp = GetFunctionPointer(4);
            if(m_CreateAlphaTextureFunc==null) m_CreateAlphaTextureFunc = (CreateAlphaTextureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateAlphaTextureFunc));
            
            return m_CreateAlphaTextureFunc(m_ptr, textureType, ref textureBounds, out alphaValues, bufferSize);
        }
        delegate int CreateAlphaTextureFunc(IntPtr self, DWRITE_TEXTURE_TYPE textureType, ref tagRECT textureBounds, out byte alphaValues, uint bufferSize);
        CreateAlphaTextureFunc m_CreateAlphaTextureFunc;

        public virtual int GetAlphaBlendParams(
            IDWriteRenderingParams renderingParams,
            out float blendGamma,
            out float blendEnhancedContrast,
            out float blendClearTypeLevel
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetAlphaBlendParamsFunc==null) m_GetAlphaBlendParamsFunc = (GetAlphaBlendParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAlphaBlendParamsFunc));
            
            return m_GetAlphaBlendParamsFunc(m_ptr, renderingParams!=null ? renderingParams.Ptr : IntPtr.Zero, out blendGamma, out blendEnhancedContrast, out blendClearTypeLevel);
        }
        delegate int GetAlphaBlendParamsFunc(IntPtr self, IntPtr renderingParams, out float blendGamma, out float blendEnhancedContrast, out float blendClearTypeLevel);
        GetAlphaBlendParamsFunc m_GetAlphaBlendParamsFunc;

    }
}
