// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IStream: ISequentialStream
    {
        static Guid s_uuid = new Guid("0000000c-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int Seek(
            _LARGE_INTEGER dlibMove,
            uint dwOrigin,
            out _ULARGE_INTEGER plibNewPosition
        ){
            var fp = GetFunctionPointer(5);
            var callback = (SeekFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SeekFunc));
            
            return callback(m_ptr, dlibMove, dwOrigin, out plibNewPosition);
        }
        delegate int SeekFunc(IntPtr self, _LARGE_INTEGER dlibMove, uint dwOrigin, out _ULARGE_INTEGER plibNewPosition);

        public virtual int SetSize(
            _ULARGE_INTEGER libNewSize
        ){
            var fp = GetFunctionPointer(6);
            var callback = (SetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetSizeFunc));
            
            return callback(m_ptr, libNewSize);
        }
        delegate int SetSizeFunc(IntPtr self, _ULARGE_INTEGER libNewSize);

        public virtual int CopyTo(
            IStream pstm,
            _ULARGE_INTEGER cb,
            out _ULARGE_INTEGER pcbRead,
            out _ULARGE_INTEGER pcbWritten
        ){
            var fp = GetFunctionPointer(7);
            var callback = (CopyToFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyToFunc));
            
            return callback(m_ptr, pstm!=null ? pstm.Ptr : IntPtr.Zero, cb, out pcbRead, out pcbWritten);
        }
        delegate int CopyToFunc(IntPtr self, IntPtr pstm, _ULARGE_INTEGER cb, out _ULARGE_INTEGER pcbRead, out _ULARGE_INTEGER pcbWritten);

        public virtual int Commit(
            uint grfCommitFlags
        ){
            var fp = GetFunctionPointer(8);
            var callback = (CommitFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CommitFunc));
            
            return callback(m_ptr, grfCommitFlags);
        }
        delegate int CommitFunc(IntPtr self, uint grfCommitFlags);

        public virtual int Revert(
        ){
            var fp = GetFunctionPointer(9);
            var callback = (RevertFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RevertFunc));
            
            return callback(m_ptr);
        }
        delegate int RevertFunc(IntPtr self);

        public virtual int LockRegion(
            _ULARGE_INTEGER libOffset,
            _ULARGE_INTEGER cb,
            uint dwLockType
        ){
            var fp = GetFunctionPointer(10);
            var callback = (LockRegionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LockRegionFunc));
            
            return callback(m_ptr, libOffset, cb, dwLockType);
        }
        delegate int LockRegionFunc(IntPtr self, _ULARGE_INTEGER libOffset, _ULARGE_INTEGER cb, uint dwLockType);

        public virtual int UnlockRegion(
            _ULARGE_INTEGER libOffset,
            _ULARGE_INTEGER cb,
            uint dwLockType
        ){
            var fp = GetFunctionPointer(11);
            var callback = (UnlockRegionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnlockRegionFunc));
            
            return callback(m_ptr, libOffset, cb, dwLockType);
        }
        delegate int UnlockRegionFunc(IntPtr self, _ULARGE_INTEGER libOffset, _ULARGE_INTEGER cb, uint dwLockType);

        public virtual int Stat(
            out tagSTATSTG pstatstg,
            uint grfStatFlag
        ){
            var fp = GetFunctionPointer(12);
            var callback = (StatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StatFunc));
            
            return callback(m_ptr, out pstatstg, grfStatFlag);
        }
        delegate int StatFunc(IntPtr self, out tagSTATSTG pstatstg, uint grfStatFlag);

        public virtual int Clone(
            out IStream ppstm
        ){
            var fp = GetFunctionPointer(13);
            var callback = (CloneFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloneFunc));
            ppstm = new IStream();
            return callback(m_ptr, out ppstm.PtrForNew);
        }
        delegate int CloneFunc(IntPtr self, out IntPtr ppstm);

    }
    public class ISequentialStream: IUnknown
    {
        static Guid s_uuid = new Guid("0c733a30-2a1c-11ce-ade5-00aa0044773d");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int Read(
            IntPtr pv,
            uint cb,
            out uint pcbRead
        ){
            var fp = GetFunctionPointer(3);
            var callback = (ReadFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReadFunc));
            
            return callback(m_ptr, pv, cb, out pcbRead);
        }
        delegate int ReadFunc(IntPtr self, IntPtr pv, uint cb, out uint pcbRead);

        public virtual int Write(
            IntPtr pv,
            uint cb,
            out uint pcbWritten
        ){
            var fp = GetFunctionPointer(4);
            var callback = (WriteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WriteFunc));
            
            return callback(m_ptr, pv, cb, out pcbWritten);
        }
        delegate int WriteFunc(IntPtr self, IntPtr pv, uint cb, out uint pcbWritten);

    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSTATSTG // 1
    {
        public IntPtr pwcsName;
        public uint type;
        public _ULARGE_INTEGER cbSize;
        public _FILETIME mtime;
        public _FILETIME ctime;
        public _FILETIME atime;
        public uint grfMode;
        public uint grfLocksSupported;
        public Guid clsid;
        public uint grfStateBits;
        public uint reserved;
    }
    public class IEnumString: IUnknown
    {
        static Guid s_uuid = new Guid("00000101-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int Next(
            uint celt,
            out IntPtr rgelt,
            out uint pceltFetched
        ){
            var fp = GetFunctionPointer(3);
            var callback = (NextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(NextFunc));
            
            return callback(m_ptr, celt, out rgelt, out pceltFetched);
        }
        delegate int NextFunc(IntPtr self, uint celt, out IntPtr rgelt, out uint pceltFetched);

        public virtual int Skip(
            uint celt
        ){
            var fp = GetFunctionPointer(4);
            var callback = (SkipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SkipFunc));
            
            return callback(m_ptr, celt);
        }
        delegate int SkipFunc(IntPtr self, uint celt);

        public virtual int Reset(
        ){
            var fp = GetFunctionPointer(5);
            var callback = (ResetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResetFunc));
            
            return callback(m_ptr);
        }
        delegate int ResetFunc(IntPtr self);

        public virtual int Clone(
            out IEnumString ppenum
        ){
            var fp = GetFunctionPointer(6);
            var callback = (CloneFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloneFunc));
            ppenum = new IEnumString();
            return callback(m_ptr, out ppenum.PtrForNew);
        }
        delegate int CloneFunc(IntPtr self, out IntPtr ppenum);

    }
    public class IEnumUnknown: IUnknown
    {
        static Guid s_uuid = new Guid("00000100-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int Next(
            uint celt,
            out IntPtr rgelt,
            out uint pceltFetched
        ){
            var fp = GetFunctionPointer(3);
            var callback = (NextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(NextFunc));
            
            return callback(m_ptr, celt, out rgelt, out pceltFetched);
        }
        delegate int NextFunc(IntPtr self, uint celt, out IntPtr rgelt, out uint pceltFetched);

        public virtual int Skip(
            uint celt
        ){
            var fp = GetFunctionPointer(4);
            var callback = (SkipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SkipFunc));
            
            return callback(m_ptr, celt);
        }
        delegate int SkipFunc(IntPtr self, uint celt);

        public virtual int Reset(
        ){
            var fp = GetFunctionPointer(5);
            var callback = (ResetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResetFunc));
            
            return callback(m_ptr);
        }
        delegate int ResetFunc(IntPtr self);

        public virtual int Clone(
            out IEnumUnknown ppenum
        ){
            var fp = GetFunctionPointer(6);
            var callback = (CloneFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloneFunc));
            ppenum = new IEnumUnknown();
            return callback(m_ptr, out ppenum.PtrForNew);
        }
        delegate int CloneFunc(IntPtr self, out IntPtr ppenum);

    }
    public class IRpcStubBuffer: IUnknown
    {
        static Guid s_uuid = new Guid("d5f56afc-593b-101a-b569-08002b2dbf7a");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int Connect(
            IUnknown pUnkServer
        ){
            var fp = GetFunctionPointer(3);
            var callback = (ConnectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ConnectFunc));
            
            return callback(m_ptr, pUnkServer!=null ? pUnkServer.Ptr : IntPtr.Zero);
        }
        delegate int ConnectFunc(IntPtr self, IntPtr pUnkServer);

        public virtual void Disconnect(
        ){
            var fp = GetFunctionPointer(4);
            var callback = (DisconnectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DisconnectFunc));
            
            callback(m_ptr);
        }
        delegate void DisconnectFunc(IntPtr self);

        public virtual int Invoke(
            out tagRPCOLEMESSAGE _prpcmsg,
            IRpcChannelBuffer _pRpcChannelBuffer
        ){
            var fp = GetFunctionPointer(5);
            var callback = (InvokeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InvokeFunc));
            
            return callback(m_ptr, out _prpcmsg, _pRpcChannelBuffer!=null ? _pRpcChannelBuffer.Ptr : IntPtr.Zero);
        }
        delegate int InvokeFunc(IntPtr self, out tagRPCOLEMESSAGE _prpcmsg, IntPtr _pRpcChannelBuffer);

        public virtual IRpcStubBuffer IsIIDSupported(
            ref Guid riid
        ){
            var fp = GetFunctionPointer(6);
            var callback = (IsIIDSupportedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsIIDSupportedFunc));
            
            return callback(m_ptr, ref riid);
        }
        delegate IRpcStubBuffer IsIIDSupportedFunc(IntPtr self, ref Guid riid);

        public virtual uint CountRefs(
        ){
            var fp = GetFunctionPointer(7);
            var callback = (CountRefsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CountRefsFunc));
            
            return callback(m_ptr);
        }
        delegate uint CountRefsFunc(IntPtr self);

        public virtual int DebugServerQueryInterface(
            out IntPtr ppv
        ){
            var fp = GetFunctionPointer(8);
            var callback = (DebugServerQueryInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DebugServerQueryInterfaceFunc));
            
            return callback(m_ptr, out ppv);
        }
        delegate int DebugServerQueryInterfaceFunc(IntPtr self, out IntPtr ppv);

        public virtual void DebugServerRelease(
            IntPtr pv
        ){
            var fp = GetFunctionPointer(9);
            var callback = (DebugServerReleaseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DebugServerReleaseFunc));
            
            callback(m_ptr, pv);
        }
        delegate void DebugServerReleaseFunc(IntPtr self, IntPtr pv);

    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagRPCOLEMESSAGE // 1
    {
        public IntPtr reserved1;
        public uint dataRepresentation;
        public IntPtr Buffer;
        public uint cbBuffer;
        public uint iMethod;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]public IntPtr[] reserved2;
        public uint rpcFlags;
    }
    public class IRpcChannelBuffer: IUnknown
    {
        static Guid s_uuid = new Guid("d5f56b60-593b-101a-b569-08002b2dbf7a");
        public static new ref Guid IID => ref s_uuid;
                
        public virtual int GetBuffer(
            out tagRPCOLEMESSAGE pMessage,
            ref Guid riid
        ){
            var fp = GetFunctionPointer(3);
            var callback = (GetBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferFunc));
            
            return callback(m_ptr, out pMessage, ref riid);
        }
        delegate int GetBufferFunc(IntPtr self, out tagRPCOLEMESSAGE pMessage, ref Guid riid);

        public virtual int SendReceive(
            out tagRPCOLEMESSAGE pMessage,
            out uint pStatus
        ){
            var fp = GetFunctionPointer(4);
            var callback = (SendReceiveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SendReceiveFunc));
            
            return callback(m_ptr, out pMessage, out pStatus);
        }
        delegate int SendReceiveFunc(IntPtr self, out tagRPCOLEMESSAGE pMessage, out uint pStatus);

        public virtual int FreeBuffer(
            out tagRPCOLEMESSAGE pMessage
        ){
            var fp = GetFunctionPointer(5);
            var callback = (FreeBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FreeBufferFunc));
            
            return callback(m_ptr, out pMessage);
        }
        delegate int FreeBufferFunc(IntPtr self, out tagRPCOLEMESSAGE pMessage);

        public virtual int GetDestCtx(
            out uint pdwDestContext,
            out IntPtr ppvDestContext
        ){
            var fp = GetFunctionPointer(6);
            var callback = (GetDestCtxFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDestCtxFunc));
            
            return callback(m_ptr, out pdwDestContext, out ppvDestContext);
        }
        delegate int GetDestCtxFunc(IntPtr self, out uint pdwDestContext, out IntPtr ppvDestContext);

        public virtual int IsConnected(
        ){
            var fp = GetFunctionPointer(7);
            var callback = (IsConnectedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsConnectedFunc));
            
            return callback(m_ptr);
        }
        delegate int IsConnectedFunc(IntPtr self);

    }
}