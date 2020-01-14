// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D11ShaderReflectionConstantBuffer: ComPtr
    {
        static Guid s_uuid = new Guid("eb62d63d-93dd-4318-8ae8-c6f83ad371b8");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int GetDesc(
            out _D3D11_SHADER_BUFFER_DESC pDesc
        ){
            var fp = GetFunctionPointer(0);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            return m_GetDescFunc(m_ptr, out pDesc);
        }
        delegate int GetDescFunc(IntPtr self, out _D3D11_SHADER_BUFFER_DESC pDesc);
        GetDescFunc m_GetDescFunc;

        public virtual ID3D11ShaderReflectionVariable GetVariableByIndex(
            uint Index
        ){
            var fp = GetFunctionPointer(1);
            if(m_GetVariableByIndexFunc==null) m_GetVariableByIndexFunc = (GetVariableByIndexFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVariableByIndexFunc));
            
            return m_GetVariableByIndexFunc(m_ptr, Index);
        }
        delegate ID3D11ShaderReflectionVariable GetVariableByIndexFunc(IntPtr self, uint Index);
        GetVariableByIndexFunc m_GetVariableByIndexFunc;

        public virtual ID3D11ShaderReflectionVariable GetVariableByName(
            string Name
        ){
            var fp = GetFunctionPointer(2);
            if(m_GetVariableByNameFunc==null) m_GetVariableByNameFunc = (GetVariableByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVariableByNameFunc));
            
            return m_GetVariableByNameFunc(m_ptr, Name);
        }
        delegate ID3D11ShaderReflectionVariable GetVariableByNameFunc(IntPtr self, string Name);
        GetVariableByNameFunc m_GetVariableByNameFunc;

    }
}
