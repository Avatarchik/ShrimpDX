// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGIObject: IUnknown
    {
        static Guid s_uuid = new Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int SetPrivateData(
            ref Guid Name,
            uint DataSize,
            IntPtr pData
        ){
            var fp = GetFunctionPointer(3);
            if(m_SetPrivateDataFunc==null) m_SetPrivateDataFunc = (SetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataFunc));
            
            return m_SetPrivateDataFunc(m_ptr, ref Name, DataSize, pData);
        }
        delegate int SetPrivateDataFunc(IntPtr self, ref Guid Name, uint DataSize, IntPtr pData);
        SetPrivateDataFunc m_SetPrivateDataFunc;

        public virtual int SetPrivateDataInterface(
            ref Guid Name,
            IUnknown pUnknown
        ){
            var fp = GetFunctionPointer(4);
            if(m_SetPrivateDataInterfaceFunc==null) m_SetPrivateDataInterfaceFunc = (SetPrivateDataInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataInterfaceFunc));
            
            return m_SetPrivateDataInterfaceFunc(m_ptr, ref Name, pUnknown!=null ? pUnknown.Ptr : IntPtr.Zero);
        }
        delegate int SetPrivateDataInterfaceFunc(IntPtr self, ref Guid Name, IntPtr pUnknown);
        SetPrivateDataInterfaceFunc m_SetPrivateDataInterfaceFunc;

        public virtual int GetPrivateData(
            ref Guid Name,
            out uint pDataSize,
            IntPtr pData
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetPrivateDataFunc==null) m_GetPrivateDataFunc = (GetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPrivateDataFunc));
            
            return m_GetPrivateDataFunc(m_ptr, ref Name, out pDataSize, pData);
        }
        delegate int GetPrivateDataFunc(IntPtr self, ref Guid Name, out uint pDataSize, IntPtr pData);
        GetPrivateDataFunc m_GetPrivateDataFunc;

        public virtual int GetParent(
            ref Guid riid,
            out IntPtr ppParent
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetParentFunc==null) m_GetParentFunc = (GetParentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetParentFunc));
            
            return m_GetParentFunc(m_ptr, ref riid, out ppParent);
        }
        delegate int GetParentFunc(IntPtr self, ref Guid riid, out IntPtr ppParent);
        GetParentFunc m_GetParentFunc;

    }
}
