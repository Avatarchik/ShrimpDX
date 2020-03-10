// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12LifetimeOwner: IUnknown
    {
        static Guid s_uuid = new Guid("e667af9f-cd56-4f46-83ce-032e595d70a8");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual void LifetimeStateUpdated(
            D3D12_LIFETIME_STATE NewState
        ){
            var fp = GetFunctionPointer(3);
            if(m_LifetimeStateUpdatedFunc==null) m_LifetimeStateUpdatedFunc = (LifetimeStateUpdatedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LifetimeStateUpdatedFunc));
            
            m_LifetimeStateUpdatedFunc(m_ptr, NewState);
        }
        delegate void LifetimeStateUpdatedFunc(IntPtr self, D3D12_LIFETIME_STATE NewState);
        LifetimeStateUpdatedFunc m_LifetimeStateUpdatedFunc;

    }
}