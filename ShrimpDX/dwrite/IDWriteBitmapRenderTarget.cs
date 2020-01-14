// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDWriteBitmapRenderTarget: IUnknown
    {
        static Guid s_uuid = new Guid("5e5a32a3-8dff-4773-9ff6-0696eab77267");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int DrawGlyphRun(
            float baselineOriginX,
            float baselineOriginY,
            DWRITE_MEASURING_MODE measuringMode,
            ref DWRITE_GLYPH_RUN glyphRun,
            IDWriteRenderingParams renderingParams,
            uint textColor,
            out tagRECT blackBoxRect
        ){
            var fp = GetFunctionPointer(3);
            if(m_DrawGlyphRunFunc==null) m_DrawGlyphRunFunc = (DrawGlyphRunFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGlyphRunFunc));
            
            return m_DrawGlyphRunFunc(m_ptr, baselineOriginX, baselineOriginY, measuringMode, ref glyphRun, renderingParams!=null ? renderingParams.Ptr : IntPtr.Zero, textColor, out blackBoxRect);
        }
        delegate int DrawGlyphRunFunc(IntPtr self, float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, ref DWRITE_GLYPH_RUN glyphRun, IntPtr renderingParams, uint textColor, out tagRECT blackBoxRect);
        DrawGlyphRunFunc m_DrawGlyphRunFunc;

        public virtual IntPtr GetMemoryDC(
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetMemoryDCFunc==null) m_GetMemoryDCFunc = (GetMemoryDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMemoryDCFunc));
            
            return m_GetMemoryDCFunc(m_ptr);
        }
        delegate IntPtr GetMemoryDCFunc(IntPtr self);
        GetMemoryDCFunc m_GetMemoryDCFunc;

        public virtual float GetPixelsPerDip(
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetPixelsPerDipFunc==null) m_GetPixelsPerDipFunc = (GetPixelsPerDipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelsPerDipFunc));
            
            return m_GetPixelsPerDipFunc(m_ptr);
        }
        delegate float GetPixelsPerDipFunc(IntPtr self);
        GetPixelsPerDipFunc m_GetPixelsPerDipFunc;

        public virtual int SetPixelsPerDip(
            float pixelsPerDip
        ){
            var fp = GetFunctionPointer(6);
            if(m_SetPixelsPerDipFunc==null) m_SetPixelsPerDipFunc = (SetPixelsPerDipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPixelsPerDipFunc));
            
            return m_SetPixelsPerDipFunc(m_ptr, pixelsPerDip);
        }
        delegate int SetPixelsPerDipFunc(IntPtr self, float pixelsPerDip);
        SetPixelsPerDipFunc m_SetPixelsPerDipFunc;

        public virtual int GetCurrentTransform(
            out DWRITE_MATRIX transform
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetCurrentTransformFunc==null) m_GetCurrentTransformFunc = (GetCurrentTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCurrentTransformFunc));
            
            return m_GetCurrentTransformFunc(m_ptr, out transform);
        }
        delegate int GetCurrentTransformFunc(IntPtr self, out DWRITE_MATRIX transform);
        GetCurrentTransformFunc m_GetCurrentTransformFunc;

        public virtual int SetCurrentTransform(
            ref DWRITE_MATRIX transform
        ){
            var fp = GetFunctionPointer(8);
            if(m_SetCurrentTransformFunc==null) m_SetCurrentTransformFunc = (SetCurrentTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetCurrentTransformFunc));
            
            return m_SetCurrentTransformFunc(m_ptr, ref transform);
        }
        delegate int SetCurrentTransformFunc(IntPtr self, ref DWRITE_MATRIX transform);
        SetCurrentTransformFunc m_SetCurrentTransformFunc;

        public virtual int GetSize(
            out tagSIZE size
        ){
            var fp = GetFunctionPointer(9);
            if(m_GetSizeFunc==null) m_GetSizeFunc = (GetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeFunc));
            
            return m_GetSizeFunc(m_ptr, out size);
        }
        delegate int GetSizeFunc(IntPtr self, out tagSIZE size);
        GetSizeFunc m_GetSizeFunc;

        public virtual int Resize(
            uint width,
            uint height
        ){
            var fp = GetFunctionPointer(10);
            if(m_ResizeFunc==null) m_ResizeFunc = (ResizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeFunc));
            
            return m_ResizeFunc(m_ptr, width, height);
        }
        delegate int ResizeFunc(IntPtr self, uint width, uint height);
        ResizeFunc m_ResizeFunc;

    }
}
