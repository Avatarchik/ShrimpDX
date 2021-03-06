// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12DeviceChild: ID3D12Object
    {
        static Guid s_uuid = new Guid("905db94b-a00c-4140-9df5-2b64ca9ea357");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetDevice(
            ref Guid riid,
            out IntPtr ppvDevice
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetDeviceFunc==null) m_GetDeviceFunc = (GetDeviceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDeviceFunc));
            
            return m_GetDeviceFunc(m_ptr, ref riid, out ppvDevice);
        }
        delegate int GetDeviceFunc(IntPtr self, ref Guid riid, out IntPtr ppvDevice);
        GetDeviceFunc m_GetDeviceFunc;

    }
}
