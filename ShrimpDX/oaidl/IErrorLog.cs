// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IErrorLog: IUnknown
    {
        static Guid s_uuid = new Guid("3127ca40-446e-11ce-8135-00aa004bb851");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int AddError(
            ref ushort pszPropName,
            out tagEXCEPINFO pExcepInfo
        ){
            var fp = GetFunctionPointer(3);
            if(m_AddErrorFunc==null) m_AddErrorFunc = (AddErrorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddErrorFunc));
            
            return m_AddErrorFunc(m_ptr, ref pszPropName, out pExcepInfo);
        }
        delegate int AddErrorFunc(IntPtr self, ref ushort pszPropName, out tagEXCEPINFO pExcepInfo);
        AddErrorFunc m_AddErrorFunc;

    }
}
