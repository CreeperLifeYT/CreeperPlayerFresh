using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Un4seen.Bass;

namespace CreeperPlayer
{
    public static class BassClass
    {
        #region Variables
        public static int Hertz = 44100; //sample rate
        public static bool InitDefaultDevice; //init state
        public static int Stream; //channel
        public static int Volume = 100; //volume
        private static bool isStopped = true;
        public static bool EndPlaylist;
        private static readonly List<int> BassPluginsHandlers = new List<int>();
        #endregion

        #region BASS.DLL init
        public static bool InitBass(int hertz)
        {
            if (!InitDefaultDevice)
            {
                InitDefaultDevice = Bass.BASS_Init(-1, hertz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                
                #region BASS.DLL plugins load
                
                if (InitDefaultDevice)
                {
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(Vars.BassPlugins + @"bass_aac.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(Vars.BassPlugins + @"bass_ac3.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(Vars.BassPlugins + @"bass_mpc.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(Vars.BassPlugins + @"bass_tta.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(Vars.BassPlugins + @"bassalac.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(Vars.BassPlugins + @"bassape.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(Vars.BassPlugins + @"bassflac.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(Vars.BassPlugins + @"bassmidi.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(Vars.BassPlugins + @"bassopus.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(Vars.BassPlugins + @"basswma.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(Vars.BassPlugins + @"basswv.dll"));

                    int ErrorCount = 0;
                    for (int i = 0; i < BassPluginsHandlers.Count; i++)
                        if (BassPluginsHandlers[i] == 0)
                            ErrorCount++;
                    if (ErrorCount != 0)
                    {
                        string message = ErrorCount + " plugins has not loaded!";
                        string title = "Error";
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(message, title, buttons, icon);
                        if (result == DialogResult.OK)
                        {

                        }
                    }    
                }
                
                #endregion
                
            }
            return InitDefaultDevice;
        }
        #endregion

        #region Playing controls
        //Channel play
        public static void Play(string filename, int vol)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();
                if (InitBass(Hertz))
                {
                    Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                    if (Stream != 0)
                    {
                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                        Bass.BASS_ChannelPlay(Stream, false);
                    }
                }
            }
            else
                Bass.BASS_ChannelPlay(Stream, false);
            isStopped = false;
        }

        //Channel pause
        public static void Pause()
        {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
                Bass.BASS_ChannelPause(Stream);
        }

        //Channel stop
        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
            isStopped = true;
        }

        public static bool ToNextTrack()
        {
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStopped))
            {
                if (Vars.Files.Count > Vars.CurrentTrackNumber + 1)
                {
                    Play(Vars.Files[++Vars.CurrentTrackNumber], Volume);
                    EndPlaylist = false;
                    return true;
                }
                else
                    EndPlaylist = true;
            }
            return false;
        }
        #endregion

        #region Stream position and time
        //Get current position in seconds
        public static int GetPosOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        //Get channel length in seconds
        public static int GetTimeOfStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }
        #endregion

        #region Set volume
        public static void GetPosOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }

        //Setting volume
        public static void SetVolumeToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }
        #endregion
    }
}
