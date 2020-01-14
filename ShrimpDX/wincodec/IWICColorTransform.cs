// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICColorTransform: IWICBitmapSource
    {
        static Guid s_uuid = new Guid("b66f034f-d0e2-40ab-b436-6de39e321a94");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int Initialize(
            IWICBitmapSource pIBitmapSource,
            IWICColorContext pIContextSource,
            IWICColorContext pIContextDest,
            ref Guid pixelFmtDest
        ){
            var fp = GetFunctionPointer(8);
            if(m_InitializeFunc==null) m_InitializeFunc = (InitializeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InitializeFunc));
            
            return m_InitializeFunc(m_ptr, pIBitmapSource!=null ? pIBitmapSource.Ptr : IntPtr.Zero, pIContextSource!=null ? pIContextSource.Ptr : IntPtr.Zero, pIContextDest!=null ? pIContextDest.Ptr : IntPtr.Zero, ref pixelFmtDest);
        }
        delegate int InitializeFunc(IntPtr self, IntPtr pIBitmapSource, IntPtr pIContextSource, IntPtr pIContextDest, ref Guid pixelFmtDest);
        InitializeFunc m_InitializeFunc;

    }
}
