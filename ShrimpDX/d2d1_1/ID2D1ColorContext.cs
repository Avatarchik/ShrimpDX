// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1ColorContext: ID2D1Resource
    {
        static Guid s_uuid = new Guid("1c4820bb-5771-4518-a581-2fe4dd0ec657");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual D2D1_COLOR_SPACE GetColorSpace(
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetColorSpaceFunc==null) m_GetColorSpaceFunc = (GetColorSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorSpaceFunc));
            
            return m_GetColorSpaceFunc(m_ptr);
        }
        delegate D2D1_COLOR_SPACE GetColorSpaceFunc(IntPtr self);
        GetColorSpaceFunc m_GetColorSpaceFunc;

        public virtual uint GetProfileSize(
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetProfileSizeFunc==null) m_GetProfileSizeFunc = (GetProfileSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetProfileSizeFunc));
            
            return m_GetProfileSizeFunc(m_ptr);
        }
        delegate uint GetProfileSizeFunc(IntPtr self);
        GetProfileSizeFunc m_GetProfileSizeFunc;

        public virtual int GetProfile(
            out byte profile,
            uint profileSize
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetProfileFunc==null) m_GetProfileFunc = (GetProfileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetProfileFunc));
            
            return m_GetProfileFunc(m_ptr, out profile, profileSize);
        }
        delegate int GetProfileFunc(IntPtr self, out byte profile, uint profileSize);
        GetProfileFunc m_GetProfileFunc;

    }
}
