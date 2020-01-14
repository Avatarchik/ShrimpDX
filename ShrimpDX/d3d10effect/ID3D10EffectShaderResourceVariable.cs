// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D10EffectShaderResourceVariable: ID3D10EffectVariable
    {
        static Guid s_uuid = new Guid("c0a7157b-d872-4b1d-8073-efc2acd4b1fc");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int SetResource(
            ID3D10ShaderResourceView pResource
        ){
            var fp = GetFunctionPointer(25);
            if(m_SetResourceFunc==null) m_SetResourceFunc = (SetResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetResourceFunc));
            
            return m_SetResourceFunc(m_ptr, pResource!=null ? pResource.Ptr : IntPtr.Zero);
        }
        delegate int SetResourceFunc(IntPtr self, IntPtr pResource);
        SetResourceFunc m_SetResourceFunc;

        public virtual int GetResource(
            out ID3D10ShaderResourceView ppResource
        ){
            var fp = GetFunctionPointer(26);
            if(m_GetResourceFunc==null) m_GetResourceFunc = (GetResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceFunc));
            ppResource = new ID3D10ShaderResourceView();
            return m_GetResourceFunc(m_ptr, out ppResource.PtrForNew);
        }
        delegate int GetResourceFunc(IntPtr self, out IntPtr ppResource);
        GetResourceFunc m_GetResourceFunc;

        public virtual int SetResourceArray(
            out ID3D10ShaderResourceView ppResources,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(27);
            if(m_SetResourceArrayFunc==null) m_SetResourceArrayFunc = (SetResourceArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetResourceArrayFunc));
            ppResources = new ID3D10ShaderResourceView();
            return m_SetResourceArrayFunc(m_ptr, out ppResources.PtrForNew, Offset, Count);
        }
        delegate int SetResourceArrayFunc(IntPtr self, out IntPtr ppResources, uint Offset, uint Count);
        SetResourceArrayFunc m_SetResourceArrayFunc;

        public virtual int GetResourceArray(
            out ID3D10ShaderResourceView ppResources,
            uint Offset,
            uint Count
        ){
            var fp = GetFunctionPointer(28);
            if(m_GetResourceArrayFunc==null) m_GetResourceArrayFunc = (GetResourceArrayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceArrayFunc));
            ppResources = new ID3D10ShaderResourceView();
            return m_GetResourceArrayFunc(m_ptr, out ppResources.PtrForNew, Offset, Count);
        }
        delegate int GetResourceArrayFunc(IntPtr self, out IntPtr ppResources, uint Offset, uint Count);
        GetResourceArrayFunc m_GetResourceArrayFunc;

    }
}
