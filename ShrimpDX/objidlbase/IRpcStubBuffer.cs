// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IRpcStubBuffer: IUnknown
    {
        static Guid s_uuid = new Guid("d5f56afc-593b-101a-b569-08002b2dbf7a");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int Connect(
            IUnknown pUnkServer
        ){
            var fp = GetFunctionPointer(3);
            if(m_ConnectFunc==null) m_ConnectFunc = (ConnectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ConnectFunc));
            
            return m_ConnectFunc(m_ptr, pUnkServer!=null ? pUnkServer.Ptr : IntPtr.Zero);
        }
        delegate int ConnectFunc(IntPtr self, IntPtr pUnkServer);
        ConnectFunc m_ConnectFunc;

        public virtual void Disconnect(
        ){
            var fp = GetFunctionPointer(4);
            if(m_DisconnectFunc==null) m_DisconnectFunc = (DisconnectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DisconnectFunc));
            
            m_DisconnectFunc(m_ptr);
        }
        delegate void DisconnectFunc(IntPtr self);
        DisconnectFunc m_DisconnectFunc;

        public virtual int Invoke(
            out tagRPCOLEMESSAGE _prpcmsg,
            IRpcChannelBuffer _pRpcChannelBuffer
        ){
            var fp = GetFunctionPointer(5);
            if(m_InvokeFunc==null) m_InvokeFunc = (InvokeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InvokeFunc));
            
            return m_InvokeFunc(m_ptr, out _prpcmsg, _pRpcChannelBuffer!=null ? _pRpcChannelBuffer.Ptr : IntPtr.Zero);
        }
        delegate int InvokeFunc(IntPtr self, out tagRPCOLEMESSAGE _prpcmsg, IntPtr _pRpcChannelBuffer);
        InvokeFunc m_InvokeFunc;

        public virtual IRpcStubBuffer IsIIDSupported(
            ref Guid riid
        ){
            var fp = GetFunctionPointer(6);
            if(m_IsIIDSupportedFunc==null) m_IsIIDSupportedFunc = (IsIIDSupportedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsIIDSupportedFunc));
            
            return m_IsIIDSupportedFunc(m_ptr, ref riid);
        }
        delegate IRpcStubBuffer IsIIDSupportedFunc(IntPtr self, ref Guid riid);
        IsIIDSupportedFunc m_IsIIDSupportedFunc;

        public virtual uint CountRefs(
        ){
            var fp = GetFunctionPointer(7);
            if(m_CountRefsFunc==null) m_CountRefsFunc = (CountRefsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CountRefsFunc));
            
            return m_CountRefsFunc(m_ptr);
        }
        delegate uint CountRefsFunc(IntPtr self);
        CountRefsFunc m_CountRefsFunc;

        public virtual int DebugServerQueryInterface(
            out IntPtr ppv
        ){
            var fp = GetFunctionPointer(8);
            if(m_DebugServerQueryInterfaceFunc==null) m_DebugServerQueryInterfaceFunc = (DebugServerQueryInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DebugServerQueryInterfaceFunc));
            
            return m_DebugServerQueryInterfaceFunc(m_ptr, out ppv);
        }
        delegate int DebugServerQueryInterfaceFunc(IntPtr self, out IntPtr ppv);
        DebugServerQueryInterfaceFunc m_DebugServerQueryInterfaceFunc;

        public virtual void DebugServerRelease(
            IntPtr pv
        ){
            var fp = GetFunctionPointer(9);
            if(m_DebugServerReleaseFunc==null) m_DebugServerReleaseFunc = (DebugServerReleaseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DebugServerReleaseFunc));
            
            m_DebugServerReleaseFunc(m_ptr, pv);
        }
        delegate void DebugServerReleaseFunc(IntPtr self, IntPtr pv);
        DebugServerReleaseFunc m_DebugServerReleaseFunc;

    }
}
