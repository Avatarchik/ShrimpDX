// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDWritePixelSnapping: IUnknown
    {
        static Guid s_uuid = new Guid("eaf3a2da-ecf4-4d24-b644-b34f6842024b");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int IsPixelSnappingDisabled(
            IntPtr clientDrawingContext,
            out int isDisabled
        ){
            var fp = GetFunctionPointer(3);
            if(m_IsPixelSnappingDisabledFunc==null) m_IsPixelSnappingDisabledFunc = (IsPixelSnappingDisabledFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsPixelSnappingDisabledFunc));
            
            return m_IsPixelSnappingDisabledFunc(m_ptr, clientDrawingContext, out isDisabled);
        }
        delegate int IsPixelSnappingDisabledFunc(IntPtr self, IntPtr clientDrawingContext, out int isDisabled);
        IsPixelSnappingDisabledFunc m_IsPixelSnappingDisabledFunc;

        public virtual int GetCurrentTransform(
            IntPtr clientDrawingContext,
            out DWRITE_MATRIX transform
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetCurrentTransformFunc==null) m_GetCurrentTransformFunc = (GetCurrentTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCurrentTransformFunc));
            
            return m_GetCurrentTransformFunc(m_ptr, clientDrawingContext, out transform);
        }
        delegate int GetCurrentTransformFunc(IntPtr self, IntPtr clientDrawingContext, out DWRITE_MATRIX transform);
        GetCurrentTransformFunc m_GetCurrentTransformFunc;

        public virtual int GetPixelsPerDip(
            IntPtr clientDrawingContext,
            out float pixelsPerDip
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetPixelsPerDipFunc==null) m_GetPixelsPerDipFunc = (GetPixelsPerDipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelsPerDipFunc));
            
            return m_GetPixelsPerDipFunc(m_ptr, clientDrawingContext, out pixelsPerDip);
        }
        delegate int GetPixelsPerDipFunc(IntPtr self, IntPtr clientDrawingContext, out float pixelsPerDip);
        GetPixelsPerDipFunc m_GetPixelsPerDipFunc;

    }
}
