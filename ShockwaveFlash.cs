namespace BDFlashObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Data;
    using System.Text;
    using System.Windows.Forms;
    public partial class ShockwaveFlash : UserControl
    {
        private BDFlashObjects.AxShockwaveFlash flash;
        public ShockwaveFlash()
        {
            InitializeComponent();
            flash = new BDFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(flash)).BeginInit();
            this.SuspendLayout();
            flash.Width = this.Width;
            flash.Height = this.Height;
            flash.Dock = DockStyle.Fill;
            this.Controls.Add(flash);
            ((System.ComponentModel.ISupportInitialize)(flash)).EndInit();
            this.ResumeLayout(false);
            flash.ScaleMode = 2;
            flash.FlashCall += (s, e) => { FlashCall?.Invoke(s,new FlashCallEventArgs(e.request)); };
            flash.FSCommand += (s, e) => { FSCommand?.Invoke(s, new FSCommandEventArgs(e.command, e.args)); };
            flash.OnProgress += (s, e) => { OnProgress?.Invoke(s,new OnProgressEventArgs(e.percentDone)); };
            flash.OnReadyStateChange += (s, e) => { OnReadyStateChange?.Invoke(s,new OnReadyStateChangeEventArgs(e.newState)); };
        }

        private string _Moive;
        /// <summary>
        /// Set the flash path
        /// </summary>
        public string Movie
        {
            get
            {
                return _Moive;
            }
            set
            {
                flash.Movie = value;
                _Moive = value;
            }
        }

        public  void Back()
        {
            flash.Back();
        }
        public  int CurrentFrame()
        {
            return flash.CurrentFrame();
        }
        public  void DisableLocalSecurity()
        {
            flash.DisableLocalSecurity();
        }
        public  void EnforceLocalSecurity()
        {
            flash.EnforceLocalSecurity();
        }
        public  int FlashVersion()
        {
            return flash.FlashVersion();
        }
        public virtual void Forward()
        {
            flash.Forward();
        }
        public virtual bool FrameLoaded(int frameNum)
        {
            return flash.FrameLoaded(frameNum);
        }
        public virtual string GetVariable(string name)
        {
            return flash.GetVariable(name);
        }
        public virtual void GotoFrame(int frameNum)
        {
            flash.GotoFrame(frameNum);
        }
        public virtual bool IsPlaying()
        {
            return flash.IsPlaying();
        }
        public virtual void LoadMovie(int layer, string url)
        {
            flash.LoadMovie(layer,url);
        }
        public virtual void Pan(int x, int y, int mode)
        {
            flash.Pan(x,y,mode);
        }
        public virtual int PercentLoaded()
        {
            return flash.PercentLoaded();
        }

        public void Play()
        {
            flash.Play();
        }
        public virtual void Rewind()
        {
            flash.Rewind();
        }
        public virtual void SetReturnValue(string returnValue)
        {
            flash.SetReturnValue(returnValue);
        }
        public virtual void SetVariable(string name, string value)
        {
            flash.SetVariable(name,value);
        }
        public virtual void SetZoomRect(int left, int top, int right, int bottom)
        {
            flash.SetZoomRect(left,top,right,bottom);
        }

        public virtual void StopPlay()
        {
            flash.StopPlay();
        }
        public virtual void TCallFrame(string target, int frameNum)
        {
            flash.TCallFrame(target,frameNum);
        }

        public virtual void TCallLabel(string target, string label)
        {
            flash.TCallLabel(target, label);
        }
        public virtual int TCurrentFrame(string target)
        {
           return flash.TCurrentFrame(target);
        }
        public void Stop()
        {
            flash.Stop();
        }
        public virtual string TCurrentLabel(string target)
        {
            return flash.TCurrentLabel(target);
        }
        public virtual string TGetProperty(string target, int property)
        {
            return flash.TGetProperty(target,property);
        }

        public virtual double TGetPropertyAsNumber(string target, int property)
        {
            return flash.TGetPropertyAsNumber(target,property);
        }

        public virtual double TGetPropertyNum(string target, int property)
        {
            return flash.TGetPropertyNum(target,property);
        }
        public virtual void TGotoFrame(string target, int frameNum)
        {
            flash.TGotoFrame(target,frameNum);
        }

        public virtual void TGotoLabel(string target, string label)
        {
            flash.TGotoLabel(target,label);
        }
        public virtual void TSetProperty(string target, int property, string value)
        {
            flash.TSetProperty(target,property,value);
        }
        public virtual void TSetPropertyNum(string target, int property, double value)
        {
            flash.TSetPropertyNum(target,property,value);
        }
        public virtual void TStopPlay(string target)
        {
            flash.TStopPlay(target);
        }
        public virtual void Zoom(int factor)
        {
            flash.Zoom(factor);
        }
        public virtual int AlignMode
        {
            get { return flash.AlignMode; }
            set { flash.AlignMode = value; }
        }
        public virtual string AllowFullScreen
        { get { return flash.AllowFullScreen; } set { flash.AllowFullScreen = value; } }

        public virtual string AllowNetworking
        { get { return flash.AllowNetworking; } set { flash.AllowNetworking = value; } }

        public virtual string AllowScriptAccess
        { get { return flash.AllowScriptAccess; } set { flash.AllowScriptAccess = value; } }

        public virtual int BackgroundColor
        { get { return flash.BackgroundColor; } set { flash.BackgroundColor = value; } }

        public virtual string Base
        { get { return flash.Base; } set { flash.Base = value; } }

        public virtual string BGColor
        { get { return flash.BGColor; } set { flash.BGColor = value; } }
        public virtual void TPlay(string target)
        {
            flash.TPlay(target);
        }

        public virtual string CtlScale
        {
            get { return flash.CtlScale; }
            set { flash.CtlScale = value; }
        }

        public virtual bool DeviceFont
        { get { return flash.DeviceFont; } set { flash.DeviceFont = value; } }

        public virtual bool EmbedMovie
        { get { return flash.EmbedMovie; } set { flash.EmbedMovie = value; } }

        public virtual string FlashVars
        { get { return flash.FlashVars; } set { flash.FlashVars = value; } }

        public virtual int FrameNum
        { get { return flash.FrameNum; } set { flash.FrameNum = value; } }

        public virtual object InlineData
        {
            get {return flash.InlineData; }
            set { flash.InlineData = value; }
        }
        public virtual bool Loop
        { get { return flash.Loop; } set { flash.Loop = value; } }

        public virtual bool Menu
        { get { return flash.Menu; } set { flash.Menu = value; } }

        public virtual string MovieData
        {
            get { return flash.MovieData; }
            set { flash.MovieData = value; }
        }

        public virtual bool Playing
        {
            get { return flash.Playing; }
            set { flash.Playing = value; }
        }
        public virtual bool Profile
        { get { return flash.Profile; } set { flash.Profile = value; } }

        public virtual string ProfileAddress
        { get { return flash.ProfileAddress; } set { flash.ProfileAddress = value; } }

        public virtual int ProfilePort
        {
            get { return flash.ProfilePort; }
            set { flash.ProfilePort = value; }
        }
        public virtual int Quality
        {
            get { return flash.Quality; }
            set { flash.Quality = value; }
        }
        public virtual string Quality2
        {
            get { return flash.Quality2; }
            set { flash.Quality2 = value; }
        }
        public virtual int ReadyState
        { get { return flash.ReadyState; } }


        public virtual string SAlign
        {
            get { return flash.SAlign; }
            set { flash.SAlign = value; }
        }
        public virtual int ScaleMode
        { get { return flash.ScaleMode; } set { flash.ScaleMode = value; } }

        public virtual bool SeamlessTabbing
        {
            get { return flash.SeamlessTabbing; }
            set { flash.SeamlessTabbing = value; }
        }
        public virtual string SWRemote
        { get { return flash.SWRemote; } set { flash.SWRemote = value; } }

        public virtual int TotalFrames
        { get { return flash.TotalFrames; } }

        public virtual string WMode
        { get { return flash.WMode; } set { flash.WMode = value; } }
        public void CallFunction(string request)
        {
            this.flash.CallFunction(request);
        }

        public void CallFunction(string funName, string value)
        {
            string request = string.Format("<invoke name=\"{0}\" returntype=\"xml\"><arguments><string>{1}</string></arguments></invoke>",funName,value);
            CallFunction(request);
        }

        public event EventHandler<FlashCallEventArgs> FlashCall;
        public event EventHandler<FSCommandEventArgs> FSCommand;
        public event EventHandler<OnProgressEventArgs> OnProgress;
        public event EventHandler<OnReadyStateChangeEventArgs> OnReadyStateChange;
    }

    public class FlashCallEventArgs:EventArgs
    {
        public string RawXml { get; set; }
        public string Value { get; set; }
        public FlashCallEventArgs(string request)
        {
            this.RawXml = request;
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.LoadXml(request);
            System.Xml.XmlNodeList list = doc.GetElementsByTagName("arguments");
            if (list.Count > 0)
                this.Value = list[0].InnerText;
            else
                this.Value =null;
        }
    }

    public class FSCommandEventArgs:EventArgs
    {
        public string Command { get; set; }
        public string Args { get; set; }
        public FSCommandEventArgs(string command,string args)
        {
            this.Command = command;
            this.Args = args;
        }
    }

    public class OnProgressEventArgs:EventArgs
    {
        public int PercentDone;
        public OnProgressEventArgs(int percentDone)
        {
            this.PercentDone = percentDone;
        }
    }

    public class OnReadyStateChangeEventArgs:EventArgs
    {
        public int newState { get; set; }

        public OnReadyStateChangeEventArgs(int newState)
        {
            this.newState = newState;
        }
    }
}
