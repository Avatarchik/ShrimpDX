// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1StrokeStyle1: ID2D1StrokeStyle
    {
        static Guid s_uuid = new Guid("10a72a66-e91c-43f4-993f-ddf4b82b0b4a");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformType(
        ){
            var fp = GetFunctionPointer(13);
            if(m_GetStrokeTransformTypeFunc==null) m_GetStrokeTransformTypeFunc = (GetStrokeTransformTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStrokeTransformTypeFunc));
            
            return m_GetStrokeTransformTypeFunc(m_ptr);
        }
        delegate D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformTypeFunc(IntPtr self);
        GetStrokeTransformTypeFunc m_GetStrokeTransformTypeFunc;

    }
}
