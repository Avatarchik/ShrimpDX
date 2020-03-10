// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D11ModuleInstance: IUnknown
    {
        static Guid s_uuid = new Guid("469e07f7-045a-48d5-aa12-68a478cdf75d");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int BindConstantBuffer(
            uint uSrcSlot,
            uint uDstSlot,
            uint cbDstOffset
        ){
            var fp = GetFunctionPointer(3);
            if(m_BindConstantBufferFunc==null) m_BindConstantBufferFunc = (BindConstantBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindConstantBufferFunc));
            
            return m_BindConstantBufferFunc(m_ptr, uSrcSlot, uDstSlot, cbDstOffset);
        }
        delegate int BindConstantBufferFunc(IntPtr self, uint uSrcSlot, uint uDstSlot, uint cbDstOffset);
        BindConstantBufferFunc m_BindConstantBufferFunc;

        public virtual int BindConstantBufferByName(
            string pName,
            uint uDstSlot,
            uint cbDstOffset
        ){
            var fp = GetFunctionPointer(4);
            if(m_BindConstantBufferByNameFunc==null) m_BindConstantBufferByNameFunc = (BindConstantBufferByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindConstantBufferByNameFunc));
            
            return m_BindConstantBufferByNameFunc(m_ptr, pName, uDstSlot, cbDstOffset);
        }
        delegate int BindConstantBufferByNameFunc(IntPtr self, string pName, uint uDstSlot, uint cbDstOffset);
        BindConstantBufferByNameFunc m_BindConstantBufferByNameFunc;

        public virtual int BindResource(
            uint uSrcSlot,
            uint uDstSlot,
            uint uCount
        ){
            var fp = GetFunctionPointer(5);
            if(m_BindResourceFunc==null) m_BindResourceFunc = (BindResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindResourceFunc));
            
            return m_BindResourceFunc(m_ptr, uSrcSlot, uDstSlot, uCount);
        }
        delegate int BindResourceFunc(IntPtr self, uint uSrcSlot, uint uDstSlot, uint uCount);
        BindResourceFunc m_BindResourceFunc;

        public virtual int BindResourceByName(
            string pName,
            uint uDstSlot,
            uint uCount
        ){
            var fp = GetFunctionPointer(6);
            if(m_BindResourceByNameFunc==null) m_BindResourceByNameFunc = (BindResourceByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindResourceByNameFunc));
            
            return m_BindResourceByNameFunc(m_ptr, pName, uDstSlot, uCount);
        }
        delegate int BindResourceByNameFunc(IntPtr self, string pName, uint uDstSlot, uint uCount);
        BindResourceByNameFunc m_BindResourceByNameFunc;

        public virtual int BindSampler(
            uint uSrcSlot,
            uint uDstSlot,
            uint uCount
        ){
            var fp = GetFunctionPointer(7);
            if(m_BindSamplerFunc==null) m_BindSamplerFunc = (BindSamplerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindSamplerFunc));
            
            return m_BindSamplerFunc(m_ptr, uSrcSlot, uDstSlot, uCount);
        }
        delegate int BindSamplerFunc(IntPtr self, uint uSrcSlot, uint uDstSlot, uint uCount);
        BindSamplerFunc m_BindSamplerFunc;

        public virtual int BindSamplerByName(
            string pName,
            uint uDstSlot,
            uint uCount
        ){
            var fp = GetFunctionPointer(8);
            if(m_BindSamplerByNameFunc==null) m_BindSamplerByNameFunc = (BindSamplerByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindSamplerByNameFunc));
            
            return m_BindSamplerByNameFunc(m_ptr, pName, uDstSlot, uCount);
        }
        delegate int BindSamplerByNameFunc(IntPtr self, string pName, uint uDstSlot, uint uCount);
        BindSamplerByNameFunc m_BindSamplerByNameFunc;

        public virtual int BindUnorderedAccessView(
            uint uSrcSlot,
            uint uDstSlot,
            uint uCount
        ){
            var fp = GetFunctionPointer(9);
            if(m_BindUnorderedAccessViewFunc==null) m_BindUnorderedAccessViewFunc = (BindUnorderedAccessViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindUnorderedAccessViewFunc));
            
            return m_BindUnorderedAccessViewFunc(m_ptr, uSrcSlot, uDstSlot, uCount);
        }
        delegate int BindUnorderedAccessViewFunc(IntPtr self, uint uSrcSlot, uint uDstSlot, uint uCount);
        BindUnorderedAccessViewFunc m_BindUnorderedAccessViewFunc;

        public virtual int BindUnorderedAccessViewByName(
            string pName,
            uint uDstSlot,
            uint uCount
        ){
            var fp = GetFunctionPointer(10);
            if(m_BindUnorderedAccessViewByNameFunc==null) m_BindUnorderedAccessViewByNameFunc = (BindUnorderedAccessViewByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindUnorderedAccessViewByNameFunc));
            
            return m_BindUnorderedAccessViewByNameFunc(m_ptr, pName, uDstSlot, uCount);
        }
        delegate int BindUnorderedAccessViewByNameFunc(IntPtr self, string pName, uint uDstSlot, uint uCount);
        BindUnorderedAccessViewByNameFunc m_BindUnorderedAccessViewByNameFunc;

        public virtual int BindResourceAsUnorderedAccessView(
            uint uSrcSrvSlot,
            uint uDstUavSlot,
            uint uCount
        ){
            var fp = GetFunctionPointer(11);
            if(m_BindResourceAsUnorderedAccessViewFunc==null) m_BindResourceAsUnorderedAccessViewFunc = (BindResourceAsUnorderedAccessViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindResourceAsUnorderedAccessViewFunc));
            
            return m_BindResourceAsUnorderedAccessViewFunc(m_ptr, uSrcSrvSlot, uDstUavSlot, uCount);
        }
        delegate int BindResourceAsUnorderedAccessViewFunc(IntPtr self, uint uSrcSrvSlot, uint uDstUavSlot, uint uCount);
        BindResourceAsUnorderedAccessViewFunc m_BindResourceAsUnorderedAccessViewFunc;

        public virtual int BindResourceAsUnorderedAccessViewByName(
            string pSrvName,
            uint uDstUavSlot,
            uint uCount
        ){
            var fp = GetFunctionPointer(12);
            if(m_BindResourceAsUnorderedAccessViewByNameFunc==null) m_BindResourceAsUnorderedAccessViewByNameFunc = (BindResourceAsUnorderedAccessViewByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BindResourceAsUnorderedAccessViewByNameFunc));
            
            return m_BindResourceAsUnorderedAccessViewByNameFunc(m_ptr, pSrvName, uDstUavSlot, uCount);
        }
        delegate int BindResourceAsUnorderedAccessViewByNameFunc(IntPtr self, string pSrvName, uint uDstUavSlot, uint uCount);
        BindResourceAsUnorderedAccessViewByNameFunc m_BindResourceAsUnorderedAccessViewByNameFunc;

    }
}