﻿using System.Runtime.InteropServices;


namespace ComPtrCS
{
    public static class Winmm
    {
        const string DLLNAME = "Winmm.dll";

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/timeapi/nf-timeapi-timegettime
        /// </summary>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode, EntryPoint = "timeGetTime")]
        public static extern uint TimeGetTime();
    }
}
