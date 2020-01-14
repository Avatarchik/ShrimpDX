// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1EllipseGeometry: ID2D1Geometry
    {
        static Guid s_uuid = new Guid("2cd906a4-12e2-11dc-9fed-001143a055f9");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual void GetEllipse(
            out D2D1_ELLIPSE ellipse
        ){
            var fp = GetFunctionPointer(17);
            if(m_GetEllipseFunc==null) m_GetEllipseFunc = (GetEllipseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEllipseFunc));
            
            m_GetEllipseFunc(m_ptr, out ellipse);
        }
        delegate void GetEllipseFunc(IntPtr self, out D2D1_ELLIPSE ellipse);
        GetEllipseFunc m_GetEllipseFunc;

    }
}
