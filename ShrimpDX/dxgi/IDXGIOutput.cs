// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGIOutput: IDXGIObject
    {
        static Guid s_uuid = new Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetDesc(
            out DXGI_OUTPUT_DESC pDesc
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            return m_GetDescFunc(m_ptr, out pDesc);
        }
        delegate int GetDescFunc(IntPtr self, out DXGI_OUTPUT_DESC pDesc);
        GetDescFunc m_GetDescFunc;

        public virtual int GetDisplayModeList(
            DXGI_FORMAT EnumFormat,
            uint Flags,
            out uint pNumModes,
            out DXGI_MODE_DESC pDesc
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetDisplayModeListFunc==null) m_GetDisplayModeListFunc = (GetDisplayModeListFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDisplayModeListFunc));
            
            return m_GetDisplayModeListFunc(m_ptr, EnumFormat, Flags, out pNumModes, out pDesc);
        }
        delegate int GetDisplayModeListFunc(IntPtr self, DXGI_FORMAT EnumFormat, uint Flags, out uint pNumModes, out DXGI_MODE_DESC pDesc);
        GetDisplayModeListFunc m_GetDisplayModeListFunc;

        public virtual int FindClosestMatchingMode(
            ref DXGI_MODE_DESC pModeToMatch,
            out DXGI_MODE_DESC pClosestMatch,
            IUnknown pConcernedDevice
        ){
            var fp = GetFunctionPointer(9);
            if(m_FindClosestMatchingModeFunc==null) m_FindClosestMatchingModeFunc = (FindClosestMatchingModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindClosestMatchingModeFunc));
            
            return m_FindClosestMatchingModeFunc(m_ptr, ref pModeToMatch, out pClosestMatch, pConcernedDevice!=null ? pConcernedDevice.Ptr : IntPtr.Zero);
        }
        delegate int FindClosestMatchingModeFunc(IntPtr self, ref DXGI_MODE_DESC pModeToMatch, out DXGI_MODE_DESC pClosestMatch, IntPtr pConcernedDevice);
        FindClosestMatchingModeFunc m_FindClosestMatchingModeFunc;

        public virtual int WaitForVBlank(
        ){
            var fp = GetFunctionPointer(10);
            if(m_WaitForVBlankFunc==null) m_WaitForVBlankFunc = (WaitForVBlankFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WaitForVBlankFunc));
            
            return m_WaitForVBlankFunc(m_ptr);
        }
        delegate int WaitForVBlankFunc(IntPtr self);
        WaitForVBlankFunc m_WaitForVBlankFunc;

        public virtual int TakeOwnership(
            IUnknown pDevice,
            int Exclusive
        ){
            var fp = GetFunctionPointer(11);
            if(m_TakeOwnershipFunc==null) m_TakeOwnershipFunc = (TakeOwnershipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(TakeOwnershipFunc));
            
            return m_TakeOwnershipFunc(m_ptr, pDevice!=null ? pDevice.Ptr : IntPtr.Zero, Exclusive);
        }
        delegate int TakeOwnershipFunc(IntPtr self, IntPtr pDevice, int Exclusive);
        TakeOwnershipFunc m_TakeOwnershipFunc;

        public virtual void ReleaseOwnership(
        ){
            var fp = GetFunctionPointer(12);
            if(m_ReleaseOwnershipFunc==null) m_ReleaseOwnershipFunc = (ReleaseOwnershipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseOwnershipFunc));
            
            m_ReleaseOwnershipFunc(m_ptr);
        }
        delegate void ReleaseOwnershipFunc(IntPtr self);
        ReleaseOwnershipFunc m_ReleaseOwnershipFunc;

        public virtual int GetGammaControlCapabilities(
            out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps
        ){
            var fp = GetFunctionPointer(13);
            if(m_GetGammaControlCapabilitiesFunc==null) m_GetGammaControlCapabilitiesFunc = (GetGammaControlCapabilitiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGammaControlCapabilitiesFunc));
            
            return m_GetGammaControlCapabilitiesFunc(m_ptr, out pGammaCaps);
        }
        delegate int GetGammaControlCapabilitiesFunc(IntPtr self, out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);
        GetGammaControlCapabilitiesFunc m_GetGammaControlCapabilitiesFunc;

        public virtual int SetGammaControl(
            ref DXGI_GAMMA_CONTROL pArray
        ){
            var fp = GetFunctionPointer(14);
            if(m_SetGammaControlFunc==null) m_SetGammaControlFunc = (SetGammaControlFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetGammaControlFunc));
            
            return m_SetGammaControlFunc(m_ptr, ref pArray);
        }
        delegate int SetGammaControlFunc(IntPtr self, ref DXGI_GAMMA_CONTROL pArray);
        SetGammaControlFunc m_SetGammaControlFunc;

        public virtual int GetGammaControl(
            out DXGI_GAMMA_CONTROL pArray
        ){
            var fp = GetFunctionPointer(15);
            if(m_GetGammaControlFunc==null) m_GetGammaControlFunc = (GetGammaControlFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGammaControlFunc));
            
            return m_GetGammaControlFunc(m_ptr, out pArray);
        }
        delegate int GetGammaControlFunc(IntPtr self, out DXGI_GAMMA_CONTROL pArray);
        GetGammaControlFunc m_GetGammaControlFunc;

        public virtual int SetDisplaySurface(
            IDXGISurface pScanoutSurface
        ){
            var fp = GetFunctionPointer(16);
            if(m_SetDisplaySurfaceFunc==null) m_SetDisplaySurfaceFunc = (SetDisplaySurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDisplaySurfaceFunc));
            
            return m_SetDisplaySurfaceFunc(m_ptr, pScanoutSurface!=null ? pScanoutSurface.Ptr : IntPtr.Zero);
        }
        delegate int SetDisplaySurfaceFunc(IntPtr self, IntPtr pScanoutSurface);
        SetDisplaySurfaceFunc m_SetDisplaySurfaceFunc;

        public virtual int GetDisplaySurfaceData(
            IDXGISurface pDestination
        ){
            var fp = GetFunctionPointer(17);
            if(m_GetDisplaySurfaceDataFunc==null) m_GetDisplaySurfaceDataFunc = (GetDisplaySurfaceDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDisplaySurfaceDataFunc));
            
            return m_GetDisplaySurfaceDataFunc(m_ptr, pDestination!=null ? pDestination.Ptr : IntPtr.Zero);
        }
        delegate int GetDisplaySurfaceDataFunc(IntPtr self, IntPtr pDestination);
        GetDisplaySurfaceDataFunc m_GetDisplaySurfaceDataFunc;

        public virtual int GetFrameStatistics(
            out DXGI_FRAME_STATISTICS pStats
        ){
            var fp = GetFunctionPointer(18);
            if(m_GetFrameStatisticsFunc==null) m_GetFrameStatisticsFunc = (GetFrameStatisticsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameStatisticsFunc));
            
            return m_GetFrameStatisticsFunc(m_ptr, out pStats);
        }
        delegate int GetFrameStatisticsFunc(IntPtr self, out DXGI_FRAME_STATISTICS pStats);
        GetFrameStatisticsFunc m_GetFrameStatisticsFunc;

    }
}
