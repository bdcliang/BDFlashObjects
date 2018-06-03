namespace ShockwaveFlashObjects
{
    using stdole;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, InterfaceType((short) 1), Guid("C5598E60-B307-11D1-B27D-006008C3FBFB")]
    public interface ICanHandleException
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void CanHandleException([In] ref stdole.EXCEPINFO pExcepInfo, [In, MarshalAs(UnmanagedType.Struct)] ref object pvar);
    }
}

