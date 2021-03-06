// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1Factory1: ID2D1Factory
    {
        static Guid s_uuid = new Guid("bb12d362-daee-4b9a-aa1d-14ba401cfa1f");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int CreateDevice(
            IDXGIDevice dxgiDevice,
            out ID2D1Device d2dDevice
        ){
            var fp = GetFunctionPointer(17);
            if(m_CreateDeviceFunc==null) m_CreateDeviceFunc = (CreateDeviceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDeviceFunc));
            d2dDevice = new ID2D1Device();
            return m_CreateDeviceFunc(m_ptr, dxgiDevice!=null ? dxgiDevice.Ptr : IntPtr.Zero, out d2dDevice.PtrForNew);
        }
        delegate int CreateDeviceFunc(IntPtr self, IntPtr dxgiDevice, out IntPtr d2dDevice);
        CreateDeviceFunc m_CreateDeviceFunc;

        public virtual int CreateStrokeStyle(
            ref D2D1_STROKE_STYLE_PROPERTIES1 strokeStyleProperties,
            ref float dashes,
            uint dashesCount,
            out ID2D1StrokeStyle1 strokeStyle
        ){
            var fp = GetFunctionPointer(18);
            if(m_CreateStrokeStyleFunc==null) m_CreateStrokeStyleFunc = (CreateStrokeStyleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateStrokeStyleFunc));
            strokeStyle = new ID2D1StrokeStyle1();
            return m_CreateStrokeStyleFunc(m_ptr, ref strokeStyleProperties, ref dashes, dashesCount, out strokeStyle.PtrForNew);
        }
        delegate int CreateStrokeStyleFunc(IntPtr self, ref D2D1_STROKE_STYLE_PROPERTIES1 strokeStyleProperties, ref float dashes, uint dashesCount, out IntPtr strokeStyle);
        CreateStrokeStyleFunc m_CreateStrokeStyleFunc;

        public virtual int CreatePathGeometry(
            out ID2D1PathGeometry1 pathGeometry
        ){
            var fp = GetFunctionPointer(19);
            if(m_CreatePathGeometryFunc==null) m_CreatePathGeometryFunc = (CreatePathGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreatePathGeometryFunc));
            pathGeometry = new ID2D1PathGeometry1();
            return m_CreatePathGeometryFunc(m_ptr, out pathGeometry.PtrForNew);
        }
        delegate int CreatePathGeometryFunc(IntPtr self, out IntPtr pathGeometry);
        CreatePathGeometryFunc m_CreatePathGeometryFunc;

        public virtual int CreateDrawingStateBlock(
            ref D2D1_DRAWING_STATE_DESCRIPTION1 drawingStateDescription,
            IDWriteRenderingParams textRenderingParams,
            out ID2D1DrawingStateBlock1 drawingStateBlock
        ){
            var fp = GetFunctionPointer(20);
            if(m_CreateDrawingStateBlockFunc==null) m_CreateDrawingStateBlockFunc = (CreateDrawingStateBlockFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDrawingStateBlockFunc));
            drawingStateBlock = new ID2D1DrawingStateBlock1();
            return m_CreateDrawingStateBlockFunc(m_ptr, ref drawingStateDescription, textRenderingParams!=null ? textRenderingParams.Ptr : IntPtr.Zero, out drawingStateBlock.PtrForNew);
        }
        delegate int CreateDrawingStateBlockFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION1 drawingStateDescription, IntPtr textRenderingParams, out IntPtr drawingStateBlock);
        CreateDrawingStateBlockFunc m_CreateDrawingStateBlockFunc;

        public virtual int CreateGdiMetafile(
            IStream metafileStream,
            out ID2D1GdiMetafile metafile
        ){
            var fp = GetFunctionPointer(21);
            if(m_CreateGdiMetafileFunc==null) m_CreateGdiMetafileFunc = (CreateGdiMetafileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGdiMetafileFunc));
            metafile = new ID2D1GdiMetafile();
            return m_CreateGdiMetafileFunc(m_ptr, metafileStream!=null ? metafileStream.Ptr : IntPtr.Zero, out metafile.PtrForNew);
        }
        delegate int CreateGdiMetafileFunc(IntPtr self, IntPtr metafileStream, out IntPtr metafile);
        CreateGdiMetafileFunc m_CreateGdiMetafileFunc;

        public virtual int RegisterEffectFromStream(
            ref Guid classId,
            IStream propertyXml,
            ref D2D1_PROPERTY_BINDING bindings,
            uint bindingsCount,
            PD2D1_EFFECT_FACTORY effectFactory
        ){
            var fp = GetFunctionPointer(22);
            if(m_RegisterEffectFromStreamFunc==null) m_RegisterEffectFromStreamFunc = (RegisterEffectFromStreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterEffectFromStreamFunc));
            
            return m_RegisterEffectFromStreamFunc(m_ptr, ref classId, propertyXml!=null ? propertyXml.Ptr : IntPtr.Zero, ref bindings, bindingsCount, effectFactory);
        }
        delegate int RegisterEffectFromStreamFunc(IntPtr self, ref Guid classId, IntPtr propertyXml, ref D2D1_PROPERTY_BINDING bindings, uint bindingsCount, PD2D1_EFFECT_FACTORY effectFactory);
        RegisterEffectFromStreamFunc m_RegisterEffectFromStreamFunc;

        public virtual int RegisterEffectFromString(
            ref Guid classId,
            ref ushort propertyXml,
            ref D2D1_PROPERTY_BINDING bindings,
            uint bindingsCount,
            PD2D1_EFFECT_FACTORY effectFactory
        ){
            var fp = GetFunctionPointer(23);
            if(m_RegisterEffectFromStringFunc==null) m_RegisterEffectFromStringFunc = (RegisterEffectFromStringFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterEffectFromStringFunc));
            
            return m_RegisterEffectFromStringFunc(m_ptr, ref classId, ref propertyXml, ref bindings, bindingsCount, effectFactory);
        }
        delegate int RegisterEffectFromStringFunc(IntPtr self, ref Guid classId, ref ushort propertyXml, ref D2D1_PROPERTY_BINDING bindings, uint bindingsCount, PD2D1_EFFECT_FACTORY effectFactory);
        RegisterEffectFromStringFunc m_RegisterEffectFromStringFunc;

        public virtual int UnregisterEffect(
            ref Guid classId
        ){
            var fp = GetFunctionPointer(24);
            if(m_UnregisterEffectFunc==null) m_UnregisterEffectFunc = (UnregisterEffectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnregisterEffectFunc));
            
            return m_UnregisterEffectFunc(m_ptr, ref classId);
        }
        delegate int UnregisterEffectFunc(IntPtr self, ref Guid classId);
        UnregisterEffectFunc m_UnregisterEffectFunc;

        public virtual int GetRegisteredEffects(
            out Guid effects,
            uint effectsCount,
            out uint effectsReturned,
            out uint effectsRegistered
        ){
            var fp = GetFunctionPointer(25);
            if(m_GetRegisteredEffectsFunc==null) m_GetRegisteredEffectsFunc = (GetRegisteredEffectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRegisteredEffectsFunc));
            
            return m_GetRegisteredEffectsFunc(m_ptr, out effects, effectsCount, out effectsReturned, out effectsRegistered);
        }
        delegate int GetRegisteredEffectsFunc(IntPtr self, out Guid effects, uint effectsCount, out uint effectsReturned, out uint effectsRegistered);
        GetRegisteredEffectsFunc m_GetRegisteredEffectsFunc;

        public virtual int GetEffectProperties(
            ref Guid effectId,
            out ID2D1Properties properties
        ){
            var fp = GetFunctionPointer(26);
            if(m_GetEffectPropertiesFunc==null) m_GetEffectPropertiesFunc = (GetEffectPropertiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEffectPropertiesFunc));
            properties = new ID2D1Properties();
            return m_GetEffectPropertiesFunc(m_ptr, ref effectId, out properties.PtrForNew);
        }
        delegate int GetEffectPropertiesFunc(IntPtr self, ref Guid effectId, out IntPtr properties);
        GetEffectPropertiesFunc m_GetEffectPropertiesFunc;

    }
}
