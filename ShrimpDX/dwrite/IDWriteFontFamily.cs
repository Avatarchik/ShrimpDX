// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDWriteFontFamily: IDWriteFontList
    {
        static Guid s_uuid = new Guid("da20d8ef-812a-4c43-9802-62ec4abd7add");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int GetFamilyNames(
            out IDWriteLocalizedStrings names
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetFamilyNamesFunc==null) m_GetFamilyNamesFunc = (GetFamilyNamesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFamilyNamesFunc));
            names = new IDWriteLocalizedStrings();
            return m_GetFamilyNamesFunc(m_ptr, out names.PtrForNew);
        }
        delegate int GetFamilyNamesFunc(IntPtr self, out IntPtr names);
        GetFamilyNamesFunc m_GetFamilyNamesFunc;

        public virtual int GetFirstMatchingFont(
            DWRITE_FONT_WEIGHT weight,
            DWRITE_FONT_STRETCH stretch,
            DWRITE_FONT_STYLE style,
            out IDWriteFont matchingFont
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetFirstMatchingFontFunc==null) m_GetFirstMatchingFontFunc = (GetFirstMatchingFontFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFirstMatchingFontFunc));
            matchingFont = new IDWriteFont();
            return m_GetFirstMatchingFontFunc(m_ptr, weight, stretch, style, out matchingFont.PtrForNew);
        }
        delegate int GetFirstMatchingFontFunc(IntPtr self, DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, out IntPtr matchingFont);
        GetFirstMatchingFontFunc m_GetFirstMatchingFontFunc;

        public virtual int GetMatchingFonts(
            DWRITE_FONT_WEIGHT weight,
            DWRITE_FONT_STRETCH stretch,
            DWRITE_FONT_STYLE style,
            out IDWriteFontList matchingFonts
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetMatchingFontsFunc==null) m_GetMatchingFontsFunc = (GetMatchingFontsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMatchingFontsFunc));
            matchingFonts = new IDWriteFontList();
            return m_GetMatchingFontsFunc(m_ptr, weight, stretch, style, out matchingFonts.PtrForNew);
        }
        delegate int GetMatchingFontsFunc(IntPtr self, DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, out IntPtr matchingFonts);
        GetMatchingFontsFunc m_GetMatchingFontsFunc;

    }
}
