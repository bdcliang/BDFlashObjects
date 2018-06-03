namespace ShockwaveFlashObjects
{
    using System.Runtime.InteropServices;

    [ComImport, CoClass(typeof(ShockwaveFlashClass)), Guid("D27CDB6C-AE6D-11CF-96B8-444553540000")]
    public interface ShockwaveFlash : IShockwaveFlash, _IShockwaveFlashEvents_Event
    {
    }
}

