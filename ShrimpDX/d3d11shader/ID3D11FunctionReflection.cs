// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D11FunctionReflection: ComPtr
    {
        static Guid s_uuid = new Guid("207bcecb-d683-4a06-a8a3-9b149b9f73a4");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetDesc(
            out _D3D11_FUNCTION_DESC pDesc
        ){
            var fp = GetFunctionPointer(0);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            return m_GetDescFunc(m_ptr, out pDesc);
        }
        delegate int GetDescFunc(IntPtr self, out _D3D11_FUNCTION_DESC pDesc);
        GetDescFunc m_GetDescFunc;

        public virtual ID3D11ShaderReflectionConstantBuffer GetConstantBufferByIndex(
            uint BufferIndex
        ){
            var fp = GetFunctionPointer(1);
            if(m_GetConstantBufferByIndexFunc==null) m_GetConstantBufferByIndexFunc = (GetConstantBufferByIndexFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetConstantBufferByIndexFunc));
            
            return m_GetConstantBufferByIndexFunc(m_ptr, BufferIndex);
        }
        delegate ID3D11ShaderReflectionConstantBuffer GetConstantBufferByIndexFunc(IntPtr self, uint BufferIndex);
        GetConstantBufferByIndexFunc m_GetConstantBufferByIndexFunc;

        public virtual ID3D11ShaderReflectionConstantBuffer GetConstantBufferByName(
            string Name
        ){
            var fp = GetFunctionPointer(2);
            if(m_GetConstantBufferByNameFunc==null) m_GetConstantBufferByNameFunc = (GetConstantBufferByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetConstantBufferByNameFunc));
            
            return m_GetConstantBufferByNameFunc(m_ptr, Name);
        }
        delegate ID3D11ShaderReflectionConstantBuffer GetConstantBufferByNameFunc(IntPtr self, string Name);
        GetConstantBufferByNameFunc m_GetConstantBufferByNameFunc;

        public virtual int GetResourceBindingDesc(
            uint ResourceIndex,
            out _D3D11_SHADER_INPUT_BIND_DESC pDesc
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetResourceBindingDescFunc==null) m_GetResourceBindingDescFunc = (GetResourceBindingDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceBindingDescFunc));
            
            return m_GetResourceBindingDescFunc(m_ptr, ResourceIndex, out pDesc);
        }
        delegate int GetResourceBindingDescFunc(IntPtr self, uint ResourceIndex, out _D3D11_SHADER_INPUT_BIND_DESC pDesc);
        GetResourceBindingDescFunc m_GetResourceBindingDescFunc;

        public virtual ID3D11ShaderReflectionVariable GetVariableByName(
            string Name
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetVariableByNameFunc==null) m_GetVariableByNameFunc = (GetVariableByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVariableByNameFunc));
            
            return m_GetVariableByNameFunc(m_ptr, Name);
        }
        delegate ID3D11ShaderReflectionVariable GetVariableByNameFunc(IntPtr self, string Name);
        GetVariableByNameFunc m_GetVariableByNameFunc;

        public virtual int GetResourceBindingDescByName(
            string Name,
            out _D3D11_SHADER_INPUT_BIND_DESC pDesc
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetResourceBindingDescByNameFunc==null) m_GetResourceBindingDescByNameFunc = (GetResourceBindingDescByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceBindingDescByNameFunc));
            
            return m_GetResourceBindingDescByNameFunc(m_ptr, Name, out pDesc);
        }
        delegate int GetResourceBindingDescByNameFunc(IntPtr self, string Name, out _D3D11_SHADER_INPUT_BIND_DESC pDesc);
        GetResourceBindingDescByNameFunc m_GetResourceBindingDescByNameFunc;

        public virtual ID3D11FunctionParameterReflection GetFunctionParameter(
            int ParameterIndex
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetFunctionParameterFunc==null) m_GetFunctionParameterFunc = (GetFunctionParameterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFunctionParameterFunc));
            
            return m_GetFunctionParameterFunc(m_ptr, ParameterIndex);
        }
        delegate ID3D11FunctionParameterReflection GetFunctionParameterFunc(IntPtr self, int ParameterIndex);
        GetFunctionParameterFunc m_GetFunctionParameterFunc;

    }
}