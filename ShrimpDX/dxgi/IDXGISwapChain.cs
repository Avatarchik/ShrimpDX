// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGISwapChain: IDXGIDeviceSubObject
    {
        static Guid s_uuid = new Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int Present(
            uint SyncInterval,
            uint Flags
        ){
            var fp = GetFunctionPointer(8);
            if(m_PresentFunc==null) m_PresentFunc = (PresentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PresentFunc));
            
            return m_PresentFunc(m_ptr, SyncInterval, Flags);
        }
        delegate int PresentFunc(IntPtr self, uint SyncInterval, uint Flags);
        PresentFunc m_PresentFunc;

        public virtual int GetBuffer(
            uint Buffer,
            ref Guid riid,
            out IntPtr ppSurface
        ){
            var fp = GetFunctionPointer(9);
            if(m_GetBufferFunc==null) m_GetBufferFunc = (GetBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferFunc));
            
            return m_GetBufferFunc(m_ptr, Buffer, ref riid, out ppSurface);
        }
        delegate int GetBufferFunc(IntPtr self, uint Buffer, ref Guid riid, out IntPtr ppSurface);
        GetBufferFunc m_GetBufferFunc;

        public virtual int SetFullscreenState(
            int Fullscreen,
            IDXGIOutput pTarget
        ){
            var fp = GetFunctionPointer(10);
            if(m_SetFullscreenStateFunc==null) m_SetFullscreenStateFunc = (SetFullscreenStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFullscreenStateFunc));
            
            return m_SetFullscreenStateFunc(m_ptr, Fullscreen, pTarget!=null ? pTarget.Ptr : IntPtr.Zero);
        }
        delegate int SetFullscreenStateFunc(IntPtr self, int Fullscreen, IntPtr pTarget);
        SetFullscreenStateFunc m_SetFullscreenStateFunc;

        public virtual int GetFullscreenState(
            out int pFullscreen,
            out IDXGIOutput ppTarget
        ){
            var fp = GetFunctionPointer(11);
            if(m_GetFullscreenStateFunc==null) m_GetFullscreenStateFunc = (GetFullscreenStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFullscreenStateFunc));
            ppTarget = new IDXGIOutput();
            return m_GetFullscreenStateFunc(m_ptr, out pFullscreen, out ppTarget.PtrForNew);
        }
        delegate int GetFullscreenStateFunc(IntPtr self, out int pFullscreen, out IntPtr ppTarget);
        GetFullscreenStateFunc m_GetFullscreenStateFunc;

        public virtual int GetDesc(
            out DXGI_SWAP_CHAIN_DESC pDesc
        ){
            var fp = GetFunctionPointer(12);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            return m_GetDescFunc(m_ptr, out pDesc);
        }
        delegate int GetDescFunc(IntPtr self, out DXGI_SWAP_CHAIN_DESC pDesc);
        GetDescFunc m_GetDescFunc;

        public virtual int ResizeBuffers(
            uint BufferCount,
            uint Width,
            uint Height,
            DXGI_FORMAT NewFormat,
            uint SwapChainFlags
        ){
            var fp = GetFunctionPointer(13);
            if(m_ResizeBuffersFunc==null) m_ResizeBuffersFunc = (ResizeBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeBuffersFunc));
            
            return m_ResizeBuffersFunc(m_ptr, BufferCount, Width, Height, NewFormat, SwapChainFlags);
        }
        delegate int ResizeBuffersFunc(IntPtr self, uint BufferCount, uint Width, uint Height, DXGI_FORMAT NewFormat, uint SwapChainFlags);
        ResizeBuffersFunc m_ResizeBuffersFunc;

        public virtual int ResizeTarget(
            ref DXGI_MODE_DESC pNewTargetParameters
        ){
            var fp = GetFunctionPointer(14);
            if(m_ResizeTargetFunc==null) m_ResizeTargetFunc = (ResizeTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeTargetFunc));
            
            return m_ResizeTargetFunc(m_ptr, ref pNewTargetParameters);
        }
        delegate int ResizeTargetFunc(IntPtr self, ref DXGI_MODE_DESC pNewTargetParameters);
        ResizeTargetFunc m_ResizeTargetFunc;

        public virtual int GetContainingOutput(
            out IDXGIOutput ppOutput
        ){
            var fp = GetFunctionPointer(15);
            if(m_GetContainingOutputFunc==null) m_GetContainingOutputFunc = (GetContainingOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContainingOutputFunc));
            ppOutput = new IDXGIOutput();
            return m_GetContainingOutputFunc(m_ptr, out ppOutput.PtrForNew);
        }
        delegate int GetContainingOutputFunc(IntPtr self, out IntPtr ppOutput);
        GetContainingOutputFunc m_GetContainingOutputFunc;

        public virtual int GetFrameStatistics(
            out DXGI_FRAME_STATISTICS pStats
        ){
            var fp = GetFunctionPointer(16);
            if(m_GetFrameStatisticsFunc==null) m_GetFrameStatisticsFunc = (GetFrameStatisticsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameStatisticsFunc));
            
            return m_GetFrameStatisticsFunc(m_ptr, out pStats);
        }
        delegate int GetFrameStatisticsFunc(IntPtr self, out DXGI_FRAME_STATISTICS pStats);
        GetFrameStatisticsFunc m_GetFrameStatisticsFunc;

        public virtual int GetLastPresentCount(
            out uint pLastPresentCount
        ){
            var fp = GetFunctionPointer(17);
            if(m_GetLastPresentCountFunc==null) m_GetLastPresentCountFunc = (GetLastPresentCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLastPresentCountFunc));
            
            return m_GetLastPresentCountFunc(m_ptr, out pLastPresentCount);
        }
        delegate int GetLastPresentCountFunc(IntPtr self, out uint pLastPresentCount);
        GetLastPresentCountFunc m_GetLastPresentCountFunc;

    }
}
