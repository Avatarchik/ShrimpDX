// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D11ShaderResourceView: ID3D11View
    {
        static Guid s_uuid = new Guid("b0e06fe0-8192-4e1a-b1ca-36d7414710b2");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual void GetDesc(
            out D3D11_SHADER_RESOURCE_VIEW_DESC pDesc
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            m_GetDescFunc(m_ptr, out pDesc);
        }
        delegate void GetDescFunc(IntPtr self, out D3D11_SHADER_RESOURCE_VIEW_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
