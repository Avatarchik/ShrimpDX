// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGIDevice2: IDXGIDevice1
    {
        static Guid s_uuid = new Guid("05008617-fbfd-4051-a790-144884b4f6a9");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int OfferResources(
            uint NumResources,
            ref IntPtr ppResources,
            _DXGI_OFFER_RESOURCE_PRIORITY Priority
        ){
            var fp = GetFunctionPointer(14);
            if(m_OfferResourcesFunc==null) m_OfferResourcesFunc = (OfferResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OfferResourcesFunc));
            
            return m_OfferResourcesFunc(m_ptr, NumResources, ref ppResources, Priority);
        }
        delegate int OfferResourcesFunc(IntPtr self, uint NumResources, ref IntPtr ppResources, _DXGI_OFFER_RESOURCE_PRIORITY Priority);
        OfferResourcesFunc m_OfferResourcesFunc;

        public virtual int ReclaimResources(
            uint NumResources,
            ref IntPtr ppResources,
            out int pDiscarded
        ){
            var fp = GetFunctionPointer(15);
            if(m_ReclaimResourcesFunc==null) m_ReclaimResourcesFunc = (ReclaimResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReclaimResourcesFunc));
            
            return m_ReclaimResourcesFunc(m_ptr, NumResources, ref ppResources, out pDiscarded);
        }
        delegate int ReclaimResourcesFunc(IntPtr self, uint NumResources, ref IntPtr ppResources, out int pDiscarded);
        ReclaimResourcesFunc m_ReclaimResourcesFunc;

        public virtual int EnqueueSetEvent(
            IntPtr hEvent
        ){
            var fp = GetFunctionPointer(16);
            if(m_EnqueueSetEventFunc==null) m_EnqueueSetEventFunc = (EnqueueSetEventFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnqueueSetEventFunc));
            
            return m_EnqueueSetEventFunc(m_ptr, hEvent);
        }
        delegate int EnqueueSetEventFunc(IntPtr self, IntPtr hEvent);
        EnqueueSetEventFunc m_EnqueueSetEventFunc;

    }
}
