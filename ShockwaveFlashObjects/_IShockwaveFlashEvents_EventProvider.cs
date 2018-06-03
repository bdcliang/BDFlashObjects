namespace ShockwaveFlashObjects
{
    using System;
    using System.Collections;
    using System.Runtime.InteropServices;
    using System.Runtime.InteropServices.ComTypes;
    using System.Threading;

    internal sealed class _IShockwaveFlashEvents_EventProvider : _IShockwaveFlashEvents_Event, IDisposable
    {
        private ArrayList m_aEventSinkHelpers;
        private IConnectionPoint m_ConnectionPoint;
        private IConnectionPointContainer m_ConnectionPointContainer;

        public event _IShockwaveFlashEvents_FlashCallEventHandler FlashCall
        {
            add
            {
                lock (this)
                {
                    if (this.m_ConnectionPoint == null)
                    {
                        this.Init();
                    }
                    _IShockwaveFlashEvents_SinkHelper helper = new _IShockwaveFlashEvents_SinkHelper();
                    int pdwCookie = 0;
                    this.m_ConnectionPoint.Advise((object)helper, out pdwCookie);
                    helper.m_dwCookie = pdwCookie;
                    helper.m_FlashCallDelegate = value;
                    this.m_aEventSinkHelpers.Add((object)helper);
                }
            }
            remove
            {
                lock (this)
                {
                    if (this.m_aEventSinkHelpers != null)
                    {
                        int count = this.m_aEventSinkHelpers.Count;
                        int index = 0;
                        if (0 < count)
                        {
                            do
                            {
                                _IShockwaveFlashEvents_SinkHelper helper = (_IShockwaveFlashEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                                if ((helper.m_FlashCallDelegate != null) && (helper.m_FlashCallDelegate.Equals((object)value)))
                                {
                                    this.m_aEventSinkHelpers.RemoveAt(index);
                                    this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                                    if (count <= 1)
                                    {
                                        Marshal.ReleaseComObject(this.m_ConnectionPoint);
                                        this.m_ConnectionPoint = null;
                                        this.m_aEventSinkHelpers = null;
                                    }
                                    break;
                                }
                                index++;
                            }
                            while (index < count);
                        }
                    }
                }
            }
        }
        public event _IShockwaveFlashEvents_FSCommandEventHandler FSCommand
        {
            add
            {
                lock (this)
                {
                    if (this.m_ConnectionPoint == null)
                    {
                        this.Init();
                    }
                    _IShockwaveFlashEvents_SinkHelper helper = new _IShockwaveFlashEvents_SinkHelper();
                    int pdwCookie = 0;
                    this.m_ConnectionPoint.Advise((object)helper, out pdwCookie);
                    helper.m_dwCookie = pdwCookie;
                    helper.m_FSCommandDelegate = value;
                    this.m_aEventSinkHelpers.Add((object)helper);
                }
            }
            remove
            {
                lock (this)
                {
                    if (this.m_aEventSinkHelpers != null)
                    {
                        int count = this.m_aEventSinkHelpers.Count;
                        int index = 0;
                        if (0 < count)
                        {
                            do
                            {
                                _IShockwaveFlashEvents_SinkHelper helper = (_IShockwaveFlashEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                                if ((helper.m_FSCommandDelegate != null) && (helper.m_FSCommandDelegate.Equals((object)value)))
                                {
                                    this.m_aEventSinkHelpers.RemoveAt(index);
                                    this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                                    if (count <= 1)
                                    {
                                        Marshal.ReleaseComObject(this.m_ConnectionPoint);
                                        this.m_ConnectionPoint = null;
                                        this.m_aEventSinkHelpers = null;
                                    }
                                    break;
                                }
                                index++;
                            }
                            while (index < count);
                        }
                    }
                }
            }

        }
        public event _IShockwaveFlashEvents_OnProgressEventHandler OnProgress
        {
            add
            {
                lock (this)
                {
                    if (this.m_ConnectionPoint == null)
                    {
                        this.Init();
                    }
                    _IShockwaveFlashEvents_SinkHelper helper = new _IShockwaveFlashEvents_SinkHelper();
                    int pdwCookie = 0;
                    this.m_ConnectionPoint.Advise((object)helper, out pdwCookie);
                    helper.m_dwCookie = pdwCookie;
                    helper.m_OnProgressDelegate = value;
                    this.m_aEventSinkHelpers.Add((object)helper);
                }
            }
            remove
            {
                lock (this)
                {
                    if (this.m_aEventSinkHelpers != null)
                    {
                        int count = this.m_aEventSinkHelpers.Count;
                        int index = 0;
                        if (0 < count)
                        {
                            do
                            {
                                _IShockwaveFlashEvents_SinkHelper helper = (_IShockwaveFlashEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                                if ((helper.m_OnProgressDelegate != null) && (helper.m_OnProgressDelegate.Equals((object)value)))
                                {
                                    this.m_aEventSinkHelpers.RemoveAt(index);
                                    this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                                    if (count <= 1)
                                    {
                                        Marshal.ReleaseComObject(this.m_ConnectionPoint);
                                        this.m_ConnectionPoint = null;
                                        this.m_aEventSinkHelpers = null;
                                    }
                                    break;
                                }
                                index++;
                            }
                            while (index < count);
                        }
                    }
                }
            }
        }
        public event _IShockwaveFlashEvents_OnReadyStateChangeEventHandler OnReadyStateChange
        {
            add
            {
                lock (this)
                {
                    if (this.m_ConnectionPoint == null)
                    {
                        this.Init();
                    }
                    _IShockwaveFlashEvents_SinkHelper helper = new _IShockwaveFlashEvents_SinkHelper();
                    int pdwCookie = 0;
                    this.m_ConnectionPoint.Advise((object)helper, out pdwCookie);
                    helper.m_dwCookie = pdwCookie;
                    helper.m_OnReadyStateChangeDelegate = value;
                    this.m_aEventSinkHelpers.Add((object)helper);
                }
            }
            remove
            {
                lock (this)
                {
                    if (this.m_aEventSinkHelpers != null)
                    {
                        int count = this.m_aEventSinkHelpers.Count;
                        int index = 0;
                        if (0 < count)
                        {
                            do
                            {
                                _IShockwaveFlashEvents_SinkHelper helper = (_IShockwaveFlashEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                                if ((helper.m_OnReadyStateChangeDelegate != null) && (helper.m_OnReadyStateChangeDelegate.Equals((object)value)))
                                {
                                    this.m_aEventSinkHelpers.RemoveAt(index);
                                    this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                                    if (count <= 1)
                                    {
                                        Marshal.ReleaseComObject(this.m_ConnectionPoint);
                                        this.m_ConnectionPoint = null;
                                        this.m_aEventSinkHelpers = null;
                                    }
                                    break;
                                }
                                index++;
                            }
                            while (index < count);
                        }
                    }              
            }
        }
        }

        public _IShockwaveFlashEvents_EventProvider(object obj1)
        {
            this.m_ConnectionPointContainer = (IConnectionPointContainer) obj1;
        }



        public  void Dispose()
        {
            this.Finalize();
            GC.SuppressFinalize(this);
        }

        public  void Finalize()
        {
            Monitor.Enter(this);
            try
            {
                if (this.m_ConnectionPoint != null)
                {
                    int count = this.m_aEventSinkHelpers.Count;
                    int num2 = 0;
                    if (0 < count)
                    {
                        do
                        {
                            _IShockwaveFlashEvents_SinkHelper helper = (_IShockwaveFlashEvents_SinkHelper) this.m_aEventSinkHelpers[num2];
                            this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                            num2++;
                        }
                        while (num2 < count);
                    }
                    Marshal.ReleaseComObject(this.m_ConnectionPoint);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                Monitor.Exit(this);
            }
        }

        private void Init()
        {
            IConnectionPoint ppCP = null;
            byte[] b = new byte[] { 0x6d, 0xdb, 0x7c, 210, 0x6d, 0xae, 0xcf, 0x11, 150, 0xb8, 0x44, 0x45, 0x53, 0x54, 0, 0 };
            Guid riid = new Guid(b);
            this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
            this.m_ConnectionPoint = ppCP;
            this.m_aEventSinkHelpers = new ArrayList();
        }
           
    }
}

