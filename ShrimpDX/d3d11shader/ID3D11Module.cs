// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D11Module: IUnknown
    {
        static Guid s_uuid = new Guid("cac701ee-80fc-4122-8242-10b39c8cec34");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int CreateInstance(
            string pNamespace,
            out ID3D11ModuleInstance ppModuleInstance
        ){
            var fp = GetFunctionPointer(3);
            if(m_CreateInstanceFunc==null) m_CreateInstanceFunc = (CreateInstanceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateInstanceFunc));
            ppModuleInstance = new ID3D11ModuleInstance();
            return m_CreateInstanceFunc(m_ptr, pNamespace, out ppModuleInstance.PtrForNew);
        }
        delegate int CreateInstanceFunc(IntPtr self, string pNamespace, out IntPtr ppModuleInstance);
        CreateInstanceFunc m_CreateInstanceFunc;

    }
}
