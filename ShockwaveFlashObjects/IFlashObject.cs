namespace ShockwaveFlashObjects
{
    using stdole;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, TypeLibType((short) 0x10c0), Guid("86230738-D762-4C50-A2DE-A753E5B1686F")]
    public interface IFlashObject : IDispatchEx
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020000)]
        void GetDispID([In, MarshalAs(UnmanagedType.BStr)] string bstrName, [In] uint grfdex, out int pid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020001)]
        void RemoteInvokeEx([In] int id, [In] uint lcid, [In] uint dwFlags, [In] ref stdole.DISPPARAMS pdp, [MarshalAs(UnmanagedType.Struct)] out object pvarRes, out stdole.EXCEPINFO pei, [In, MarshalAs(UnmanagedType.Interface)] ShockwaveFlashObjects.IServiceProvider pspCaller, [In] uint cvarRefArg, [In] ref uint rgiRefArg, [In, Out, MarshalAs(UnmanagedType.Struct)] ref object rgvarRefArg);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020002)]
        void DeleteMemberByName([In, MarshalAs(UnmanagedType.BStr)] string bstrName, [In] uint grfdex);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020003)]
        void DeleteMemberByDispID([In] int id);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020004)]
        void GetMemberProperties([In] int id, [In] uint grfdexFetch, out uint pgrfdex);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020005)]
        void GetMemberName([In] int id, [MarshalAs(UnmanagedType.BStr)] out string pbstrName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020006)]
        void GetNextDispID([In] uint grfdex, [In] int id, out int pid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x60020007)]
        void GetNameSpaceParent([MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
    }
}

