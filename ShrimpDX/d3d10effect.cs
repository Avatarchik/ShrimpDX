// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    [StructLayout(LayoutKind.Sequential)]
    public struct _D3D10_EFFECT_DESC // 1
    {
        public int IsChildEffect;
        public uint ConstantBuffers;
        public uint SharedConstantBuffers;
        public uint GlobalVariables;
        public uint SharedGlobalVariables;
        public uint Techniques;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _D3D10_EFFECT_TYPE_DESC // 1
    {
        [MarshalAs(UnmanagedType.LPStr)]public string TypeName;
        public _D3D_SHADER_VARIABLE_CLASS Class;
        public _D3D_SHADER_VARIABLE_TYPE Type;
        public uint Elements;
        public uint Members;
        public uint Rows;
        public uint Columns;
        public uint PackedSize;
        public uint UnpackedSize;
        public uint Stride;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _D3D10_EFFECT_VARIABLE_DESC // 1
    {
        [MarshalAs(UnmanagedType.LPStr)]public string Name;
        [MarshalAs(UnmanagedType.LPStr)]public string Semantic;
        public uint Flags;
        public uint Annotations;
        public uint BufferOffset;
        public uint ExplicitBindPoint;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _D3D10_EFFECT_SHADER_DESC // 1
    {
        public IntPtr pInputSignature;
        public int IsInline;
        public IntPtr pBytecode;
        public uint BytecodeLength;
        [MarshalAs(UnmanagedType.LPStr)]public string SODecl;
        public uint NumInputSignatureEntries;
        public uint NumOutputSignatureEntries;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _D3D10_TECHNIQUE_DESC // 1
    {
        [MarshalAs(UnmanagedType.LPStr)]public string Name;
        public uint Passes;
        public uint Annotations;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _D3D10_PASS_DESC // 1
    {
        [MarshalAs(UnmanagedType.LPStr)]public string Name;
        public uint Annotations;
        public IntPtr pIAInputSignature;
        public ulong IAInputSignatureSize;
        public uint StencilRef;
        public uint SampleMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]public float[] BlendFactor;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _D3D10_PASS_SHADER_DESC // 1
    {
        public ID3D10EffectShaderVariable pShaderVariable;
        public uint ShaderIndex;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _D3D10_STATE_BLOCK_MASK // 1
    {
        public byte VS;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]public byte[] VSSamplers;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]public byte[] VSShaderResources;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]public byte[] VSConstantBuffers;
        public byte GS;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]public byte[] GSSamplers;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]public byte[] GSShaderResources;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]public byte[] GSConstantBuffers;
        public byte PS;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]public byte[] PSSamplers;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]public byte[] PSShaderResources;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]public byte[] PSConstantBuffers;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]public byte[] IAVertexBuffers;
        public byte IAIndexBuffer;
        public byte IAInputLayout;
        public byte IAPrimitiveTopology;
        public byte OMRenderTargets;
        public byte OMDepthStencilState;
        public byte OMBlendState;
        public byte RSViewports;
        public byte RSScissorRects;
        public byte RSRasterizerState;
        public byte SOBuffers;
        public byte Predication;
    }
}
