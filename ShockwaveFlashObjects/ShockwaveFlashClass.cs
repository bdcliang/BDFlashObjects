namespace ShockwaveFlashObjects
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("D27CDB6E-AE6D-11CF-96B8-444553540000"), ClassInterface((short) 0), ComSourceInterfaces("ShockwaveFlashObjects._IShockwaveFlashEvents\0"), TypeLibType((short) 2)]
    public class ShockwaveFlashClass : IShockwaveFlash, ShockwaveFlash, _IShockwaveFlashEvents_Event
    {
        public extern event _IShockwaveFlashEvents_FlashCallEventHandler FlashCall;

        public extern event _IShockwaveFlashEvents_FSCommandEventHandler FSCommand;

        public extern event _IShockwaveFlashEvents_OnProgressEventHandler OnProgress;

        public extern event _IShockwaveFlashEvents_OnReadyStateChangeEventHandler OnReadyStateChange;

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x72)]
        public extern void Back();
        [return: MarshalAs(UnmanagedType.BStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc6)]
        public extern string CallFunction([In, MarshalAs(UnmanagedType.BStr)] string request);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x80)]
        public extern int CurrentFrame();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(200)]
        public extern void DisableLocalSecurity();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc1)]
        public extern void EnforceLocalSecurity();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x84)]
        public extern int FlashVersion();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x73)]
        public extern void Forward();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x83)]
        public extern bool FrameLoaded([In] int FrameNum);
        [return: MarshalAs(UnmanagedType.BStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x98)]
        public extern string GetVariable([In, MarshalAs(UnmanagedType.BStr)] string name);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7f)]
        public extern void GotoFrame([In] int FrameNum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x81)]
        public extern bool IsPlaying();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8e)]
        public extern void LoadMovie([In] int layer, [In, MarshalAs(UnmanagedType.BStr)] string url);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x77)]
        public extern void Pan([In] int x, [In] int y, [In] int mode);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(130)]
        public extern int PercentLoaded();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x70)]
        public extern void Play();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x74)]
        public extern void Rewind();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc7)]
        public extern void SetReturnValue([In, MarshalAs(UnmanagedType.BStr)] string returnValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x97)]
        public extern void SetVariable([In, MarshalAs(UnmanagedType.BStr)] string name, [In, MarshalAs(UnmanagedType.BStr)] string value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x6d)]
        public extern void SetZoomRect([In] int left, [In] int top, [In] int right, [In] int bottom);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x71)]
        public extern void Stop();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7e)]
        public extern void StopPlay();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x9b)]
        public extern void TCallFrame([In, MarshalAs(UnmanagedType.BStr)] string target, [In] int FrameNum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x9c)]
        public extern void TCallLabel([In, MarshalAs(UnmanagedType.BStr)] string target, [In, MarshalAs(UnmanagedType.BStr)] string label);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x91)]
        public extern int TCurrentFrame([In, MarshalAs(UnmanagedType.BStr)] string target);
        [return: MarshalAs(UnmanagedType.BStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x92)]
        public extern string TCurrentLabel([In, MarshalAs(UnmanagedType.BStr)] string target);
        [return: MarshalAs(UnmanagedType.BStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x9a)]
        public extern string TGetProperty([In, MarshalAs(UnmanagedType.BStr)] string target, [In] int property);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xac)]
        public extern double TGetPropertyAsNumber([In, MarshalAs(UnmanagedType.BStr)] string target, [In] int property);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x9e)]
        public extern double TGetPropertyNum([In, MarshalAs(UnmanagedType.BStr)] string target, [In] int property);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8f)]
        public extern void TGotoFrame([In, MarshalAs(UnmanagedType.BStr)] string target, [In] int FrameNum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x90)]
        public extern void TGotoLabel([In, MarshalAs(UnmanagedType.BStr)] string target, [In, MarshalAs(UnmanagedType.BStr)] string label);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x93)]
        public extern void TPlay([In, MarshalAs(UnmanagedType.BStr)] string target);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x99)]
        public extern void TSetProperty([In, MarshalAs(UnmanagedType.BStr)] string target, [In] int property, [In, MarshalAs(UnmanagedType.BStr)] string value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x9d)]
        public extern void TSetPropertyNum([In, MarshalAs(UnmanagedType.BStr)] string target, [In] int property, [In] double value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x94)]
        public extern void TStopPlay([In, MarshalAs(UnmanagedType.BStr)] string target);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x76)]
        public extern  void Zoom([In] int factor);

        [DispId(0x79)]
        extern int AlignMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x79)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x79)] set; }

        [DispId(0xca)]
        extern string AllowFullScreen { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xca)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xca)] set; }

        [DispId(0xc9)]
        extern string AllowNetworking { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc9)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc9)] set; }

        [DispId(0xab)]
        extern string AllowScriptAccess { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xab)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xab)] set; }

        [DispId(0x7b)]
        extern int BackgroundColor { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7b)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7b)] set; }

        [DispId(0x88)]
        extern string Base { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x88)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x88)] set; }

        [DispId(140)]
        extern string BGColor { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(140)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(140)] set; }

        [DispId(0x8a)]
        extern bool DeviceFont { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8a)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8a)] set; }

        [DispId(0x8b)]
        extern bool EmbedMovie { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8b)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8b)] set; }

        [DispId(170)]
        extern string FlashVars { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(170)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(170)] set; }

        [DispId(0x6b)]
        extern int FrameNum { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x6b)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x6b)] set; }

        [DispId(0xbf)]
        extern object InlineData { [return: MarshalAs(UnmanagedType.IUnknown)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xbf)] get; [param: In, MarshalAs(UnmanagedType.IUnknown)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xbf)] set; }

        [DispId(0x6a)]
        extern bool Loop { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x6a)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x6a)] set; }

        [DispId(0x87)]
        extern bool Menu { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x87)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x87)] set; }

        [DispId(0x66)]
        extern string Movie { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x66)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x66)] set; }

        [DispId(190)]
        extern string MovieData { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(190)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(190)] set; }

        [DispId(0x7d)]
        extern bool Playing { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7d)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7d)] set; }

        [DispId(0xc2)]
        extern bool Profile { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc2)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc2)] set; }

        [DispId(0xc3)]
        extern string ProfileAddress { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc3)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc3)] set; }

        [DispId(0xc4)]
        extern int ProfilePort { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc4)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc4)] set; }

        [DispId(0x69)]
        extern int Quality { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x69)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x69)] set; }

        [DispId(0x8d)]
        extern string Quality2 { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8d)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8d)] set; }

        [DispId(-525)]
        extern int ReadyState { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(-525)] get; }

        [DispId(0x86)]
        extern string SAlign { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x86)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x86)] set; }

        [DispId(0x89)]
        extern string Scale { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x89)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x89)] set; }

        [DispId(120)]
        extern int ScaleMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(120)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(120)] set; }

        [DispId(0xc0)]
        extern bool SeamlessTabbing { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc0)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc0)] set; }

        [DispId(0x79)]
        extern  int ShockwaveFlashObjects.IShockwaveFlash.AlignMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x79)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x79)] set; }

        [DispId(0xca)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.AllowFullScreen { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xca)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xca)] set; }

        [DispId(0xc9)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.AllowNetworking { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc9)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc9)] set; }

        [DispId(0xab)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.AllowScriptAccess { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xab)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xab)] set; }

        [DispId(0x7b)]
        extern int ShockwaveFlashObjects.IShockwaveFlash.BackgroundColor { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7b)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7b)] set; }

        [DispId(0x88)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.Base { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x88)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x88)] set; }

        [DispId(140)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.BGColor { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(140)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(140)] set; }

        [DispId(0x8a)]
        extern bool ShockwaveFlashObjects.IShockwaveFlash.DeviceFont { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8a)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8a)] set; }

        [DispId(0x8b)]
        extern bool ShockwaveFlashObjects.IShockwaveFlash.EmbedMovie { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8b)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8b)] set; }

        [DispId(170)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.FlashVars { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(170)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(170)] set; }

        [DispId(0x6b)]
        extern int ShockwaveFlashObjects.IShockwaveFlash.FrameNum { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x6b)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x6b)] set; }

        [DispId(0xbf)]
        extern object ShockwaveFlashObjects.IShockwaveFlash.InlineData { [return: MarshalAs(UnmanagedType.IUnknown)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xbf)] get; [param: In, MarshalAs(UnmanagedType.IUnknown)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xbf)] set; }

        [DispId(0x6a)]
        extern bool ShockwaveFlashObjects.IShockwaveFlash.Loop { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x6a)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x6a)] set; }

        [DispId(0x87)]
        extern bool ShockwaveFlashObjects.IShockwaveFlash.Menu { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x87)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x87)] set; }

        [DispId(0x66)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.Movie { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x66)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x66)] set; }

        [DispId(190)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.MovieData { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(190)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(190)] set; }

        [DispId(0x7d)]
        extern bool ShockwaveFlashObjects.IShockwaveFlash.Playing { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7d)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7d)] set; }

        [DispId(0xc2)]
        extern bool ShockwaveFlashObjects.IShockwaveFlash.Profile { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc2)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc2)] set; }

        [DispId(0xc3)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.ProfileAddress { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc3)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc3)] set; }

        [DispId(0xc4)]
        extern int ShockwaveFlashObjects.IShockwaveFlash.ProfilePort { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc4)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc4)] set; }

        [DispId(0x69)]
        extern int ShockwaveFlashObjects.IShockwaveFlash.Quality { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x69)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x69)] set; }

        [DispId(0x8d)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.Quality2 { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8d)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x8d)] set; }

        [DispId(-525)]
        extern int ShockwaveFlashObjects.IShockwaveFlash.ReadyState { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(-525)] get; }

        [DispId(0x86)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.SAlign { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x86)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x86)] set; }

        [DispId(0x89)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.Scale { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x89)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x89)] set; }

        [DispId(120)]
        extern int ShockwaveFlashObjects.IShockwaveFlash.ScaleMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(120)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(120)] set; }

        [DispId(0xc0)]
        extern bool ShockwaveFlashObjects.IShockwaveFlash.SeamlessTabbing { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc0)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0xc0)] set; }

        [DispId(0x9f)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.SWRemote { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x9f)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x9f)] set; }

        [DispId(0x7c)]
        extern int ShockwaveFlashObjects.IShockwaveFlash.TotalFrames { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7c)] get; }

        [DispId(0x85)]
        extern string ShockwaveFlashObjects.IShockwaveFlash.WMode { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x85)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x85)] set; }

        [DispId(0x9f)]
        extern string SWRemote { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x9f)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x9f)] set; }

        [DispId(0x7c)]
        extern int TotalFrames { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x7c)] get; }

        [DispId(0x85)]
        extern string WMode { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x85)] get; [param: In, MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x85)] set; }
    }
}

