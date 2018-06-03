﻿namespace ShockwaveFlashObjects
{
    using stdole;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, TypeLibType((short) 2), ClassInterface((short) 0), Guid("D27CDB71-AE6D-11CF-96B8-444553540000")]
    public class FlashObjectInterfaceClass : IFlashObjectInterface, FlashObjectInterface
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void DeleteMemberByDispID([In] int id);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void DeleteMemberByName([In, MarshalAs(UnmanagedType.BStr)] string bstrName, [In] uint grfdex);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void GetDispID([In, MarshalAs(UnmanagedType.BStr)] string bstrName, [In] uint grfdex, out int pid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void GetMemberName([In] int id, [MarshalAs(UnmanagedType.BStr)] out string pbstrName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void GetMemberProperties([In] int id, [In] uint grfdexFetch, out uint pgrfdex);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void GetNameSpaceParent([MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void GetNextDispID([In] uint grfdex, [In] int id, out int pid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void RemoteInvokeEx([In] int id, [In] uint lcid, [In] uint dwFlags, [In] ref stdole.DISPPARAMS pdp, [MarshalAs(UnmanagedType.Struct)] out object pvarRes, out stdole.EXCEPINFO pei, [In, MarshalAs(UnmanagedType.Interface)] ShockwaveFlashObjects.IServiceProvider pspCaller, [In] uint cvarRefArg, [In] ref uint rgiRefArg, [In, Out, MarshalAs(UnmanagedType.Struct)] ref object rgvarRefArg);
    }
}

