// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDWriteFontFileStream: IUnknown
    {
        static Guid s_uuid = new Guid("6d4865fe-0ab8-4d91-8f62-5dd6be34a3e0");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int ReadFileFragment(
            ref IntPtr fragmentStart,
            ulong fileOffset,
            ulong fragmentSize,
            out IntPtr fragmentContext
        ){
            var fp = GetFunctionPointer(3);
            if(m_ReadFileFragmentFunc==null) m_ReadFileFragmentFunc = (ReadFileFragmentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReadFileFragmentFunc));
            
            return m_ReadFileFragmentFunc(m_ptr, ref fragmentStart, fileOffset, fragmentSize, out fragmentContext);
        }
        delegate int ReadFileFragmentFunc(IntPtr self, ref IntPtr fragmentStart, ulong fileOffset, ulong fragmentSize, out IntPtr fragmentContext);
        ReadFileFragmentFunc m_ReadFileFragmentFunc;

        public virtual void ReleaseFileFragment(
            IntPtr fragmentContext
        ){
            var fp = GetFunctionPointer(4);
            if(m_ReleaseFileFragmentFunc==null) m_ReleaseFileFragmentFunc = (ReleaseFileFragmentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseFileFragmentFunc));
            
            m_ReleaseFileFragmentFunc(m_ptr, fragmentContext);
        }
        delegate void ReleaseFileFragmentFunc(IntPtr self, IntPtr fragmentContext);
        ReleaseFileFragmentFunc m_ReleaseFileFragmentFunc;

        public virtual int GetFileSize(
            out ulong fileSize
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetFileSizeFunc==null) m_GetFileSizeFunc = (GetFileSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFileSizeFunc));
            
            return m_GetFileSizeFunc(m_ptr, out fileSize);
        }
        delegate int GetFileSizeFunc(IntPtr self, out ulong fileSize);
        GetFileSizeFunc m_GetFileSizeFunc;

        public virtual int GetLastWriteTime(
            out ulong lastWriteTime
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetLastWriteTimeFunc==null) m_GetLastWriteTimeFunc = (GetLastWriteTimeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLastWriteTimeFunc));
            
            return m_GetLastWriteTimeFunc(m_ptr, out lastWriteTime);
        }
        delegate int GetLastWriteTimeFunc(IntPtr self, out ulong lastWriteTime);
        GetLastWriteTimeFunc m_GetLastWriteTimeFunc;

    }
}
