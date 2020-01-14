// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D11Counter: ID3D11Asynchronous
    {
        static Guid s_uuid = new Guid("6e8c49fb-a371-4770-b440-29086022b741");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual void GetDesc(
            out D3D11_COUNTER_DESC pDesc
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            m_GetDescFunc(m_ptr, out pDesc);
        }
        delegate void GetDescFunc(IntPtr self, out D3D11_COUNTER_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
