// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDWriteLocalFontFileLoader: IDWriteFontFileLoader
    {
        static Guid s_uuid = new Guid("b2d9f3ec-c9fe-4a11-a2ec-d86208f7c0a2");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int GetFilePathLengthFromKey(
            IntPtr fontFileReferenceKey,
            uint fontFileReferenceKeySize,
            out uint filePathLength
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetFilePathLengthFromKeyFunc==null) m_GetFilePathLengthFromKeyFunc = (GetFilePathLengthFromKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFilePathLengthFromKeyFunc));
            
            return m_GetFilePathLengthFromKeyFunc(m_ptr, fontFileReferenceKey, fontFileReferenceKeySize, out filePathLength);
        }
        delegate int GetFilePathLengthFromKeyFunc(IntPtr self, IntPtr fontFileReferenceKey, uint fontFileReferenceKeySize, out uint filePathLength);
        GetFilePathLengthFromKeyFunc m_GetFilePathLengthFromKeyFunc;

        public virtual int GetFilePathFromKey(
            IntPtr fontFileReferenceKey,
            uint fontFileReferenceKeySize,
            out ushort filePath,
            uint filePathSize
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetFilePathFromKeyFunc==null) m_GetFilePathFromKeyFunc = (GetFilePathFromKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFilePathFromKeyFunc));
            
            return m_GetFilePathFromKeyFunc(m_ptr, fontFileReferenceKey, fontFileReferenceKeySize, out filePath, filePathSize);
        }
        delegate int GetFilePathFromKeyFunc(IntPtr self, IntPtr fontFileReferenceKey, uint fontFileReferenceKeySize, out ushort filePath, uint filePathSize);
        GetFilePathFromKeyFunc m_GetFilePathFromKeyFunc;

        public virtual int GetLastWriteTimeFromKey(
            IntPtr fontFileReferenceKey,
            uint fontFileReferenceKeySize,
            out _FILETIME lastWriteTime
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetLastWriteTimeFromKeyFunc==null) m_GetLastWriteTimeFromKeyFunc = (GetLastWriteTimeFromKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLastWriteTimeFromKeyFunc));
            
            return m_GetLastWriteTimeFromKeyFunc(m_ptr, fontFileReferenceKey, fontFileReferenceKeySize, out lastWriteTime);
        }
        delegate int GetLastWriteTimeFromKeyFunc(IntPtr self, IntPtr fontFileReferenceKey, uint fontFileReferenceKeySize, out _FILETIME lastWriteTime);
        GetLastWriteTimeFromKeyFunc m_GetLastWriteTimeFromKeyFunc;

    }
}
