
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace WindowsKits.build_10_0_17763_0 {

public enum D3D_DRIVER_TYPE {
    UNKNOWN = 0x00000000,
    HARDWARE = 0x00000001,
    REFERENCE = 0x00000002,
    NULL = 0x00000003,
    SOFTWARE = 0x00000004,
    WARP = 0x00000005,
}

public enum D3D_FEATURE_LEVEL {
    _9_1 = 0x00009100,
    _9_2 = 0x00009200,
    _9_3 = 0x00009300,
    _10_0 = 0x0000a000,
    _10_1 = 0x0000a100,
    _11_0 = 0x0000b000,
    _11_1 = 0x0000b100,
    _12_0 = 0x0000c000,
    _12_1 = 0x0000c100,
}

public enum D3D_PRIMITIVE_TOPOLOGY {
    UNDEFINED = 0x00000000,
    POINTLIST = 0x00000001,
    LINELIST = 0x00000002,
    LINESTRIP = 0x00000003,
    TRIANGLELIST = 0x00000004,
    TRIANGLESTRIP = 0x00000005,
    LINELIST_ADJ = 0x0000000a,
    LINESTRIP_ADJ = 0x0000000b,
    TRIANGLELIST_ADJ = 0x0000000c,
    TRIANGLESTRIP_ADJ = 0x0000000d,
    _1_CONTROL_POINT_PATCHLIST = 0x00000021,
    _2_CONTROL_POINT_PATCHLIST = 0x00000022,
    _3_CONTROL_POINT_PATCHLIST = 0x00000023,
    _4_CONTROL_POINT_PATCHLIST = 0x00000024,
    _5_CONTROL_POINT_PATCHLIST = 0x00000025,
    _6_CONTROL_POINT_PATCHLIST = 0x00000026,
    _7_CONTROL_POINT_PATCHLIST = 0x00000027,
    _8_CONTROL_POINT_PATCHLIST = 0x00000028,
    _9_CONTROL_POINT_PATCHLIST = 0x00000029,
    _10_CONTROL_POINT_PATCHLIST = 0x0000002a,
    _11_CONTROL_POINT_PATCHLIST = 0x0000002b,
    _12_CONTROL_POINT_PATCHLIST = 0x0000002c,
    _13_CONTROL_POINT_PATCHLIST = 0x0000002d,
    _14_CONTROL_POINT_PATCHLIST = 0x0000002e,
    _15_CONTROL_POINT_PATCHLIST = 0x0000002f,
    _16_CONTROL_POINT_PATCHLIST = 0x00000030,
    _17_CONTROL_POINT_PATCHLIST = 0x00000031,
    _18_CONTROL_POINT_PATCHLIST = 0x00000032,
    _19_CONTROL_POINT_PATCHLIST = 0x00000033,
    _20_CONTROL_POINT_PATCHLIST = 0x00000034,
    _21_CONTROL_POINT_PATCHLIST = 0x00000035,
    _22_CONTROL_POINT_PATCHLIST = 0x00000036,
    _23_CONTROL_POINT_PATCHLIST = 0x00000037,
    _24_CONTROL_POINT_PATCHLIST = 0x00000038,
    _25_CONTROL_POINT_PATCHLIST = 0x00000039,
    _26_CONTROL_POINT_PATCHLIST = 0x0000003a,
    _27_CONTROL_POINT_PATCHLIST = 0x0000003b,
    _28_CONTROL_POINT_PATCHLIST = 0x0000003c,
    _29_CONTROL_POINT_PATCHLIST = 0x0000003d,
    _30_CONTROL_POINT_PATCHLIST = 0x0000003e,
    _31_CONTROL_POINT_PATCHLIST = 0x0000003f,
    _32_CONTROL_POINT_PATCHLIST = 0x00000040,
    D3D10_PRIMITIVE_TOPOLOGY_UNDEFINED = 0x00000000,
    D3D10_PRIMITIVE_TOPOLOGY_POINTLIST = 0x00000001,
    D3D10_PRIMITIVE_TOPOLOGY_LINELIST = 0x00000002,
    D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP = 0x00000003,
    D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST = 0x00000004,
    D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP = 0x00000005,
    D3D10_PRIMITIVE_TOPOLOGY_LINELIST_ADJ = 0x0000000a,
    D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ = 0x0000000b,
    D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ = 0x0000000c,
    D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ = 0x0000000d,
    D3D11_PRIMITIVE_TOPOLOGY_UNDEFINED = 0x00000000,
    D3D11_PRIMITIVE_TOPOLOGY_POINTLIST = 0x00000001,
    D3D11_PRIMITIVE_TOPOLOGY_LINELIST = 0x00000002,
    D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP = 0x00000003,
    D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST = 0x00000004,
    D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP = 0x00000005,
    D3D11_PRIMITIVE_TOPOLOGY_LINELIST_ADJ = 0x0000000a,
    D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ = 0x0000000b,
    D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ = 0x0000000c,
    D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ = 0x0000000d,
    D3D11_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST = 0x00000021,
    D3D11_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST = 0x00000022,
    D3D11_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST = 0x00000023,
    D3D11_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST = 0x00000024,
    D3D11_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST = 0x00000025,
    D3D11_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST = 0x00000026,
    D3D11_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST = 0x00000027,
    D3D11_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST = 0x00000028,
    D3D11_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST = 0x00000029,
    D3D11_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST = 0x0000002a,
    D3D11_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST = 0x0000002b,
    D3D11_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST = 0x0000002c,
    D3D11_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST = 0x0000002d,
    D3D11_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST = 0x0000002e,
    D3D11_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST = 0x0000002f,
    D3D11_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST = 0x00000030,
    D3D11_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST = 0x00000031,
    D3D11_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST = 0x00000032,
    D3D11_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST = 0x00000033,
    D3D11_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST = 0x00000034,
    D3D11_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST = 0x00000035,
    D3D11_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST = 0x00000036,
    D3D11_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST = 0x00000037,
    D3D11_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST = 0x00000038,
    D3D11_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST = 0x00000039,
    D3D11_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST = 0x0000003a,
    D3D11_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST = 0x0000003b,
    D3D11_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST = 0x0000003c,
    D3D11_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST = 0x0000003d,
    D3D11_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST = 0x0000003e,
    D3D11_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST = 0x0000003f,
    D3D11_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST = 0x00000040,
}

public enum D3D_PRIMITIVE {
    UNDEFINED = 0x00000000,
    POINT = 0x00000001,
    LINE = 0x00000002,
    TRIANGLE = 0x00000003,
    LINE_ADJ = 0x00000006,
    TRIANGLE_ADJ = 0x00000007,
    _1_CONTROL_POINT_PATCH = 0x00000008,
    _2_CONTROL_POINT_PATCH = 0x00000009,
    _3_CONTROL_POINT_PATCH = 0x0000000a,
    _4_CONTROL_POINT_PATCH = 0x0000000b,
    _5_CONTROL_POINT_PATCH = 0x0000000c,
    _6_CONTROL_POINT_PATCH = 0x0000000d,
    _7_CONTROL_POINT_PATCH = 0x0000000e,
    _8_CONTROL_POINT_PATCH = 0x0000000f,
    _9_CONTROL_POINT_PATCH = 0x00000010,
    _10_CONTROL_POINT_PATCH = 0x00000011,
    _11_CONTROL_POINT_PATCH = 0x00000012,
    _12_CONTROL_POINT_PATCH = 0x00000013,
    _13_CONTROL_POINT_PATCH = 0x00000014,
    _14_CONTROL_POINT_PATCH = 0x00000015,
    _15_CONTROL_POINT_PATCH = 0x00000016,
    _16_CONTROL_POINT_PATCH = 0x00000017,
    _17_CONTROL_POINT_PATCH = 0x00000018,
    _18_CONTROL_POINT_PATCH = 0x00000019,
    _19_CONTROL_POINT_PATCH = 0x0000001a,
    _20_CONTROL_POINT_PATCH = 0x0000001b,
    _21_CONTROL_POINT_PATCH = 0x0000001c,
    _22_CONTROL_POINT_PATCH = 0x0000001d,
    _23_CONTROL_POINT_PATCH = 0x0000001e,
    _24_CONTROL_POINT_PATCH = 0x0000001f,
    _25_CONTROL_POINT_PATCH = 0x00000020,
    _26_CONTROL_POINT_PATCH = 0x00000021,
    _27_CONTROL_POINT_PATCH = 0x00000022,
    _28_CONTROL_POINT_PATCH = 0x00000023,
    _29_CONTROL_POINT_PATCH = 0x00000024,
    _30_CONTROL_POINT_PATCH = 0x00000025,
    _31_CONTROL_POINT_PATCH = 0x00000026,
    _32_CONTROL_POINT_PATCH = 0x00000027,
    D3D10_PRIMITIVE_UNDEFINED = 0x00000000,
    D3D10_PRIMITIVE_POINT = 0x00000001,
    D3D10_PRIMITIVE_LINE = 0x00000002,
    D3D10_PRIMITIVE_TRIANGLE = 0x00000003,
    D3D10_PRIMITIVE_LINE_ADJ = 0x00000006,
    D3D10_PRIMITIVE_TRIANGLE_ADJ = 0x00000007,
    D3D11_PRIMITIVE_UNDEFINED = 0x00000000,
    D3D11_PRIMITIVE_POINT = 0x00000001,
    D3D11_PRIMITIVE_LINE = 0x00000002,
    D3D11_PRIMITIVE_TRIANGLE = 0x00000003,
    D3D11_PRIMITIVE_LINE_ADJ = 0x00000006,
    D3D11_PRIMITIVE_TRIANGLE_ADJ = 0x00000007,
    D3D11_PRIMITIVE_1_CONTROL_POINT_PATCH = 0x00000008,
    D3D11_PRIMITIVE_2_CONTROL_POINT_PATCH = 0x00000009,
    D3D11_PRIMITIVE_3_CONTROL_POINT_PATCH = 0x0000000a,
    D3D11_PRIMITIVE_4_CONTROL_POINT_PATCH = 0x0000000b,
    D3D11_PRIMITIVE_5_CONTROL_POINT_PATCH = 0x0000000c,
    D3D11_PRIMITIVE_6_CONTROL_POINT_PATCH = 0x0000000d,
    D3D11_PRIMITIVE_7_CONTROL_POINT_PATCH = 0x0000000e,
    D3D11_PRIMITIVE_8_CONTROL_POINT_PATCH = 0x0000000f,
    D3D11_PRIMITIVE_9_CONTROL_POINT_PATCH = 0x00000010,
    D3D11_PRIMITIVE_10_CONTROL_POINT_PATCH = 0x00000011,
    D3D11_PRIMITIVE_11_CONTROL_POINT_PATCH = 0x00000012,
    D3D11_PRIMITIVE_12_CONTROL_POINT_PATCH = 0x00000013,
    D3D11_PRIMITIVE_13_CONTROL_POINT_PATCH = 0x00000014,
    D3D11_PRIMITIVE_14_CONTROL_POINT_PATCH = 0x00000015,
    D3D11_PRIMITIVE_15_CONTROL_POINT_PATCH = 0x00000016,
    D3D11_PRIMITIVE_16_CONTROL_POINT_PATCH = 0x00000017,
    D3D11_PRIMITIVE_17_CONTROL_POINT_PATCH = 0x00000018,
    D3D11_PRIMITIVE_18_CONTROL_POINT_PATCH = 0x00000019,
    D3D11_PRIMITIVE_19_CONTROL_POINT_PATCH = 0x0000001a,
    D3D11_PRIMITIVE_20_CONTROL_POINT_PATCH = 0x0000001b,
    D3D11_PRIMITIVE_21_CONTROL_POINT_PATCH = 0x0000001c,
    D3D11_PRIMITIVE_22_CONTROL_POINT_PATCH = 0x0000001d,
    D3D11_PRIMITIVE_23_CONTROL_POINT_PATCH = 0x0000001e,
    D3D11_PRIMITIVE_24_CONTROL_POINT_PATCH = 0x0000001f,
    D3D11_PRIMITIVE_25_CONTROL_POINT_PATCH = 0x00000020,
    D3D11_PRIMITIVE_26_CONTROL_POINT_PATCH = 0x00000021,
    D3D11_PRIMITIVE_27_CONTROL_POINT_PATCH = 0x00000022,
    D3D11_PRIMITIVE_28_CONTROL_POINT_PATCH = 0x00000023,
    D3D11_PRIMITIVE_29_CONTROL_POINT_PATCH = 0x00000024,
    D3D11_PRIMITIVE_30_CONTROL_POINT_PATCH = 0x00000025,
    D3D11_PRIMITIVE_31_CONTROL_POINT_PATCH = 0x00000026,
    D3D11_PRIMITIVE_32_CONTROL_POINT_PATCH = 0x00000027,
}

public enum D3D_SRV_DIMENSION {
    UNKNOWN = 0x00000000,
    BUFFER = 0x00000001,
    TEXTURE1D = 0x00000002,
    TEXTURE1DARRAY = 0x00000003,
    TEXTURE2D = 0x00000004,
    TEXTURE2DARRAY = 0x00000005,
    TEXTURE2DMS = 0x00000006,
    TEXTURE2DMSARRAY = 0x00000007,
    TEXTURE3D = 0x00000008,
    TEXTURECUBE = 0x00000009,
    TEXTURECUBEARRAY = 0x0000000a,
    BUFFEREX = 0x0000000b,
    D3D10_SRV_DIMENSION_UNKNOWN = 0x00000000,
    D3D10_SRV_DIMENSION_BUFFER = 0x00000001,
    D3D10_SRV_DIMENSION_TEXTURE1D = 0x00000002,
    D3D10_SRV_DIMENSION_TEXTURE1DARRAY = 0x00000003,
    D3D10_SRV_DIMENSION_TEXTURE2D = 0x00000004,
    D3D10_SRV_DIMENSION_TEXTURE2DARRAY = 0x00000005,
    D3D10_SRV_DIMENSION_TEXTURE2DMS = 0x00000006,
    D3D10_SRV_DIMENSION_TEXTURE2DMSARRAY = 0x00000007,
    D3D10_SRV_DIMENSION_TEXTURE3D = 0x00000008,
    D3D10_SRV_DIMENSION_TEXTURECUBE = 0x00000009,
    D3D10_1_SRV_DIMENSION_UNKNOWN = 0x00000000,
    D3D10_1_SRV_DIMENSION_BUFFER = 0x00000001,
    D3D10_1_SRV_DIMENSION_TEXTURE1D = 0x00000002,
    D3D10_1_SRV_DIMENSION_TEXTURE1DARRAY = 0x00000003,
    D3D10_1_SRV_DIMENSION_TEXTURE2D = 0x00000004,
    D3D10_1_SRV_DIMENSION_TEXTURE2DARRAY = 0x00000005,
    D3D10_1_SRV_DIMENSION_TEXTURE2DMS = 0x00000006,
    D3D10_1_SRV_DIMENSION_TEXTURE2DMSARRAY = 0x00000007,
    D3D10_1_SRV_DIMENSION_TEXTURE3D = 0x00000008,
    D3D10_1_SRV_DIMENSION_TEXTURECUBE = 0x00000009,
    D3D10_1_SRV_DIMENSION_TEXTURECUBEARRAY = 0x0000000a,
    D3D11_SRV_DIMENSION_UNKNOWN = 0x00000000,
    D3D11_SRV_DIMENSION_BUFFER = 0x00000001,
    D3D11_SRV_DIMENSION_TEXTURE1D = 0x00000002,
    D3D11_SRV_DIMENSION_TEXTURE1DARRAY = 0x00000003,
    D3D11_SRV_DIMENSION_TEXTURE2D = 0x00000004,
    D3D11_SRV_DIMENSION_TEXTURE2DARRAY = 0x00000005,
    D3D11_SRV_DIMENSION_TEXTURE2DMS = 0x00000006,
    D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY = 0x00000007,
    D3D11_SRV_DIMENSION_TEXTURE3D = 0x00000008,
    D3D11_SRV_DIMENSION_TEXTURECUBE = 0x00000009,
    D3D11_SRV_DIMENSION_TEXTURECUBEARRAY = 0x0000000a,
    D3D11_SRV_DIMENSION_BUFFEREX = 0x0000000b,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct _D3D_SHADER_MACRO{
    /* (LPCSTR) */IntPtr Name;
    /* (LPCSTR) */IntPtr Definition;
}

public struct D3D_SHADER_MACRO{
    public /* (_D3D_SHADER_MACRO) */_D3D_SHADER_MACRO Value;
}

[ComImport, Guid("8ba5fb08-5195-40e2-ac58-0d989c3a0102")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ID3D10Blob{
    /* (LPVOID) */IntPtr GetBufferPointer();
    /* (SIZE_T) */UIntPtr GetBufferSize();
}

public struct ID3DBlob{
    public /* (ID3D10Blob) */ID3D10Blob Value;
}

public struct LPD3DBLOB{
    public /* (ID3DBlob) */ID3DBlob Value;
}

public struct PFN_DESTRUCTION_CALLBACK{
    public IntPtr Value;
}

[ComImport, Guid("a06eb39a-50da-425b-8c31-4eecd6c270f3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ID3DDestructionNotifier{
    /* (HRESULT) */Int32 RegisterDestructionCallback(/* (PFN_DESTRUCTION_CALLBACK) */PFN_DESTRUCTION_CALLBACK callbackFn, /* (*(void)) */IntPtr pData, /* (*(UINT)) */ref UInt32 pCallbackID);
    /* (HRESULT) */Int32 UnregisterDestructionCallback(/* (UINT) */UInt32 callbackID);
}

public enum _D3D_INCLUDE_TYPE {
    D3D_INCLUDE_LOCAL = 0x00000000,
    D3D_INCLUDE_SYSTEM = 0x00000001,
    D3D10_INCLUDE_LOCAL = 0x00000000,
    D3D10_INCLUDE_SYSTEM = 0x00000001,
    D3D_INCLUDE_FORCE_DWORD = 0x7fffffff,
}

public struct D3D_INCLUDE_TYPE{
    public /* (_D3D_INCLUDE_TYPE) */_D3D_INCLUDE_TYPE Value;
}

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ID3DInclude{
    /* (HRESULT) */Int32 Open(/* (D3D_INCLUDE_TYPE) */D3D_INCLUDE_TYPE IncludeType, /* (LPCSTR) */IntPtr pFileName, /* (LPCVOID) */IntPtr pParentData, /* (*(LPCVOID)) */ref IntPtr ppData, /* (*(UINT)) */ref UInt32 pBytes);
    /* (HRESULT) */Int32 Close(/* (LPCVOID) */IntPtr pData);
}

public struct LPD3DINCLUDE{
    public /* (ID3DInclude) */ID3DInclude Value;
}

public enum _D3D_SHADER_VARIABLE_CLASS {
    D3D_SVC_SCALAR = 0x00000000,
    D3D_SVC_VECTOR = 0x00000001,
    D3D_SVC_MATRIX_ROWS = 0x00000002,
    D3D_SVC_MATRIX_COLUMNS = 0x00000003,
    D3D_SVC_OBJECT = 0x00000004,
    D3D_SVC_STRUCT = 0x00000005,
    D3D_SVC_INTERFACE_CLASS = 0x00000006,
    D3D_SVC_INTERFACE_POINTER = 0x00000007,
    D3D10_SVC_SCALAR = 0x00000000,
    D3D10_SVC_VECTOR = 0x00000001,
    D3D10_SVC_MATRIX_ROWS = 0x00000002,
    D3D10_SVC_MATRIX_COLUMNS = 0x00000003,
    D3D10_SVC_OBJECT = 0x00000004,
    D3D10_SVC_STRUCT = 0x00000005,
    D3D11_SVC_INTERFACE_CLASS = 0x00000006,
    D3D11_SVC_INTERFACE_POINTER = 0x00000007,
    D3D_SVC_FORCE_DWORD = 0x7fffffff,
}

public struct D3D_SHADER_VARIABLE_CLASS{
    public /* (_D3D_SHADER_VARIABLE_CLASS) */_D3D_SHADER_VARIABLE_CLASS Value;
}

public enum _D3D_SHADER_VARIABLE_FLAGS {
    D3D_SVF_USERPACKED = 0x00000001,
    D3D_SVF_USED = 0x00000002,
    D3D_SVF_INTERFACE_POINTER = 0x00000004,
    D3D_SVF_INTERFACE_PARAMETER = 0x00000008,
    D3D10_SVF_USERPACKED = 0x00000001,
    D3D10_SVF_USED = 0x00000002,
    D3D11_SVF_INTERFACE_POINTER = 0x00000004,
    D3D11_SVF_INTERFACE_PARAMETER = 0x00000008,
    D3D_SVF_FORCE_DWORD = 0x7fffffff,
}

public struct D3D_SHADER_VARIABLE_FLAGS{
    public /* (_D3D_SHADER_VARIABLE_FLAGS) */_D3D_SHADER_VARIABLE_FLAGS Value;
}

public enum _D3D_SHADER_VARIABLE_TYPE {
    D3D_SVT_VOID = 0x00000000,
    D3D_SVT_BOOL = 0x00000001,
    D3D_SVT_INT = 0x00000002,
    D3D_SVT_FLOAT = 0x00000003,
    D3D_SVT_STRING = 0x00000004,
    D3D_SVT_TEXTURE = 0x00000005,
    D3D_SVT_TEXTURE1D = 0x00000006,
    D3D_SVT_TEXTURE2D = 0x00000007,
    D3D_SVT_TEXTURE3D = 0x00000008,
    D3D_SVT_TEXTURECUBE = 0x00000009,
    D3D_SVT_SAMPLER = 0x0000000a,
    D3D_SVT_SAMPLER1D = 0x0000000b,
    D3D_SVT_SAMPLER2D = 0x0000000c,
    D3D_SVT_SAMPLER3D = 0x0000000d,
    D3D_SVT_SAMPLERCUBE = 0x0000000e,
    D3D_SVT_PIXELSHADER = 0x0000000f,
    D3D_SVT_VERTEXSHADER = 0x00000010,
    D3D_SVT_PIXELFRAGMENT = 0x00000011,
    D3D_SVT_VERTEXFRAGMENT = 0x00000012,
    D3D_SVT_UINT = 0x00000013,
    D3D_SVT_UINT8 = 0x00000014,
    D3D_SVT_GEOMETRYSHADER = 0x00000015,
    D3D_SVT_RASTERIZER = 0x00000016,
    D3D_SVT_DEPTHSTENCIL = 0x00000017,
    D3D_SVT_BLEND = 0x00000018,
    D3D_SVT_BUFFER = 0x00000019,
    D3D_SVT_CBUFFER = 0x0000001a,
    D3D_SVT_TBUFFER = 0x0000001b,
    D3D_SVT_TEXTURE1DARRAY = 0x0000001c,
    D3D_SVT_TEXTURE2DARRAY = 0x0000001d,
    D3D_SVT_RENDERTARGETVIEW = 0x0000001e,
    D3D_SVT_DEPTHSTENCILVIEW = 0x0000001f,
    D3D_SVT_TEXTURE2DMS = 0x00000020,
    D3D_SVT_TEXTURE2DMSARRAY = 0x00000021,
    D3D_SVT_TEXTURECUBEARRAY = 0x00000022,
    D3D_SVT_HULLSHADER = 0x00000023,
    D3D_SVT_DOMAINSHADER = 0x00000024,
    D3D_SVT_INTERFACE_POINTER = 0x00000025,
    D3D_SVT_COMPUTESHADER = 0x00000026,
    D3D_SVT_DOUBLE = 0x00000027,
    D3D_SVT_RWTEXTURE1D = 0x00000028,
    D3D_SVT_RWTEXTURE1DARRAY = 0x00000029,
    D3D_SVT_RWTEXTURE2D = 0x0000002a,
    D3D_SVT_RWTEXTURE2DARRAY = 0x0000002b,
    D3D_SVT_RWTEXTURE3D = 0x0000002c,
    D3D_SVT_RWBUFFER = 0x0000002d,
    D3D_SVT_BYTEADDRESS_BUFFER = 0x0000002e,
    D3D_SVT_RWBYTEADDRESS_BUFFER = 0x0000002f,
    D3D_SVT_STRUCTURED_BUFFER = 0x00000030,
    D3D_SVT_RWSTRUCTURED_BUFFER = 0x00000031,
    D3D_SVT_APPEND_STRUCTURED_BUFFER = 0x00000032,
    D3D_SVT_CONSUME_STRUCTURED_BUFFER = 0x00000033,
    D3D_SVT_MIN8FLOAT = 0x00000034,
    D3D_SVT_MIN10FLOAT = 0x00000035,
    D3D_SVT_MIN16FLOAT = 0x00000036,
    D3D_SVT_MIN12INT = 0x00000037,
    D3D_SVT_MIN16INT = 0x00000038,
    D3D_SVT_MIN16UINT = 0x00000039,
    D3D10_SVT_VOID = 0x00000000,
    D3D10_SVT_BOOL = 0x00000001,
    D3D10_SVT_INT = 0x00000002,
    D3D10_SVT_FLOAT = 0x00000003,
    D3D10_SVT_STRING = 0x00000004,
    D3D10_SVT_TEXTURE = 0x00000005,
    D3D10_SVT_TEXTURE1D = 0x00000006,
    D3D10_SVT_TEXTURE2D = 0x00000007,
    D3D10_SVT_TEXTURE3D = 0x00000008,
    D3D10_SVT_TEXTURECUBE = 0x00000009,
    D3D10_SVT_SAMPLER = 0x0000000a,
    D3D10_SVT_SAMPLER1D = 0x0000000b,
    D3D10_SVT_SAMPLER2D = 0x0000000c,
    D3D10_SVT_SAMPLER3D = 0x0000000d,
    D3D10_SVT_SAMPLERCUBE = 0x0000000e,
    D3D10_SVT_PIXELSHADER = 0x0000000f,
    D3D10_SVT_VERTEXSHADER = 0x00000010,
    D3D10_SVT_PIXELFRAGMENT = 0x00000011,
    D3D10_SVT_VERTEXFRAGMENT = 0x00000012,
    D3D10_SVT_UINT = 0x00000013,
    D3D10_SVT_UINT8 = 0x00000014,
    D3D10_SVT_GEOMETRYSHADER = 0x00000015,
    D3D10_SVT_RASTERIZER = 0x00000016,
    D3D10_SVT_DEPTHSTENCIL = 0x00000017,
    D3D10_SVT_BLEND = 0x00000018,
    D3D10_SVT_BUFFER = 0x00000019,
    D3D10_SVT_CBUFFER = 0x0000001a,
    D3D10_SVT_TBUFFER = 0x0000001b,
    D3D10_SVT_TEXTURE1DARRAY = 0x0000001c,
    D3D10_SVT_TEXTURE2DARRAY = 0x0000001d,
    D3D10_SVT_RENDERTARGETVIEW = 0x0000001e,
    D3D10_SVT_DEPTHSTENCILVIEW = 0x0000001f,
    D3D10_SVT_TEXTURE2DMS = 0x00000020,
    D3D10_SVT_TEXTURE2DMSARRAY = 0x00000021,
    D3D10_SVT_TEXTURECUBEARRAY = 0x00000022,
    D3D11_SVT_HULLSHADER = 0x00000023,
    D3D11_SVT_DOMAINSHADER = 0x00000024,
    D3D11_SVT_INTERFACE_POINTER = 0x00000025,
    D3D11_SVT_COMPUTESHADER = 0x00000026,
    D3D11_SVT_DOUBLE = 0x00000027,
    D3D11_SVT_RWTEXTURE1D = 0x00000028,
    D3D11_SVT_RWTEXTURE1DARRAY = 0x00000029,
    D3D11_SVT_RWTEXTURE2D = 0x0000002a,
    D3D11_SVT_RWTEXTURE2DARRAY = 0x0000002b,
    D3D11_SVT_RWTEXTURE3D = 0x0000002c,
    D3D11_SVT_RWBUFFER = 0x0000002d,
    D3D11_SVT_BYTEADDRESS_BUFFER = 0x0000002e,
    D3D11_SVT_RWBYTEADDRESS_BUFFER = 0x0000002f,
    D3D11_SVT_STRUCTURED_BUFFER = 0x00000030,
    D3D11_SVT_RWSTRUCTURED_BUFFER = 0x00000031,
    D3D11_SVT_APPEND_STRUCTURED_BUFFER = 0x00000032,
    D3D11_SVT_CONSUME_STRUCTURED_BUFFER = 0x00000033,
    D3D_SVT_FORCE_DWORD = 0x7fffffff,
}

public struct D3D_SHADER_VARIABLE_TYPE{
    public /* (_D3D_SHADER_VARIABLE_TYPE) */_D3D_SHADER_VARIABLE_TYPE Value;
}

public enum _D3D_SHADER_INPUT_FLAGS {
    D3D_SIF_USERPACKED = 0x00000001,
    D3D_SIF_COMPARISON_SAMPLER = 0x00000002,
    D3D_SIF_TEXTURE_COMPONENT_0 = 0x00000004,
    D3D_SIF_TEXTURE_COMPONENT_1 = 0x00000008,
    D3D_SIF_TEXTURE_COMPONENTS = 0x0000000c,
    D3D_SIF_UNUSED = 0x00000010,
    D3D10_SIF_USERPACKED = 0x00000001,
    D3D10_SIF_COMPARISON_SAMPLER = 0x00000002,
    D3D10_SIF_TEXTURE_COMPONENT_0 = 0x00000004,
    D3D10_SIF_TEXTURE_COMPONENT_1 = 0x00000008,
    D3D10_SIF_TEXTURE_COMPONENTS = 0x0000000c,
    D3D_SIF_FORCE_DWORD = 0x7fffffff,
}

public struct D3D_SHADER_INPUT_FLAGS{
    public /* (_D3D_SHADER_INPUT_FLAGS) */_D3D_SHADER_INPUT_FLAGS Value;
}

public enum _D3D_SHADER_INPUT_TYPE {
    D3D_SIT_CBUFFER = 0x00000000,
    D3D_SIT_TBUFFER = 0x00000001,
    D3D_SIT_TEXTURE = 0x00000002,
    D3D_SIT_SAMPLER = 0x00000003,
    D3D_SIT_UAV_RWTYPED = 0x00000004,
    D3D_SIT_STRUCTURED = 0x00000005,
    D3D_SIT_UAV_RWSTRUCTURED = 0x00000006,
    D3D_SIT_BYTEADDRESS = 0x00000007,
    D3D_SIT_UAV_RWBYTEADDRESS = 0x00000008,
    D3D_SIT_UAV_APPEND_STRUCTURED = 0x00000009,
    D3D_SIT_UAV_CONSUME_STRUCTURED = 0x0000000a,
    D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER = 0x0000000b,
    D3D10_SIT_CBUFFER = 0x00000000,
    D3D10_SIT_TBUFFER = 0x00000001,
    D3D10_SIT_TEXTURE = 0x00000002,
    D3D10_SIT_SAMPLER = 0x00000003,
    D3D11_SIT_UAV_RWTYPED = 0x00000004,
    D3D11_SIT_STRUCTURED = 0x00000005,
    D3D11_SIT_UAV_RWSTRUCTURED = 0x00000006,
    D3D11_SIT_BYTEADDRESS = 0x00000007,
    D3D11_SIT_UAV_RWBYTEADDRESS = 0x00000008,
    D3D11_SIT_UAV_APPEND_STRUCTURED = 0x00000009,
    D3D11_SIT_UAV_CONSUME_STRUCTURED = 0x0000000a,
    D3D11_SIT_UAV_RWSTRUCTURED_WITH_COUNTER = 0x0000000b,
}

public struct D3D_SHADER_INPUT_TYPE{
    public /* (_D3D_SHADER_INPUT_TYPE) */_D3D_SHADER_INPUT_TYPE Value;
}

public enum _D3D_SHADER_CBUFFER_FLAGS {
    D3D_CBF_USERPACKED = 0x00000001,
    D3D10_CBF_USERPACKED = 0x00000001,
    D3D_CBF_FORCE_DWORD = 0x7fffffff,
}

public struct D3D_SHADER_CBUFFER_FLAGS{
    public /* (_D3D_SHADER_CBUFFER_FLAGS) */_D3D_SHADER_CBUFFER_FLAGS Value;
}

public enum _D3D_CBUFFER_TYPE {
    D3D_CT_CBUFFER = 0x00000000,
    D3D_CT_TBUFFER = 0x00000001,
    D3D_CT_INTERFACE_POINTERS = 0x00000002,
    D3D_CT_RESOURCE_BIND_INFO = 0x00000003,
    D3D10_CT_CBUFFER = 0x00000000,
    D3D10_CT_TBUFFER = 0x00000001,
    D3D11_CT_CBUFFER = 0x00000000,
    D3D11_CT_TBUFFER = 0x00000001,
    D3D11_CT_INTERFACE_POINTERS = 0x00000002,
    D3D11_CT_RESOURCE_BIND_INFO = 0x00000003,
}

public struct D3D_CBUFFER_TYPE{
    public /* (_D3D_CBUFFER_TYPE) */_D3D_CBUFFER_TYPE Value;
}

public enum D3D_NAME {
    UNDEFINED = 0x00000000,
    POSITION = 0x00000001,
    CLIP_DISTANCE = 0x00000002,
    CULL_DISTANCE = 0x00000003,
    RENDER_TARGET_ARRAY_INDEX = 0x00000004,
    VIEWPORT_ARRAY_INDEX = 0x00000005,
    VERTEX_ID = 0x00000006,
    PRIMITIVE_ID = 0x00000007,
    INSTANCE_ID = 0x00000008,
    IS_FRONT_FACE = 0x00000009,
    SAMPLE_INDEX = 0x0000000a,
    FINAL_QUAD_EDGE_TESSFACTOR = 0x0000000b,
    FINAL_QUAD_INSIDE_TESSFACTOR = 0x0000000c,
    FINAL_TRI_EDGE_TESSFACTOR = 0x0000000d,
    FINAL_TRI_INSIDE_TESSFACTOR = 0x0000000e,
    FINAL_LINE_DETAIL_TESSFACTOR = 0x0000000f,
    FINAL_LINE_DENSITY_TESSFACTOR = 0x00000010,
    BARYCENTRICS = 0x00000017,
    TARGET = 0x00000040,
    DEPTH = 0x00000041,
    COVERAGE = 0x00000042,
    DEPTH_GREATER_EQUAL = 0x00000043,
    DEPTH_LESS_EQUAL = 0x00000044,
    STENCIL_REF = 0x00000045,
    INNER_COVERAGE = 0x00000046,
    D3D10_NAME_UNDEFINED = 0x00000000,
    D3D10_NAME_POSITION = 0x00000001,
    D3D10_NAME_CLIP_DISTANCE = 0x00000002,
    D3D10_NAME_CULL_DISTANCE = 0x00000003,
    D3D10_NAME_RENDER_TARGET_ARRAY_INDEX = 0x00000004,
    D3D10_NAME_VIEWPORT_ARRAY_INDEX = 0x00000005,
    D3D10_NAME_VERTEX_ID = 0x00000006,
    D3D10_NAME_PRIMITIVE_ID = 0x00000007,
    D3D10_NAME_INSTANCE_ID = 0x00000008,
    D3D10_NAME_IS_FRONT_FACE = 0x00000009,
    D3D10_NAME_SAMPLE_INDEX = 0x0000000a,
    D3D10_NAME_TARGET = 0x00000040,
    D3D10_NAME_DEPTH = 0x00000041,
    D3D10_NAME_COVERAGE = 0x00000042,
    D3D11_NAME_FINAL_QUAD_EDGE_TESSFACTOR = 0x0000000b,
    D3D11_NAME_FINAL_QUAD_INSIDE_TESSFACTOR = 0x0000000c,
    D3D11_NAME_FINAL_TRI_EDGE_TESSFACTOR = 0x0000000d,
    D3D11_NAME_FINAL_TRI_INSIDE_TESSFACTOR = 0x0000000e,
    D3D11_NAME_FINAL_LINE_DETAIL_TESSFACTOR = 0x0000000f,
    D3D11_NAME_FINAL_LINE_DENSITY_TESSFACTOR = 0x00000010,
    D3D11_NAME_DEPTH_GREATER_EQUAL = 0x00000043,
    D3D11_NAME_DEPTH_LESS_EQUAL = 0x00000044,
    D3D11_NAME_STENCIL_REF = 0x00000045,
    D3D11_NAME_INNER_COVERAGE = 0x00000046,
    D3D12_NAME_BARYCENTRICS = 0x00000017,
}

public enum D3D_RESOURCE_RETURN_TYPE {
    D3D_RETURN_TYPE_UNORM = 0x00000001,
    D3D_RETURN_TYPE_SNORM = 0x00000002,
    D3D_RETURN_TYPE_SINT = 0x00000003,
    D3D_RETURN_TYPE_UINT = 0x00000004,
    D3D_RETURN_TYPE_FLOAT = 0x00000005,
    D3D_RETURN_TYPE_MIXED = 0x00000006,
    D3D_RETURN_TYPE_DOUBLE = 0x00000007,
    D3D_RETURN_TYPE_CONTINUED = 0x00000008,
    D3D10_RETURN_TYPE_UNORM = 0x00000001,
    D3D10_RETURN_TYPE_SNORM = 0x00000002,
    D3D10_RETURN_TYPE_SINT = 0x00000003,
    D3D10_RETURN_TYPE_UINT = 0x00000004,
    D3D10_RETURN_TYPE_FLOAT = 0x00000005,
    D3D10_RETURN_TYPE_MIXED = 0x00000006,
    D3D11_RETURN_TYPE_UNORM = 0x00000001,
    D3D11_RETURN_TYPE_SNORM = 0x00000002,
    D3D11_RETURN_TYPE_SINT = 0x00000003,
    D3D11_RETURN_TYPE_UINT = 0x00000004,
    D3D11_RETURN_TYPE_FLOAT = 0x00000005,
    D3D11_RETURN_TYPE_MIXED = 0x00000006,
    D3D11_RETURN_TYPE_DOUBLE = 0x00000007,
    D3D11_RETURN_TYPE_CONTINUED = 0x00000008,
}

public enum D3D_REGISTER_COMPONENT_TYPE {
    D3D_REGISTER_COMPONENT_UNKNOWN = 0x00000000,
    D3D_REGISTER_COMPONENT_UINT32 = 0x00000001,
    D3D_REGISTER_COMPONENT_SINT32 = 0x00000002,
    D3D_REGISTER_COMPONENT_FLOAT32 = 0x00000003,
    D3D10_REGISTER_COMPONENT_UNKNOWN = 0x00000000,
    D3D10_REGISTER_COMPONENT_UINT32 = 0x00000001,
    D3D10_REGISTER_COMPONENT_SINT32 = 0x00000002,
    D3D10_REGISTER_COMPONENT_FLOAT32 = 0x00000003,
}

public enum D3D_TESSELLATOR_DOMAIN {
    UNDEFINED = 0x00000000,
    ISOLINE = 0x00000001,
    TRI = 0x00000002,
    QUAD = 0x00000003,
    D3D11_TESSELLATOR_DOMAIN_UNDEFINED = 0x00000000,
    D3D11_TESSELLATOR_DOMAIN_ISOLINE = 0x00000001,
    D3D11_TESSELLATOR_DOMAIN_TRI = 0x00000002,
    D3D11_TESSELLATOR_DOMAIN_QUAD = 0x00000003,
}

public enum D3D_TESSELLATOR_PARTITIONING {
    UNDEFINED = 0x00000000,
    INTEGER = 0x00000001,
    POW2 = 0x00000002,
    FRACTIONAL_ODD = 0x00000003,
    FRACTIONAL_EVEN = 0x00000004,
    D3D11_TESSELLATOR_PARTITIONING_UNDEFINED = 0x00000000,
    D3D11_TESSELLATOR_PARTITIONING_INTEGER = 0x00000001,
    D3D11_TESSELLATOR_PARTITIONING_POW2 = 0x00000002,
    D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD = 0x00000003,
    D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN = 0x00000004,
}

public enum D3D_TESSELLATOR_OUTPUT_PRIMITIVE {
    D3D_TESSELLATOR_OUTPUT_UNDEFINED = 0x00000000,
    D3D_TESSELLATOR_OUTPUT_POINT = 0x00000001,
    D3D_TESSELLATOR_OUTPUT_LINE = 0x00000002,
    D3D_TESSELLATOR_OUTPUT_TRIANGLE_CW = 0x00000003,
    D3D_TESSELLATOR_OUTPUT_TRIANGLE_CCW = 0x00000004,
    D3D11_TESSELLATOR_OUTPUT_UNDEFINED = 0x00000000,
    D3D11_TESSELLATOR_OUTPUT_POINT = 0x00000001,
    D3D11_TESSELLATOR_OUTPUT_LINE = 0x00000002,
    D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CW = 0x00000003,
    D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CCW = 0x00000004,
}

public enum D3D_MIN_PRECISION {
    DEFAULT = 0x00000000,
    FLOAT_16 = 0x00000001,
    FLOAT_2_8 = 0x00000002,
    RESERVED = 0x00000003,
    SINT_16 = 0x00000004,
    UINT_16 = 0x00000005,
    ANY_16 = 0x000000f0,
    ANY_10 = 0x000000f1,
}

public enum D3D_INTERPOLATION_MODE {
    UNDEFINED = 0x00000000,
    CONSTANT = 0x00000001,
    LINEAR = 0x00000002,
    LINEAR_CENTROID = 0x00000003,
    LINEAR_NOPERSPECTIVE = 0x00000004,
    LINEAR_NOPERSPECTIVE_CENTROID = 0x00000005,
    LINEAR_SAMPLE = 0x00000006,
    LINEAR_NOPERSPECTIVE_SAMPLE = 0x00000007,
}

public enum _D3D_PARAMETER_FLAGS {
    D3D_PF_NONE = 0x00000000,
    D3D_PF_IN = 0x00000001,
    D3D_PF_OUT = 0x00000002,
    D3D_PF_FORCE_DWORD = 0x7fffffff,
}

public struct D3D_PARAMETER_FLAGS{
    public /* (_D3D_PARAMETER_FLAGS) */_D3D_PARAMETER_FLAGS Value;
}

}
