namespace ShockwaveFlashObjects
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, TypeLibType((short) 0x1010), InterfaceType((short) 2), Guid("D27CDB6D-AE6D-11CF-96B8-444553540000")]
    public interface _IShockwaveFlashEvents
    {
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(-609)]
        void OnReadyStateChange(int newState);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7a6)]
        void OnProgress(int percentDone);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(150)]
        void FSCommand([In, MarshalAs(UnmanagedType.BStr)] string command, [In, MarshalAs(UnmanagedType.BStr)] string args);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc5)]
        void FlashCall([In, MarshalAs(UnmanagedType.BStr)] string request);
    }
}

