// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICJpegFrameEncode: IUnknown
    {
        static Guid s_uuid = new Guid("2f0c601f-d2c6-468c-abfa-49495d983ed1");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetAcHuffmanTable(
            uint scanIndex,
            uint tableIndex,
            out DXGI_JPEG_AC_HUFFMAN_TABLE pAcHuffmanTable
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetAcHuffmanTableFunc==null) m_GetAcHuffmanTableFunc = (GetAcHuffmanTableFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAcHuffmanTableFunc));
            
            return m_GetAcHuffmanTableFunc(m_ptr, scanIndex, tableIndex, out pAcHuffmanTable);
        }
        delegate int GetAcHuffmanTableFunc(IntPtr self, uint scanIndex, uint tableIndex, out DXGI_JPEG_AC_HUFFMAN_TABLE pAcHuffmanTable);
        GetAcHuffmanTableFunc m_GetAcHuffmanTableFunc;

        public virtual int GetDcHuffmanTable(
            uint scanIndex,
            uint tableIndex,
            out DXGI_JPEG_DC_HUFFMAN_TABLE pDcHuffmanTable
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetDcHuffmanTableFunc==null) m_GetDcHuffmanTableFunc = (GetDcHuffmanTableFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDcHuffmanTableFunc));
            
            return m_GetDcHuffmanTableFunc(m_ptr, scanIndex, tableIndex, out pDcHuffmanTable);
        }
        delegate int GetDcHuffmanTableFunc(IntPtr self, uint scanIndex, uint tableIndex, out DXGI_JPEG_DC_HUFFMAN_TABLE pDcHuffmanTable);
        GetDcHuffmanTableFunc m_GetDcHuffmanTableFunc;

        public virtual int GetQuantizationTable(
            uint scanIndex,
            uint tableIndex,
            out DXGI_JPEG_QUANTIZATION_TABLE pQuantizationTable
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetQuantizationTableFunc==null) m_GetQuantizationTableFunc = (GetQuantizationTableFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetQuantizationTableFunc));
            
            return m_GetQuantizationTableFunc(m_ptr, scanIndex, tableIndex, out pQuantizationTable);
        }
        delegate int GetQuantizationTableFunc(IntPtr self, uint scanIndex, uint tableIndex, out DXGI_JPEG_QUANTIZATION_TABLE pQuantizationTable);
        GetQuantizationTableFunc m_GetQuantizationTableFunc;

        public virtual int WriteScan(
            uint cbScanData,
            ref byte pbScanData
        ){
            var fp = GetFunctionPointer(6);
            if(m_WriteScanFunc==null) m_WriteScanFunc = (WriteScanFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WriteScanFunc));
            
            return m_WriteScanFunc(m_ptr, cbScanData, ref pbScanData);
        }
        delegate int WriteScanFunc(IntPtr self, uint cbScanData, ref byte pbScanData);
        WriteScanFunc m_WriteScanFunc;

    }
}