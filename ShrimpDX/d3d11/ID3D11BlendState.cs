// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D11BlendState: ID3D11DeviceChild
    {
        static Guid s_uuid = new Guid("75b68faa-347d-4159-8f45-a0640f01cd9a");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual void GetDesc(
            out D3D11_BLEND_DESC pDesc
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            m_GetDescFunc(m_ptr, out pDesc);
        }
        delegate void GetDescFunc(IntPtr self, out D3D11_BLEND_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
