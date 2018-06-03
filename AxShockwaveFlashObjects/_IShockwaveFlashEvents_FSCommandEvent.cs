namespace BDFlashObjects
{
    using System;

    public class _IShockwaveFlashEvents_FSCommandEvent
    {
        public string args;
        public string command;

        public _IShockwaveFlashEvents_FSCommandEvent(string command, string args)
        {
            this.command = command;
            this.args = args;
        }
    }
}

