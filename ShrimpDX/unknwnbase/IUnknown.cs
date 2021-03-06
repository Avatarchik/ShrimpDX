// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IUnknown: ComPtr
    {
        static Guid s_uuid = new Guid("00000000-0000-0000-c000-000000000046");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int QueryInterface(
            ref Guid riid,
            out IntPtr ppvObject
        ){
            var fp = GetFunctionPointer(0);
            if(m_QueryInterfaceFunc==null) m_QueryInterfaceFunc = (QueryInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryInterfaceFunc));
            
            return m_QueryInterfaceFunc(m_ptr, ref riid, out ppvObject);
        }
        delegate int QueryInterfaceFunc(IntPtr self, ref Guid riid, out IntPtr ppvObject);
        QueryInterfaceFunc m_QueryInterfaceFunc;

        public virtual uint AddRef(
        ){
            var fp = GetFunctionPointer(1);
            if(m_AddRefFunc==null) m_AddRefFunc = (AddRefFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddRefFunc));
            
            return m_AddRefFunc(m_ptr);
        }
        delegate uint AddRefFunc(IntPtr self);
        AddRefFunc m_AddRefFunc;

        public virtual uint Release(
        ){
            var fp = GetFunctionPointer(2);
            if(m_ReleaseFunc==null) m_ReleaseFunc = (ReleaseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseFunc));
            
            return m_ReleaseFunc(m_ptr);
        }
        delegate uint ReleaseFunc(IntPtr self);
        ReleaseFunc m_ReleaseFunc;

    }
}
