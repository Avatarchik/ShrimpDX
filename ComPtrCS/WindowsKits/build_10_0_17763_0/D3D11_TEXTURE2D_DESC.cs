/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=44)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEXTURE2D_DESC{
    /// (UINT)
    public UInt32 Width;

    /// (UINT)
    public UInt32 Height;

    /// (UINT)
    public UInt32 MipLevels;

    /// (UINT)
    public UInt32 ArraySize;

    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    /// (DXGI_SAMPLE_DESC)
    public DXGI_SAMPLE_DESC SampleDesc;

    /// (D3D11_USAGE)
    public D3D11_USAGE Usage;

    /// (UINT)
    public UInt32 BindFlags;

    /// (UINT)
    public UInt32 CPUAccessFlags;

    /// (UINT)
    public UInt32 MiscFlags;

}
}