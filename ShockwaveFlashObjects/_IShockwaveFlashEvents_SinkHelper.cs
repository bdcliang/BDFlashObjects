namespace ShockwaveFlashObjects
{
    using System;
    using System.Runtime.InteropServices;

    [TypeLibType(TypeLibTypeFlags.FHidden), ClassInterface(ClassInterfaceType.None)]
    public sealed class _IShockwaveFlashEvents_SinkHelper : _IShockwaveFlashEvents
    {
        public int m_dwCookie = 0;
        public _IShockwaveFlashEvents_FlashCallEventHandler m_FlashCallDelegate = null;
        public _IShockwaveFlashEvents_FSCommandEventHandler m_FSCommandDelegate = null;
        public _IShockwaveFlashEvents_OnProgressEventHandler m_OnProgressDelegate = null;
        public _IShockwaveFlashEvents_OnReadyStateChangeEventHandler m_OnReadyStateChangeDelegate = null;

        internal _IShockwaveFlashEvents_SinkHelper()
        {
        }

        public  void FlashCall(string text1)
        {
            if (this.m_FlashCallDelegate != null)
            {
                this.m_FlashCallDelegate(text1);
            }
        }

        public  void FSCommand(string text1, string text2)
        {
            if (this.m_FSCommandDelegate != null)
            {
                this.m_FSCommandDelegate(text1, text2);
            }
        }

        public  void OnProgress(int num1)
        {
            if (this.m_OnProgressDelegate != null)
            {
                this.m_OnProgressDelegate(num1);
            }
        }

        public  void OnReadyStateChange(int num1)
        {
            if (this.m_OnReadyStateChangeDelegate != null)
            {
                this.m_OnReadyStateChangeDelegate(num1);
            }
        }
    }
}

