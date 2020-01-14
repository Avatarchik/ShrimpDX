// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1CommandSink: IUnknown
    {
        static Guid s_uuid = new Guid("54d7898a-a061-40a7-bec7-e465bcba2c4f");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int BeginDraw(
        ){
            var fp = GetFunctionPointer(3);
            if(m_BeginDrawFunc==null) m_BeginDrawFunc = (BeginDrawFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BeginDrawFunc));
            
            return m_BeginDrawFunc(m_ptr);
        }
        delegate int BeginDrawFunc(IntPtr self);
        BeginDrawFunc m_BeginDrawFunc;

        public virtual int EndDraw(
        ){
            var fp = GetFunctionPointer(4);
            if(m_EndDrawFunc==null) m_EndDrawFunc = (EndDrawFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EndDrawFunc));
            
            return m_EndDrawFunc(m_ptr);
        }
        delegate int EndDrawFunc(IntPtr self);
        EndDrawFunc m_EndDrawFunc;

        public virtual int SetAntialiasMode(
            D2D1_ANTIALIAS_MODE antialiasMode
        ){
            var fp = GetFunctionPointer(5);
            if(m_SetAntialiasModeFunc==null) m_SetAntialiasModeFunc = (SetAntialiasModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetAntialiasModeFunc));
            
            return m_SetAntialiasModeFunc(m_ptr, antialiasMode);
        }
        delegate int SetAntialiasModeFunc(IntPtr self, D2D1_ANTIALIAS_MODE antialiasMode);
        SetAntialiasModeFunc m_SetAntialiasModeFunc;

        public virtual int SetTags(
            ulong tag1,
            ulong tag2
        ){
            var fp = GetFunctionPointer(6);
            if(m_SetTagsFunc==null) m_SetTagsFunc = (SetTagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTagsFunc));
            
            return m_SetTagsFunc(m_ptr, tag1, tag2);
        }
        delegate int SetTagsFunc(IntPtr self, ulong tag1, ulong tag2);
        SetTagsFunc m_SetTagsFunc;

        public virtual int SetTextAntialiasMode(
            D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode
        ){
            var fp = GetFunctionPointer(7);
            if(m_SetTextAntialiasModeFunc==null) m_SetTextAntialiasModeFunc = (SetTextAntialiasModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTextAntialiasModeFunc));
            
            return m_SetTextAntialiasModeFunc(m_ptr, textAntialiasMode);
        }
        delegate int SetTextAntialiasModeFunc(IntPtr self, D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);
        SetTextAntialiasModeFunc m_SetTextAntialiasModeFunc;

        public virtual int SetTextRenderingParams(
            IDWriteRenderingParams textRenderingParams
        ){
            var fp = GetFunctionPointer(8);
            if(m_SetTextRenderingParamsFunc==null) m_SetTextRenderingParamsFunc = (SetTextRenderingParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTextRenderingParamsFunc));
            
            return m_SetTextRenderingParamsFunc(m_ptr, textRenderingParams!=null ? textRenderingParams.Ptr : IntPtr.Zero);
        }
        delegate int SetTextRenderingParamsFunc(IntPtr self, IntPtr textRenderingParams);
        SetTextRenderingParamsFunc m_SetTextRenderingParamsFunc;

        public virtual int SetTransform(
            ref System.Numerics.Matrix3x2 transform
        ){
            var fp = GetFunctionPointer(9);
            if(m_SetTransformFunc==null) m_SetTransformFunc = (SetTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTransformFunc));
            
            return m_SetTransformFunc(m_ptr, ref transform);
        }
        delegate int SetTransformFunc(IntPtr self, ref System.Numerics.Matrix3x2 transform);
        SetTransformFunc m_SetTransformFunc;

        public virtual int SetPrimitiveBlend(
            D2D1_PRIMITIVE_BLEND primitiveBlend
        ){
            var fp = GetFunctionPointer(10);
            if(m_SetPrimitiveBlendFunc==null) m_SetPrimitiveBlendFunc = (SetPrimitiveBlendFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrimitiveBlendFunc));
            
            return m_SetPrimitiveBlendFunc(m_ptr, primitiveBlend);
        }
        delegate int SetPrimitiveBlendFunc(IntPtr self, D2D1_PRIMITIVE_BLEND primitiveBlend);
        SetPrimitiveBlendFunc m_SetPrimitiveBlendFunc;

        public virtual int SetUnitMode(
            D2D1_UNIT_MODE unitMode
        ){
            var fp = GetFunctionPointer(11);
            if(m_SetUnitModeFunc==null) m_SetUnitModeFunc = (SetUnitModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetUnitModeFunc));
            
            return m_SetUnitModeFunc(m_ptr, unitMode);
        }
        delegate int SetUnitModeFunc(IntPtr self, D2D1_UNIT_MODE unitMode);
        SetUnitModeFunc m_SetUnitModeFunc;

        public virtual int Clear(
            ref System.Numerics.Vector4 color
        ){
            var fp = GetFunctionPointer(12);
            if(m_ClearFunc==null) m_ClearFunc = (ClearFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearFunc));
            
            return m_ClearFunc(m_ptr, ref color);
        }
        delegate int ClearFunc(IntPtr self, ref System.Numerics.Vector4 color);
        ClearFunc m_ClearFunc;

        public virtual int DrawGlyphRun(
            System.Numerics.Vector2 baselineOrigin,
            ref DWRITE_GLYPH_RUN glyphRun,
            ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription,
            ID2D1Brush foregroundBrush,
            DWRITE_MEASURING_MODE measuringMode
        ){
            var fp = GetFunctionPointer(13);
            if(m_DrawGlyphRunFunc==null) m_DrawGlyphRunFunc = (DrawGlyphRunFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGlyphRunFunc));
            
            return m_DrawGlyphRunFunc(m_ptr, baselineOrigin, ref glyphRun, ref glyphRunDescription, foregroundBrush!=null ? foregroundBrush.Ptr : IntPtr.Zero, measuringMode);
        }
        delegate int DrawGlyphRunFunc(IntPtr self, System.Numerics.Vector2 baselineOrigin, ref DWRITE_GLYPH_RUN glyphRun, ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, IntPtr foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
        DrawGlyphRunFunc m_DrawGlyphRunFunc;

        public virtual int DrawLine(
            System.Numerics.Vector2 point0,
            System.Numerics.Vector2 point1,
            ID2D1Brush brush,
            float strokeWidth,
            ID2D1StrokeStyle strokeStyle
        ){
            var fp = GetFunctionPointer(14);
            if(m_DrawLineFunc==null) m_DrawLineFunc = (DrawLineFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawLineFunc));
            
            return m_DrawLineFunc(m_ptr, point0, point1, brush!=null ? brush.Ptr : IntPtr.Zero, strokeWidth, strokeStyle!=null ? strokeStyle.Ptr : IntPtr.Zero);
        }
        delegate int DrawLineFunc(IntPtr self, System.Numerics.Vector2 point0, System.Numerics.Vector2 point1, IntPtr brush, float strokeWidth, IntPtr strokeStyle);
        DrawLineFunc m_DrawLineFunc;

        public virtual int DrawGeometry(
            ID2D1Geometry geometry,
            ID2D1Brush brush,
            float strokeWidth,
            ID2D1StrokeStyle strokeStyle
        ){
            var fp = GetFunctionPointer(15);
            if(m_DrawGeometryFunc==null) m_DrawGeometryFunc = (DrawGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGeometryFunc));
            
            return m_DrawGeometryFunc(m_ptr, geometry!=null ? geometry.Ptr : IntPtr.Zero, brush!=null ? brush.Ptr : IntPtr.Zero, strokeWidth, strokeStyle!=null ? strokeStyle.Ptr : IntPtr.Zero);
        }
        delegate int DrawGeometryFunc(IntPtr self, IntPtr geometry, IntPtr brush, float strokeWidth, IntPtr strokeStyle);
        DrawGeometryFunc m_DrawGeometryFunc;

        public virtual int DrawRectangle(
            ref System.Numerics.Vector4 rect,
            ID2D1Brush brush,
            float strokeWidth,
            ID2D1StrokeStyle strokeStyle
        ){
            var fp = GetFunctionPointer(16);
            if(m_DrawRectangleFunc==null) m_DrawRectangleFunc = (DrawRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawRectangleFunc));
            
            return m_DrawRectangleFunc(m_ptr, ref rect, brush!=null ? brush.Ptr : IntPtr.Zero, strokeWidth, strokeStyle!=null ? strokeStyle.Ptr : IntPtr.Zero);
        }
        delegate int DrawRectangleFunc(IntPtr self, ref System.Numerics.Vector4 rect, IntPtr brush, float strokeWidth, IntPtr strokeStyle);
        DrawRectangleFunc m_DrawRectangleFunc;

        public virtual int DrawBitmap(
            ID2D1Bitmap bitmap,
            ref System.Numerics.Vector4 destinationRectangle,
            float opacity,
            D2D1_INTERPOLATION_MODE interpolationMode,
            ref System.Numerics.Vector4 sourceRectangle,
            ref D2D_MATRIX_4X4_F perspectiveTransform
        ){
            var fp = GetFunctionPointer(17);
            if(m_DrawBitmapFunc==null) m_DrawBitmapFunc = (DrawBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawBitmapFunc));
            
            return m_DrawBitmapFunc(m_ptr, bitmap!=null ? bitmap.Ptr : IntPtr.Zero, ref destinationRectangle, opacity, interpolationMode, ref sourceRectangle, ref perspectiveTransform);
        }
        delegate int DrawBitmapFunc(IntPtr self, IntPtr bitmap, ref System.Numerics.Vector4 destinationRectangle, float opacity, D2D1_INTERPOLATION_MODE interpolationMode, ref System.Numerics.Vector4 sourceRectangle, ref D2D_MATRIX_4X4_F perspectiveTransform);
        DrawBitmapFunc m_DrawBitmapFunc;

        public virtual int DrawImage(
            ID2D1Image image,
            ref System.Numerics.Vector2 targetOffset,
            ref System.Numerics.Vector4 imageRectangle,
            D2D1_INTERPOLATION_MODE interpolationMode,
            D2D1_COMPOSITE_MODE compositeMode
        ){
            var fp = GetFunctionPointer(18);
            if(m_DrawImageFunc==null) m_DrawImageFunc = (DrawImageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawImageFunc));
            
            return m_DrawImageFunc(m_ptr, image!=null ? image.Ptr : IntPtr.Zero, ref targetOffset, ref imageRectangle, interpolationMode, compositeMode);
        }
        delegate int DrawImageFunc(IntPtr self, IntPtr image, ref System.Numerics.Vector2 targetOffset, ref System.Numerics.Vector4 imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode);
        DrawImageFunc m_DrawImageFunc;

        public virtual int DrawGdiMetafile(
            ID2D1GdiMetafile gdiMetafile,
            ref System.Numerics.Vector2 targetOffset
        ){
            var fp = GetFunctionPointer(19);
            if(m_DrawGdiMetafileFunc==null) m_DrawGdiMetafileFunc = (DrawGdiMetafileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGdiMetafileFunc));
            
            return m_DrawGdiMetafileFunc(m_ptr, gdiMetafile!=null ? gdiMetafile.Ptr : IntPtr.Zero, ref targetOffset);
        }
        delegate int DrawGdiMetafileFunc(IntPtr self, IntPtr gdiMetafile, ref System.Numerics.Vector2 targetOffset);
        DrawGdiMetafileFunc m_DrawGdiMetafileFunc;

        public virtual int FillMesh(
            ID2D1Mesh mesh,
            ID2D1Brush brush
        ){
            var fp = GetFunctionPointer(20);
            if(m_FillMeshFunc==null) m_FillMeshFunc = (FillMeshFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillMeshFunc));
            
            return m_FillMeshFunc(m_ptr, mesh!=null ? mesh.Ptr : IntPtr.Zero, brush!=null ? brush.Ptr : IntPtr.Zero);
        }
        delegate int FillMeshFunc(IntPtr self, IntPtr mesh, IntPtr brush);
        FillMeshFunc m_FillMeshFunc;

        public virtual int FillOpacityMask(
            ID2D1Bitmap opacityMask,
            ID2D1Brush brush,
            ref System.Numerics.Vector4 destinationRectangle,
            ref System.Numerics.Vector4 sourceRectangle
        ){
            var fp = GetFunctionPointer(21);
            if(m_FillOpacityMaskFunc==null) m_FillOpacityMaskFunc = (FillOpacityMaskFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillOpacityMaskFunc));
            
            return m_FillOpacityMaskFunc(m_ptr, opacityMask!=null ? opacityMask.Ptr : IntPtr.Zero, brush!=null ? brush.Ptr : IntPtr.Zero, ref destinationRectangle, ref sourceRectangle);
        }
        delegate int FillOpacityMaskFunc(IntPtr self, IntPtr opacityMask, IntPtr brush, ref System.Numerics.Vector4 destinationRectangle, ref System.Numerics.Vector4 sourceRectangle);
        FillOpacityMaskFunc m_FillOpacityMaskFunc;

        public virtual int FillGeometry(
            ID2D1Geometry geometry,
            ID2D1Brush brush,
            ID2D1Brush opacityBrush
        ){
            var fp = GetFunctionPointer(22);
            if(m_FillGeometryFunc==null) m_FillGeometryFunc = (FillGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillGeometryFunc));
            
            return m_FillGeometryFunc(m_ptr, geometry!=null ? geometry.Ptr : IntPtr.Zero, brush!=null ? brush.Ptr : IntPtr.Zero, opacityBrush!=null ? opacityBrush.Ptr : IntPtr.Zero);
        }
        delegate int FillGeometryFunc(IntPtr self, IntPtr geometry, IntPtr brush, IntPtr opacityBrush);
        FillGeometryFunc m_FillGeometryFunc;

        public virtual int FillRectangle(
            ref System.Numerics.Vector4 rect,
            ID2D1Brush brush
        ){
            var fp = GetFunctionPointer(23);
            if(m_FillRectangleFunc==null) m_FillRectangleFunc = (FillRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FillRectangleFunc));
            
            return m_FillRectangleFunc(m_ptr, ref rect, brush!=null ? brush.Ptr : IntPtr.Zero);
        }
        delegate int FillRectangleFunc(IntPtr self, ref System.Numerics.Vector4 rect, IntPtr brush);
        FillRectangleFunc m_FillRectangleFunc;

        public virtual int PushAxisAlignedClip(
            ref System.Numerics.Vector4 clipRect,
            D2D1_ANTIALIAS_MODE antialiasMode
        ){
            var fp = GetFunctionPointer(24);
            if(m_PushAxisAlignedClipFunc==null) m_PushAxisAlignedClipFunc = (PushAxisAlignedClipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PushAxisAlignedClipFunc));
            
            return m_PushAxisAlignedClipFunc(m_ptr, ref clipRect, antialiasMode);
        }
        delegate int PushAxisAlignedClipFunc(IntPtr self, ref System.Numerics.Vector4 clipRect, D2D1_ANTIALIAS_MODE antialiasMode);
        PushAxisAlignedClipFunc m_PushAxisAlignedClipFunc;

        public virtual int PushLayer(
            ref D2D1_LAYER_PARAMETERS1 layerParameters1,
            ID2D1Layer layer
        ){
            var fp = GetFunctionPointer(25);
            if(m_PushLayerFunc==null) m_PushLayerFunc = (PushLayerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PushLayerFunc));
            
            return m_PushLayerFunc(m_ptr, ref layerParameters1, layer!=null ? layer.Ptr : IntPtr.Zero);
        }
        delegate int PushLayerFunc(IntPtr self, ref D2D1_LAYER_PARAMETERS1 layerParameters1, IntPtr layer);
        PushLayerFunc m_PushLayerFunc;

        public virtual int PopAxisAlignedClip(
        ){
            var fp = GetFunctionPointer(26);
            if(m_PopAxisAlignedClipFunc==null) m_PopAxisAlignedClipFunc = (PopAxisAlignedClipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PopAxisAlignedClipFunc));
            
            return m_PopAxisAlignedClipFunc(m_ptr);
        }
        delegate int PopAxisAlignedClipFunc(IntPtr self);
        PopAxisAlignedClipFunc m_PopAxisAlignedClipFunc;

        public virtual int PopLayer(
        ){
            var fp = GetFunctionPointer(27);
            if(m_PopLayerFunc==null) m_PopLayerFunc = (PopLayerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PopLayerFunc));
            
            return m_PopLayerFunc(m_ptr);
        }
        delegate int PopLayerFunc(IntPtr self);
        PopLayerFunc m_PopLayerFunc;

    }
}
