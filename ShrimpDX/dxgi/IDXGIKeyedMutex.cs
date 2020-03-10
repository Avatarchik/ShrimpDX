// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGIKeyedMutex: IDXGIDeviceSubObject
    {
        static Guid s_uuid = new Guid("9d8e1289-d7b3-465f-8126-250e349af85d");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int AcquireSync(
            ulong Key,
            uint dwMilliseconds
        ){
            var fp = GetFunctionPointer(8);
            if(m_AcquireSyncFunc==null) m_AcquireSyncFunc = (AcquireSyncFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AcquireSyncFunc));
            
            return m_AcquireSyncFunc(m_ptr, Key, dwMilliseconds);
        }
        delegate int AcquireSyncFunc(IntPtr self, ulong Key, uint dwMilliseconds);
        AcquireSyncFunc m_AcquireSyncFunc;

        public virtual int ReleaseSync(
            ulong Key
        ){
            var fp = GetFunctionPointer(9);
            if(m_ReleaseSyncFunc==null) m_ReleaseSyncFunc = (ReleaseSyncFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseSyncFunc));
            
            return m_ReleaseSyncFunc(m_ptr, Key);
        }
        delegate int ReleaseSyncFunc(IntPtr self, ulong Key);
        ReleaseSyncFunc m_ReleaseSyncFunc;

    }
}