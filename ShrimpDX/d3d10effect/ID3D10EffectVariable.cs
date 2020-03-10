// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D10EffectVariable: ComPtr
    {
        static Guid s_uuid = new Guid("ae897105-00e6-45bf-bb8e-281dd6db8e1b");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int IsValid(
        ){
            var fp = GetFunctionPointer(0);
            if(m_IsValidFunc==null) m_IsValidFunc = (IsValidFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsValidFunc));
            
            return m_IsValidFunc(m_ptr);
        }
        delegate int IsValidFunc(IntPtr self);
        IsValidFunc m_IsValidFunc;

        public virtual ID3D10EffectType GetComType(
        ){
            var fp = GetFunctionPointer(1);
            if(m_GetTypeFunc==null) m_GetTypeFunc = (GetTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeFunc));
            
            return m_GetTypeFunc(m_ptr);
        }
        delegate ID3D10EffectType GetTypeFunc(IntPtr self);
        GetTypeFunc m_GetTypeFunc;

        public virtual int GetDesc(
            out _D3D10_EFFECT_VARIABLE_DESC pDesc
        ){
            var fp = GetFunctionPointer(2);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            return m_GetDescFunc(m_ptr, out pDesc);
        }
        delegate int GetDescFunc(IntPtr self, out _D3D10_EFFECT_VARIABLE_DESC pDesc);
        GetDescFunc m_GetDescFunc;

        public virtual ID3D10EffectVariable GetAnnotationByIndex(
            uint Index
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetAnnotationByIndexFunc==null) m_GetAnnotationByIndexFunc = (GetAnnotationByIndexFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAnnotationByIndexFunc));
            
            return m_GetAnnotationByIndexFunc(m_ptr, Index);
        }
        delegate ID3D10EffectVariable GetAnnotationByIndexFunc(IntPtr self, uint Index);
        GetAnnotationByIndexFunc m_GetAnnotationByIndexFunc;

        public virtual ID3D10EffectVariable GetAnnotationByName(
            string Name
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetAnnotationByNameFunc==null) m_GetAnnotationByNameFunc = (GetAnnotationByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAnnotationByNameFunc));
            
            return m_GetAnnotationByNameFunc(m_ptr, Name);
        }
        delegate ID3D10EffectVariable GetAnnotationByNameFunc(IntPtr self, string Name);
        GetAnnotationByNameFunc m_GetAnnotationByNameFunc;

        public virtual ID3D10EffectVariable GetMemberByIndex(
            uint Index
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetMemberByIndexFunc==null) m_GetMemberByIndexFunc = (GetMemberByIndexFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMemberByIndexFunc));
            
            return m_GetMemberByIndexFunc(m_ptr, Index);
        }
        delegate ID3D10EffectVariable GetMemberByIndexFunc(IntPtr self, uint Index);
        GetMemberByIndexFunc m_GetMemberByIndexFunc;

        public virtual ID3D10EffectVariable GetMemberByName(
            string Name
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetMemberByNameFunc==null) m_GetMemberByNameFunc = (GetMemberByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMemberByNameFunc));
            
            return m_GetMemberByNameFunc(m_ptr, Name);
        }
        delegate ID3D10EffectVariable GetMemberByNameFunc(IntPtr self, string Name);
        GetMemberByNameFunc m_GetMemberByNameFunc;

        public virtual ID3D10EffectVariable GetMemberBySemantic(
            string Semantic
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetMemberBySemanticFunc==null) m_GetMemberBySemanticFunc = (GetMemberBySemanticFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMemberBySemanticFunc));
            
            return m_GetMemberBySemanticFunc(m_ptr, Semantic);
        }
        delegate ID3D10EffectVariable GetMemberBySemanticFunc(IntPtr self, string Semantic);
        GetMemberBySemanticFunc m_GetMemberBySemanticFunc;

        public virtual ID3D10EffectVariable GetElement(
            uint Index
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetElementFunc==null) m_GetElementFunc = (GetElementFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetElementFunc));
            
            return m_GetElementFunc(m_ptr, Index);
        }
        delegate ID3D10EffectVariable GetElementFunc(IntPtr self, uint Index);
        GetElementFunc m_GetElementFunc;

        public virtual ID3D10EffectConstantBuffer GetParentConstantBuffer(
        ){
            var fp = GetFunctionPointer(9);
            if(m_GetParentConstantBufferFunc==null) m_GetParentConstantBufferFunc = (GetParentConstantBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetParentConstantBufferFunc));
            
            return m_GetParentConstantBufferFunc(m_ptr);
        }
        delegate ID3D10EffectConstantBuffer GetParentConstantBufferFunc(IntPtr self);
        GetParentConstantBufferFunc m_GetParentConstantBufferFunc;

        public virtual ID3D10EffectScalarVariable AsScalar(
        ){
            var fp = GetFunctionPointer(10);
            if(m_AsScalarFunc==null) m_AsScalarFunc = (AsScalarFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsScalarFunc));
            
            return m_AsScalarFunc(m_ptr);
        }
        delegate ID3D10EffectScalarVariable AsScalarFunc(IntPtr self);
        AsScalarFunc m_AsScalarFunc;

        public virtual ID3D10EffectVectorVariable AsVector(
        ){
            var fp = GetFunctionPointer(11);
            if(m_AsVectorFunc==null) m_AsVectorFunc = (AsVectorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsVectorFunc));
            
            return m_AsVectorFunc(m_ptr);
        }
        delegate ID3D10EffectVectorVariable AsVectorFunc(IntPtr self);
        AsVectorFunc m_AsVectorFunc;

        public virtual ID3D10EffectMatrixVariable AsMatrix(
        ){
            var fp = GetFunctionPointer(12);
            if(m_AsMatrixFunc==null) m_AsMatrixFunc = (AsMatrixFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsMatrixFunc));
            
            return m_AsMatrixFunc(m_ptr);
        }
        delegate ID3D10EffectMatrixVariable AsMatrixFunc(IntPtr self);
        AsMatrixFunc m_AsMatrixFunc;

        public virtual ID3D10EffectStringVariable AsString(
        ){
            var fp = GetFunctionPointer(13);
            if(m_AsStringFunc==null) m_AsStringFunc = (AsStringFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsStringFunc));
            
            return m_AsStringFunc(m_ptr);
        }
        delegate ID3D10EffectStringVariable AsStringFunc(IntPtr self);
        AsStringFunc m_AsStringFunc;

        public virtual ID3D10EffectShaderResourceVariable AsShaderResource(
        ){
            var fp = GetFunctionPointer(14);
            if(m_AsShaderResourceFunc==null) m_AsShaderResourceFunc = (AsShaderResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsShaderResourceFunc));
            
            return m_AsShaderResourceFunc(m_ptr);
        }
        delegate ID3D10EffectShaderResourceVariable AsShaderResourceFunc(IntPtr self);
        AsShaderResourceFunc m_AsShaderResourceFunc;

        public virtual ID3D10EffectRenderTargetViewVariable AsRenderTargetView(
        ){
            var fp = GetFunctionPointer(15);
            if(m_AsRenderTargetViewFunc==null) m_AsRenderTargetViewFunc = (AsRenderTargetViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsRenderTargetViewFunc));
            
            return m_AsRenderTargetViewFunc(m_ptr);
        }
        delegate ID3D10EffectRenderTargetViewVariable AsRenderTargetViewFunc(IntPtr self);
        AsRenderTargetViewFunc m_AsRenderTargetViewFunc;

        public virtual ID3D10EffectDepthStencilViewVariable AsDepthStencilView(
        ){
            var fp = GetFunctionPointer(16);
            if(m_AsDepthStencilViewFunc==null) m_AsDepthStencilViewFunc = (AsDepthStencilViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsDepthStencilViewFunc));
            
            return m_AsDepthStencilViewFunc(m_ptr);
        }
        delegate ID3D10EffectDepthStencilViewVariable AsDepthStencilViewFunc(IntPtr self);
        AsDepthStencilViewFunc m_AsDepthStencilViewFunc;

        public virtual ID3D10EffectConstantBuffer AsConstantBuffer(
        ){
            var fp = GetFunctionPointer(17);
            if(m_AsConstantBufferFunc==null) m_AsConstantBufferFunc = (AsConstantBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsConstantBufferFunc));
            
            return m_AsConstantBufferFunc(m_ptr);
        }
        delegate ID3D10EffectConstantBuffer AsConstantBufferFunc(IntPtr self);
        AsConstantBufferFunc m_AsConstantBufferFunc;

        public virtual ID3D10EffectShaderVariable AsShader(
        ){
            var fp = GetFunctionPointer(18);
            if(m_AsShaderFunc==null) m_AsShaderFunc = (AsShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsShaderFunc));
            
            return m_AsShaderFunc(m_ptr);
        }
        delegate ID3D10EffectShaderVariable AsShaderFunc(IntPtr self);
        AsShaderFunc m_AsShaderFunc;

        public virtual ID3D10EffectBlendVariable AsBlend(
        ){
            var fp = GetFunctionPointer(19);
            if(m_AsBlendFunc==null) m_AsBlendFunc = (AsBlendFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsBlendFunc));
            
            return m_AsBlendFunc(m_ptr);
        }
        delegate ID3D10EffectBlendVariable AsBlendFunc(IntPtr self);
        AsBlendFunc m_AsBlendFunc;

        public virtual ID3D10EffectDepthStencilVariable AsDepthStencil(
        ){
            var fp = GetFunctionPointer(20);
            if(m_AsDepthStencilFunc==null) m_AsDepthStencilFunc = (AsDepthStencilFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsDepthStencilFunc));
            
            return m_AsDepthStencilFunc(m_ptr);
        }
        delegate ID3D10EffectDepthStencilVariable AsDepthStencilFunc(IntPtr self);
        AsDepthStencilFunc m_AsDepthStencilFunc;

        public virtual ID3D10EffectRasterizerVariable AsRasterizer(
        ){
            var fp = GetFunctionPointer(21);
            if(m_AsRasterizerFunc==null) m_AsRasterizerFunc = (AsRasterizerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsRasterizerFunc));
            
            return m_AsRasterizerFunc(m_ptr);
        }
        delegate ID3D10EffectRasterizerVariable AsRasterizerFunc(IntPtr self);
        AsRasterizerFunc m_AsRasterizerFunc;

        public virtual ID3D10EffectSamplerVariable AsSampler(
        ){
            var fp = GetFunctionPointer(22);
            if(m_AsSamplerFunc==null) m_AsSamplerFunc = (AsSamplerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsSamplerFunc));
            
            return m_AsSamplerFunc(m_ptr);
        }
        delegate ID3D10EffectSamplerVariable AsSamplerFunc(IntPtr self);
        AsSamplerFunc m_AsSamplerFunc;

        public virtual int SetRawValue(
            IntPtr pData,
            uint Offset,
            uint ByteCount
        ){
            var fp = GetFunctionPointer(23);
            if(m_SetRawValueFunc==null) m_SetRawValueFunc = (SetRawValueFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetRawValueFunc));
            
            return m_SetRawValueFunc(m_ptr, pData, Offset, ByteCount);
        }
        delegate int SetRawValueFunc(IntPtr self, IntPtr pData, uint Offset, uint ByteCount);
        SetRawValueFunc m_SetRawValueFunc;

        public virtual int GetRawValue(
            IntPtr pData,
            uint Offset,
            uint ByteCount
        ){
            var fp = GetFunctionPointer(24);
            if(m_GetRawValueFunc==null) m_GetRawValueFunc = (GetRawValueFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRawValueFunc));
            
            return m_GetRawValueFunc(m_ptr, pData, Offset, ByteCount);
        }
        delegate int GetRawValueFunc(IntPtr self, IntPtr pData, uint Offset, uint ByteCount);
        GetRawValueFunc m_GetRawValueFunc;

    }
}