using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WindowsKits
{
    public abstract class IUnknownImpl : IDisposable
    {
        readonly int m_vTableBaseIndex = 3;
        protected IUnknownImpl()
        {
            for (var t = GetType().BaseType; t != typeof(IUnknownImpl); t = t.BaseType)
            {
                var prop = t.GetProperty("MethodCount", BindingFlags.Static | BindingFlags.NonPublic);
                m_vTableBaseIndex += (int)prop.GetValue(null);
            }
        }

        IntPtr m_ptr;

        protected IntPtr Self => m_ptr;
        public int RefCount
        {
            get
            {
                if (m_ptr == IntPtr.Zero)
                {
                    throw new InvalidOperationException();
                }
                Marshal.AddRef(m_ptr);
                return Marshal.Release(m_ptr);
            }
        }

        public ref IntPtr PtrForNew
        {
            get
            {
                if (m_ptr != IntPtr.Zero)
                {
                    Marshal.Release(m_ptr);
                }
                return ref m_ptr;
            }
        }

        public /*readonly*/ ref IntPtr Ptr => ref m_ptr;

        public static implicit operator bool(IUnknownImpl i)
        {
            return i.m_ptr != IntPtr.Zero;
        }

        protected IntPtr VTable => Marshal.ReadIntPtr(m_ptr);

        static readonly int IntPtrSize = Marshal.SizeOf(typeof(IntPtr));

        protected IntPtr GetFunctionPointer(int index)
        {
            return Marshal.ReadIntPtr(VTable, (m_vTableBaseIndex + index) * IntPtrSize);
        }

        abstract public ref /*readonly*/ Guid IID { get; }

        Int32 QueryInterface(
        ref Guid iid
        , ref IntPtr ppvObject
        )
        {
            var fp = GetFunctionPointer(0);
            var callback = (QueryInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryInterfaceFunc));
            return callback(Self, ref iid, ref ppvObject);
        }
        delegate Int32 QueryInterfaceFunc(IntPtr self, ref Guid iid, ref IntPtr ppvObject);

        public int QueryInterface<T>(T t) where T : IUnknownImpl
        {
            var hr = QueryInterface(ref t.IID, ref t.PtrForNew);
            if (hr != 0)
            {
                return hr;
            }
            return hr;
        }

        #region IDisposable Support
        private bool disposedValue = false; // 重複する呼び出しを検出するには

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: マネージ状態を破棄します (マネージ オブジェクト)。
                }

                // TODO: アンマネージ リソース (アンマネージ オブジェクト) を解放し、下のファイナライザーをオーバーライドします。
                // TODO: 大きなフィールドを null に設定します。
                if (m_ptr != IntPtr.Zero)
                {
                    Marshal.Release(m_ptr);
                    m_ptr = IntPtr.Zero;
                }

                disposedValue = true;
            }
        }

        ~IUnknownImpl()
        {
            // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
            Dispose(false);
        }

        // このコードは、破棄可能なパターンを正しく実装できるように追加されました。
        public void Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
            Dispose(true);
            // TODO: 上のファイナライザーがオーバーライドされる場合は、次の行のコメントを解除してください。
            // GC.SuppressFinalize(this);
        }
        #endregion
    }


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SECURITY_ATTRIBUTES
    {
        public UInt32 nLength;
        public IntPtr lpSecurityDescriptor;
        public Int32 bInheritHandle;
    }
}
