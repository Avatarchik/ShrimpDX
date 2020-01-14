// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D10EffectBlendVariable: ID3D10EffectVariable
    {
        static Guid s_uuid = new Guid("1fcd2294-df6d-4eae-86b3-0e9160cfb07b");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int GetBlendState(
            uint Index,
            out ID3D10BlendState ppBlendState
        ){
            var fp = GetFunctionPointer(25);
            if(m_GetBlendStateFunc==null) m_GetBlendStateFunc = (GetBlendStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBlendStateFunc));
            ppBlendState = new ID3D10BlendState();
            return m_GetBlendStateFunc(m_ptr, Index, out ppBlendState.PtrForNew);
        }
        delegate int GetBlendStateFunc(IntPtr self, uint Index, out IntPtr ppBlendState);
        GetBlendStateFunc m_GetBlendStateFunc;

        public virtual int GetBackingStore(
            uint Index,
            out D3D10_BLEND_DESC pBlendDesc
        ){
            var fp = GetFunctionPointer(26);
            if(m_GetBackingStoreFunc==null) m_GetBackingStoreFunc = (GetBackingStoreFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBackingStoreFunc));
            
            return m_GetBackingStoreFunc(m_ptr, Index, out pBlendDesc);
        }
        delegate int GetBackingStoreFunc(IntPtr self, uint Index, out D3D10_BLEND_DESC pBlendDesc);
        GetBackingStoreFunc m_GetBackingStoreFunc;

    }
}
