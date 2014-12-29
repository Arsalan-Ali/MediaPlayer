using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace MediaPlayer
{
    class PlaylistData
    {
        private String[] playlist;
        private static PlaylistData PlaylistObject;
        private StreamWriter sw;
        private StreamReader sr;
        private PlaylistData()
        {
            sw = null;
            sr = null;
            playlist = null;
        }
        public static PlaylistData getInstance()
        {
            if (PlaylistObject == null)
                PlaylistObject = new PlaylistData();
            return PlaylistObject;
        }
        public String[] getPlaylist(String playlistName)
        {
            String path = @"c:\ProgramData\M2ASH\" + playlistName + ".txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("Playlist: " + playlistName + " doesn't exists");
                return null;
            }
            String line;
            try
            {
                sr = new StreamReader(path);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Unable to open file " + ex.Message);
            }
            int lineCount = 0, i = 0;
            while ((line = sr.ReadLine()) != null)
                lineCount++;

            sr.Close();
            playlist = new String[lineCount];

            try
            {
                sr = new StreamReader(path);
            }
            catch (IOException ex)
            {
                MessageBox.Show("unable to open file " + ex.Message);

            }
            i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                playlist[i] = line;
                i++;
            }
            sr.Close();

            return playlist;
        }
        public void setPlaylist(String playlistName, String author, String[] playlist)
        {
            String path = @"c:\ProgramData\M2ASH\" + playlistName + ".txt";
            if (!File.Exists(path))
                File.Create(path).Dispose();

            try
            {
                sw = new StreamWriter(path);
            }
            catch (IOException ex)
            {
                MessageBox.Show("unable to save Playlist " + ex.Message);
            }
            sw.WriteLine(author);
            foreach (String line in playlist)
                sw.WriteLine(line);
            sw.Close();
        }

        public void delete(string playlistName)
        {
            String path = @"c:\ProgramData\M2ASH\" + playlistName + ".txt";
            File.Delete(path);
        }
    }
}