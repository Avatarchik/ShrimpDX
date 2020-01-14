// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGISurface1: IDXGISurface
    {
        static Guid s_uuid = new Guid("4ae63092-6327-4c1b-80ae-bfe12ea32b86");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int GetDC(
            int Discard,
            out IntPtr phdc
        ){
            var fp = GetFunctionPointer(11);
            if(m_GetDCFunc==null) m_GetDCFunc = (GetDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDCFunc));
            
            return m_GetDCFunc(m_ptr, Discard, out phdc);
        }
        delegate int GetDCFunc(IntPtr self, int Discard, out IntPtr phdc);
        GetDCFunc m_GetDCFunc;

        public virtual int ReleaseDC(
            out tagRECT pDirtyRect
        ){
            var fp = GetFunctionPointer(12);
            if(m_ReleaseDCFunc==null) m_ReleaseDCFunc = (ReleaseDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseDCFunc));
            
            return m_ReleaseDCFunc(m_ptr, out pDirtyRect);
        }
        delegate int ReleaseDCFunc(IntPtr self, out tagRECT pDirtyRect);
        ReleaseDCFunc m_ReleaseDCFunc;

    }
}
