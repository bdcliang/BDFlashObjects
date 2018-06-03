namespace ShockwaveFlashObjects
{
    using stdole;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("E0920E11-6B65-4D5D-9C58-B1FC5C07DC43"), ClassInterface((short) 0), TypeLibType((short) 2)]
    public class FlashObjectClass : IFlashObject, FlashObject
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020003)]
        public virtual extern void DeleteMemberByDispID([In] int id);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020002)]
        public virtual extern void DeleteMemberByName([In, MarshalAs(UnmanagedType.BStr)] string bstrName, [In] uint grfdex);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020000)]
        public virtual extern void GetDispID([In, MarshalAs(UnmanagedType.BStr)] string bstrName, [In] uint grfdex, out int pid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020005)]
        public virtual extern void GetMemberName([In] int id, [MarshalAs(UnmanagedType.BStr)] out string pbstrName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020004)]
        public virtual extern void GetMemberProperties([In] int id, [In] uint grfdexFetch, out uint pgrfdex);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020007)]
        public virtual extern void GetNameSpaceParent([MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020006)]
        public virtual extern void GetNextDispID([In] uint grfdex, [In] int id, out int pid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020001)]
        public virtual extern void RemoteInvokeEx([In] int id, [In] uint lcid, [In] uint dwFlags, [In] ref stdole.DISPPARAMS pdp, [MarshalAs(UnmanagedType.Struct)] out object pvarRes, out stdole.EXCEPINFO pei, [In, MarshalAs(UnmanagedType.Interface)] ShockwaveFlashObjects.IServiceProvider pspCaller, [In] uint cvarRefArg, [In] ref uint rgiRefArg, [In, Out, MarshalAs(UnmanagedType.Struct)] ref object rgvarRefArg);
    }
}

