// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    [StructLayout(LayoutKind.Explicit)]
    public struct tagTYPEDESC__anonymous_12 // 1
    {
        [FieldOffset(0)]
        public IntPtr lptdesc;
        [FieldOffset(0)]
        public IntPtr lpadesc;
        [FieldOffset(0)]
        public uint hreftype;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct tagELEMDESC__anonymous_29 // 1
    {
        [FieldOffset(0)]
        public tagIDLDESC idldesc;
        [FieldOffset(0)]
        public tagPARAMDESC paramdesc;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct tagVARIANT__anonymous_37 // 1
    {
       // anonymous struct __param__;
        [FieldOffset(0)]
        public tagDEC decVal;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagVARIANT___anonymous_38 // 1
    {
        public ushort vt;
        public ushort wReserved1;
        public ushort wReserved2;
        public ushort wReserved3;
        // anonymous union
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct tagVARIANT____anonymous_39 // 1
    {
        [FieldOffset(0)]
        public long llVal;
        [FieldOffset(0)]
        public int lVal;
        [FieldOffset(0)]
        public byte bVal;
        [FieldOffset(0)]
        public short iVal;
        [FieldOffset(0)]
        public float fltVal;
        [FieldOffset(0)]
        public double dblVal;
        [FieldOffset(0)]
        public short boolVal;
        [FieldOffset(0)]
        public int scode;
        [FieldOffset(0)]
        public tagCY cyVal;
        [FieldOffset(0)]
        public double date;
        [FieldOffset(0)]
        public IntPtr bstrVal;
        [FieldOffset(0)]
        public IUnknown punkVal;
        [FieldOffset(0)]
        public IDispatch pdispVal;
        [FieldOffset(0)]
        public IntPtr parray;
        [FieldOffset(0)]
        public IntPtr pbVal;
        [FieldOffset(0)]
        public IntPtr piVal;
        [FieldOffset(0)]
        public IntPtr plVal;
        [FieldOffset(0)]
        public IntPtr pllVal;
        [FieldOffset(0)]
        public IntPtr pfltVal;
        [FieldOffset(0)]
        public IntPtr pdblVal;
        [FieldOffset(0)]
        public IntPtr pboolVal;
        [FieldOffset(0)]
        public IntPtr pscode;
        [FieldOffset(0)]
        public IntPtr pcyVal;
        [FieldOffset(0)]
        public IntPtr pdate;
        [FieldOffset(0)]
        public IntPtr pbstrVal;
        [FieldOffset(0)]
        public IntPtr ppunkVal;
        [FieldOffset(0)]
        public IntPtr ppdispVal;
        [FieldOffset(0)]
        public IntPtr pparray;
        [FieldOffset(0)]
        public IntPtr pvarVal;
        [FieldOffset(0)]
        public IntPtr byref;
        [FieldOffset(0)]
        public sbyte cVal;
        [FieldOffset(0)]
        public ushort uiVal;
        [FieldOffset(0)]
        public uint ulVal;
        [FieldOffset(0)]
        public ulong ullVal;
        [FieldOffset(0)]
        public int intVal;
        [FieldOffset(0)]
        public uint uintVal;
        [FieldOffset(0)]
        public IntPtr pdecVal;
        [FieldOffset(0)]
        public IntPtr pcVal;
        [FieldOffset(0)]
        public IntPtr puiVal;
        [FieldOffset(0)]
        public IntPtr pulVal;
        [FieldOffset(0)]
        public IntPtr pullVal;
        [FieldOffset(0)]
        public IntPtr pintVal;
        [FieldOffset(0)]
        public IntPtr puintVal;
       // anonymous struct __param__;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagVARIANT_____anonymous_43 // 1
    {
        public IntPtr pvRecord;
        public IRecordInfo pRecInfo;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct tagVARDESC__anonymous_54 // 1
    {
        [FieldOffset(0)]
        public uint oInst;
        [FieldOffset(0)]
        public IntPtr lpvarValue;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagTYPEATTR // 2
    {
        public Guid guid;
        public uint lcid;
        public uint dwReserved;
        public int memidConstructor;
        public int memidDestructor;
        public IntPtr lpstrSchema;
        public uint cbSizeInstance;
        public tagTYPEKIND typekind;
        public ushort cFuncs;
        public ushort cVars;
        public ushort cImplTypes;
        public ushort cbSizeVft;
        public ushort cbAlignment;
        public ushort wTypeFlags;
        public ushort wMajorVerNum;
        public ushort wMinorVerNum;
        public tagTYPEDESC tdescAlias;
        public tagIDLDESC idldescType;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagTYPEDESC // 2
    {
        public tagTYPEDESC__anonymous_12 __param__1;
        public ushort vt;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagARRAYDESC // 1
    {
        public tagTYPEDESC tdescElem;
        public ushort cDims;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]public tagSAFEARRAYBOUND[] rgbounds;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSAFEARRAYBOUND // 2
    {
        public uint cElements;
        public int lLbound;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagIDLDESC // 2
    {
        public ulong dwReserved;
        public ushort wIDLFlags;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct tagBINDPTR // 2
    {
        [FieldOffset(0)]
        public IntPtr lpfuncdesc;
        [FieldOffset(0)]
        public IntPtr lpvardesc;
        [FieldOffset(0)]
        public ITypeComp lptcomp;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagFUNCDESC // 2
    {
        public int memid;
        public IntPtr lprgscode;
        public IntPtr lprgelemdescParam;
        public tagFUNCKIND funckind;
        public tagINVOKEKIND invkind;
        public tagCALLCONV callconv;
        public short cParams;
        public short cParamsOpt;
        public short oVft;
        public short cScodes;
        public tagELEMDESC elemdescFunc;
        public ushort wFuncFlags;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagELEMDESC // 2
    {
        public tagTYPEDESC tdesc;
        public tagELEMDESC__anonymous_29 __param__2;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagPARAMDESC // 2
    {
        public IntPtr pparamdescex;
        public ushort wParamFlags;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagPARAMDESCEX // 2
    {
        public uint cBytes;
        public tagVARIANT varDefaultValue;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagVARIANT // 0
    {
        public tagVARIANT__anonymous_37 __param__1;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSAFEARRAY // 1
    {
        public ushort cDims;
        public ushort fFeatures;
        public uint cbElements;
        public uint cLocks;
        public IntPtr pvData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]public tagSAFEARRAYBOUND[] rgsabound;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagVARDESC // 2
    {
        public int memid;
        public IntPtr lpstrSchema;
        public tagVARDESC__anonymous_54 __param__3;
        public tagELEMDESC elemdescVar;
        public ushort wVarFlags;
        public tagVARKIND varkind;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagDISPPARAMS // 1
    {
        public IntPtr rgvarg;
        public IntPtr rgdispidNamedArgs;
        public uint cArgs;
        public uint cNamedArgs;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagEXCEPINFO // 3
    {
        public ushort wCode;
        public ushort wReserved;
        public IntPtr bstrSource;
        public IntPtr bstrDescription;
        public IntPtr bstrHelpFile;
        public uint dwHelpContext;
        public IntPtr pvReserved;
        public IntPtr pfnDeferredFillIn;
        public int scode;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagTLIBATTR // 2
    {
        public Guid guid;
        public uint lcid;
        public tagSYSKIND syskind;
        public ushort wMajorVerNum;
        public ushort wMinorVerNum;
        public ushort wLibFlags;
    }
}
