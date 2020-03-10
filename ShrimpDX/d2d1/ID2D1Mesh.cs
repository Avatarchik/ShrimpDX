// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1Mesh: ID2D1Resource
    {
        static Guid s_uuid = new Guid("2cd906c2-12e2-11dc-9fed-001143a055f9");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int Open(
            out ID2D1TessellationSink tessellationSink
        ){
            var fp = GetFunctionPointer(4);
            if(m_OpenFunc==null) m_OpenFunc = (OpenFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenFunc));
            tessellationSink = new ID2D1TessellationSink();
            return m_OpenFunc(m_ptr, out tessellationSink.PtrForNew);
        }
        delegate int OpenFunc(IntPtr self, out IntPtr tessellationSink);
        OpenFunc m_OpenFunc;

    }
}