// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1DCRenderTarget: ID2D1RenderTarget
    {
        static Guid s_uuid = new Guid("1c51bc64-de61-46fd-9899-63a5d8f03950");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int BindDC(
            IntPtr hDC,
            ref tagRECT pSubRect
        ){
            var fp = GetFunctionPointer(57);
            if(m_BindDCFunc==null) m_BindDCFunc = (BindDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindDCFunc));
            
            return m_BindDCFunc(m_ptr, hDC, ref pSubRect);
        }
        delegate int BindDCFunc(IntPtr self, IntPtr hDC, ref tagRECT pSubRect);
        BindDCFunc m_BindDCFunc;

    }
}
