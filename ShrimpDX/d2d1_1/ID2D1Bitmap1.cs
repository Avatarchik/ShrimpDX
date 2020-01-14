// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1Bitmap1: ID2D1Bitmap
    {
        static Guid s_uuid = new Guid("a898a84c-3873-4588-b08b-ebbf978df041");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual void GetColorContext(
            out ID2D1ColorContext colorContext
        ){
            var fp = GetFunctionPointer(11);
            if(m_GetColorContextFunc==null) m_GetColorContextFunc = (GetColorContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorContextFunc));
            colorContext = new ID2D1ColorContext();
            m_GetColorContextFunc(m_ptr, out colorContext.PtrForNew);
        }
        delegate void GetColorContextFunc(IntPtr self, out IntPtr colorContext);
        GetColorContextFunc m_GetColorContextFunc;

        public virtual D2D1_BITMAP_OPTIONS GetOptions(
        ){
            var fp = GetFunctionPointer(12);
            if(m_GetOptionsFunc==null) m_GetOptionsFunc = (GetOptionsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOptionsFunc));
            
            return m_GetOptionsFunc(m_ptr);
        }
        delegate D2D1_BITMAP_OPTIONS GetOptionsFunc(IntPtr self);
        GetOptionsFunc m_GetOptionsFunc;

        public virtual int GetSurface(
            out IDXGISurface dxgiSurface
        ){
            var fp = GetFunctionPointer(13);
            if(m_GetSurfaceFunc==null) m_GetSurfaceFunc = (GetSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSurfaceFunc));
            dxgiSurface = new IDXGISurface();
            return m_GetSurfaceFunc(m_ptr, out dxgiSurface.PtrForNew);
        }
        delegate int GetSurfaceFunc(IntPtr self, out IntPtr dxgiSurface);
        GetSurfaceFunc m_GetSurfaceFunc;

        public virtual int Map(
            D2D1_MAP_OPTIONS options,
            out D2D1_MAPPED_RECT mappedRect
        ){
            var fp = GetFunctionPointer(14);
            if(m_MapFunc==null) m_MapFunc = (MapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MapFunc));
            
            return m_MapFunc(m_ptr, options, out mappedRect);
        }
        delegate int MapFunc(IntPtr self, D2D1_MAP_OPTIONS options, out D2D1_MAPPED_RECT mappedRect);
        MapFunc m_MapFunc;

        public virtual int Unmap(
        ){
            var fp = GetFunctionPointer(15);
            if(m_UnmapFunc==null) m_UnmapFunc = (UnmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnmapFunc));
            
            return m_UnmapFunc(m_ptr);
        }
        delegate int UnmapFunc(IntPtr self);
        UnmapFunc m_UnmapFunc;

    }
}
