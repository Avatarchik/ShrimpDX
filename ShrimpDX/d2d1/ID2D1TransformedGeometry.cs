// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1TransformedGeometry: ID2D1Geometry
    {
        static Guid s_uuid = new Guid("2cd906bb-12e2-11dc-9fed-001143a055f9");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual void GetSourceGeometry(
            out ID2D1Geometry sourceGeometry
        ){
            var fp = GetFunctionPointer(17);
            if(m_GetSourceGeometryFunc==null) m_GetSourceGeometryFunc = (GetSourceGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSourceGeometryFunc));
            sourceGeometry = new ID2D1Geometry();
            m_GetSourceGeometryFunc(m_ptr, out sourceGeometry.PtrForNew);
        }
        delegate void GetSourceGeometryFunc(IntPtr self, out IntPtr sourceGeometry);
        GetSourceGeometryFunc m_GetSourceGeometryFunc;

        public virtual void GetTransform(
            out System.Numerics.Matrix3x2 transform
        ){
            var fp = GetFunctionPointer(18);
            if(m_GetTransformFunc==null) m_GetTransformFunc = (GetTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTransformFunc));
            
            m_GetTransformFunc(m_ptr, out transform);
        }
        delegate void GetTransformFunc(IntPtr self, out System.Numerics.Matrix3x2 transform);
        GetTransformFunc m_GetTransformFunc;

    }
}
