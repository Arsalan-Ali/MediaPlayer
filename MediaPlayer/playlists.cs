using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaPlayer
{
    class playlists
    {
        private String[] playlistNames;
        private static playlists PlaylistObject;
        private static String path = @"c:\ProgramData\M2ASH\playlists.txt";
        private StreamWriter sw;
        private StreamReader sr;
        private playlists()
        {
            sw = null;
            sr = null;
            playlistNames = null;
            sw = null;
            sr = null;

            if (!Directory.Exists(@"c:\ProgramData\M2ASH"))
                Directory.CreateDirectory(@"c:\ProgramData\M2ASH");

            if (!File.Exists(path))
                File.Create(path).Dispose();

            try
            {
                sr = new StreamReader(path);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Unable to open file " + ex.Message);
            }

            String line;
            int lineCount = 0, i = 0;
            while ((line = sr.ReadLine()) != null)
                lineCount++;

            playlistNames = new String[lineCount];
            i = 0;
            sr.Close();
            try
            {
                sr = new StreamReader(path);
            }
            catch (IOException ex)
            {
                MessageBox.Show("unable to open file " + ex.Message);
            }
            while ((line = sr.ReadLine()) != null)
            {
                playlistNames[i] = line;
                i++;
            }
            sr.Close();
        }

        public static playlists getInstance()
        {
            if (PlaylistObject == null)
                PlaylistObject = new playlists();
            return PlaylistObject;
        }

        public String[] getPlaylistNames()
        {
            return playlistNames;
        }

        public void setPlaylistNames(String[] playlistNames)
        {
            if (this.playlistNames != null)
            {
                String[] temp = new String[this.playlistNames.Length + playlistNames.Length];
                int j = 0;

                for (int i = 0; i < playlistNames.Length; i++, j++)
                    temp[j] = playlistNames[i];

                for (int i = 0; i < this.playlistNames.Length; i++, j++)
                    temp[j] = this.playlistNames[i];

                this.playlistNames = temp;
            }
            else
            {
                this.playlistNames = playlistNames;
            }

            try
            {
                sw = new StreamWriter(path);
            }

            catch (IOException ex)
            {
                MessageBox.Show("Unable to save Playlist " + ex.Message);
            }

            foreach (String line in this.playlistNames)
                sw.WriteLine(line);

            sw.Close();
        }

        public void delete(String playlistName)
        {
            String[] temp = new String[this.playlistNames.Length - 1];
            int i = 0;
            foreach (String name in this.playlistNames)
            {
                if (name.Equals(playlistName))
                    continue;
                temp[i] = name;
                i++;
            }
            this.playlistNames = temp;
            try
            {
                sw = new StreamWriter(path);
            }
            catch (IOException ex)
            {
                MessageBox.Show("" + ex.Message);
            }

            foreach (String line in this.playlistNames)
                sw.WriteLine(line);

            sw.Close();
        }
    }
}