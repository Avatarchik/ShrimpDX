// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGISwapChain1: IDXGISwapChain
    {
        static Guid s_uuid = new Guid("790a45f7-0d42-4876-983a-0a55cfe6f4aa");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int GetDesc1(
            out DXGI_SWAP_CHAIN_DESC1 pDesc
        ){
            var fp = GetFunctionPointer(18);
            if(m_GetDesc1Func==null) m_GetDesc1Func = (GetDesc1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesc1Func));
            
            return m_GetDesc1Func(m_ptr, out pDesc);
        }
        delegate int GetDesc1Func(IntPtr self, out DXGI_SWAP_CHAIN_DESC1 pDesc);
        GetDesc1Func m_GetDesc1Func;

        public virtual int GetFullscreenDesc(
            out DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc
        ){
            var fp = GetFunctionPointer(19);
            if(m_GetFullscreenDescFunc==null) m_GetFullscreenDescFunc = (GetFullscreenDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFullscreenDescFunc));
            
            return m_GetFullscreenDescFunc(m_ptr, out pDesc);
        }
        delegate int GetFullscreenDescFunc(IntPtr self, out DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc);
        GetFullscreenDescFunc m_GetFullscreenDescFunc;

        public virtual int GetHwnd(
            out IntPtr pHwnd
        ){
            var fp = GetFunctionPointer(20);
            if(m_GetHwndFunc==null) m_GetHwndFunc = (GetHwndFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetHwndFunc));
            
            return m_GetHwndFunc(m_ptr, out pHwnd);
        }
        delegate int GetHwndFunc(IntPtr self, out IntPtr pHwnd);
        GetHwndFunc m_GetHwndFunc;

        public virtual int GetCoreWindow(
            ref Guid refiid,
            out IntPtr ppUnk
        ){
            var fp = GetFunctionPointer(21);
            if(m_GetCoreWindowFunc==null) m_GetCoreWindowFunc = (GetCoreWindowFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCoreWindowFunc));
            
            return m_GetCoreWindowFunc(m_ptr, ref refiid, out ppUnk);
        }
        delegate int GetCoreWindowFunc(IntPtr self, ref Guid refiid, out IntPtr ppUnk);
        GetCoreWindowFunc m_GetCoreWindowFunc;

        public virtual int Present1(
            uint SyncInterval,
            uint PresentFlags,
            ref DXGI_PRESENT_PARAMETERS pPresentParameters
        ){
            var fp = GetFunctionPointer(22);
            if(m_Present1Func==null) m_Present1Func = (Present1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(Present1Func));
            
            return m_Present1Func(m_ptr, SyncInterval, PresentFlags, ref pPresentParameters);
        }
        delegate int Present1Func(IntPtr self, uint SyncInterval, uint PresentFlags, ref DXGI_PRESENT_PARAMETERS pPresentParameters);
        Present1Func m_Present1Func;

        public virtual int IsTemporaryMonoSupported(
        ){
            var fp = GetFunctionPointer(23);
            if(m_IsTemporaryMonoSupportedFunc==null) m_IsTemporaryMonoSupportedFunc = (IsTemporaryMonoSupportedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsTemporaryMonoSupportedFunc));
            
            return m_IsTemporaryMonoSupportedFunc(m_ptr);
        }
        delegate int IsTemporaryMonoSupportedFunc(IntPtr self);
        IsTemporaryMonoSupportedFunc m_IsTemporaryMonoSupportedFunc;

        public virtual int GetRestrictToOutput(
            out IDXGIOutput ppRestrictToOutput
        ){
            var fp = GetFunctionPointer(24);
            if(m_GetRestrictToOutputFunc==null) m_GetRestrictToOutputFunc = (GetRestrictToOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRestrictToOutputFunc));
            ppRestrictToOutput = new IDXGIOutput();
            return m_GetRestrictToOutputFunc(m_ptr, out ppRestrictToOutput.PtrForNew);
        }
        delegate int GetRestrictToOutputFunc(IntPtr self, out IntPtr ppRestrictToOutput);
        GetRestrictToOutputFunc m_GetRestrictToOutputFunc;

        public virtual int SetBackgroundColor(
            ref System.Numerics.Vector4 pColor
        ){
            var fp = GetFunctionPointer(25);
            if(m_SetBackgroundColorFunc==null) m_SetBackgroundColorFunc = (SetBackgroundColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBackgroundColorFunc));
            
            return m_SetBackgroundColorFunc(m_ptr, ref pColor);
        }
        delegate int SetBackgroundColorFunc(IntPtr self, ref System.Numerics.Vector4 pColor);
        SetBackgroundColorFunc m_SetBackgroundColorFunc;

        public virtual int GetBackgroundColor(
            out System.Numerics.Vector4 pColor
        ){
            var fp = GetFunctionPointer(26);
            if(m_GetBackgroundColorFunc==null) m_GetBackgroundColorFunc = (GetBackgroundColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBackgroundColorFunc));
            
            return m_GetBackgroundColorFunc(m_ptr, out pColor);
        }
        delegate int GetBackgroundColorFunc(IntPtr self, out System.Numerics.Vector4 pColor);
        GetBackgroundColorFunc m_GetBackgroundColorFunc;

        public virtual int SetRotation(
            DXGI_MODE_ROTATION Rotation
        ){
            var fp = GetFunctionPointer(27);
            if(m_SetRotationFunc==null) m_SetRotationFunc = (SetRotationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetRotationFunc));
            
            return m_SetRotationFunc(m_ptr, Rotation);
        }
        delegate int SetRotationFunc(IntPtr self, DXGI_MODE_ROTATION Rotation);
        SetRotationFunc m_SetRotationFunc;

        public virtual int GetRotation(
            out DXGI_MODE_ROTATION pRotation
        ){
            var fp = GetFunctionPointer(28);
            if(m_GetRotationFunc==null) m_GetRotationFunc = (GetRotationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRotationFunc));
            
            return m_GetRotationFunc(m_ptr, out pRotation);
        }
        delegate int GetRotationFunc(IntPtr self, out DXGI_MODE_ROTATION pRotation);
        GetRotationFunc m_GetRotationFunc;

    }
}
