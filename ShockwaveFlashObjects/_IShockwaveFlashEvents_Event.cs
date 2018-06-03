namespace ShockwaveFlashObjects
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComEventInterface(typeof(_IShockwaveFlashEvents), typeof(_IShockwaveFlashEvents_EventProvider)), TypeLibType((short) 0x10), ComVisible(false)]
    public interface _IShockwaveFlashEvents_Event
    {
        event _IShockwaveFlashEvents_FlashCallEventHandler FlashCall;

        event _IShockwaveFlashEvents_FSCommandEventHandler FSCommand;

        event _IShockwaveFlashEvents_OnProgressEventHandler OnProgress;

        event _IShockwaveFlashEvents_OnReadyStateChangeEventHandler OnReadyStateChange;
    }
}

