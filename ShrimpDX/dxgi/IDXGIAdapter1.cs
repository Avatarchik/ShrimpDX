// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGIAdapter1: IDXGIAdapter
    {
        static Guid s_uuid = new Guid("29038f61-3839-4626-91fd-086879011a05");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int GetDesc1(
            out DXGI_ADAPTER_DESC1 pDesc
        ){
            var fp = GetFunctionPointer(10);
            if(m_GetDesc1Func==null) m_GetDesc1Func = (GetDesc1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesc1Func));
            
            return m_GetDesc1Func(m_ptr, out pDesc);
        }
        delegate int GetDesc1Func(IntPtr self, out DXGI_ADAPTER_DESC1 pDesc);
        GetDesc1Func m_GetDesc1Func;

    }
}
