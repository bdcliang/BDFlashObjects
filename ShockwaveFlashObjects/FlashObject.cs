namespace ShockwaveFlashObjects
{
    using System.Runtime.InteropServices;

    [ComImport, Guid("86230738-D762-4C50-A2DE-A753E5B1686F"), CoClass(typeof(FlashObjectClass))]
    public interface FlashObject : IFlashObject
    {
    }
}

