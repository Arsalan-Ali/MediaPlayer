using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class PLForm : Form
    {
        private PlaylistData MyPlaylistData;
        private playlists MyPlaylists;
        private String action;
        private String playlistName;
        private String[] playlist;
        public PLForm(String playlistName, String action)
        {
            InitializeComponent();
            MyPlaylistData = PlaylistData.getInstance();
            MyPlaylists = playlists.getInstance();
            playlist = null;
            this.action = action;
            if (this.action.Equals("EDIT"))
            {
                this.playlistName = playlistName;
                PLNTextBox.Text = playlistName;
                Boolean firstLoopTurn = true;
                foreach (String listitem in MyPlaylistData.getPlaylist(playlistName))
                {
                    if (firstLoopTurn)
                    {
                        ANTextBox.Text = listitem;
                        firstLoopTurn = false;
                        continue;
                    }
                    NewPLlistBox.Items.Add(listitem.Substring(listitem.LastIndexOf("\\") + 1));
                }

                playlist = new String[NewPLlistBox.Items.Count];
                int i = 0;
                firstLoopTurn = true;
                foreach (String listitem in MyPlaylistData.getPlaylist(playlistName))
                {
                    if (firstLoopTurn)
                    {
                        ANTextBox.Text = listitem;
                        firstLoopTurn = false;
                        continue;
                    }
                    playlist[i] = listitem;
                    i++;
                }
            }
            else if (this.action.Equals("SAVE"))
            {
                int i = 0;
                playlist = new String[MainForm.NPlist.Length];
                foreach (String listitem in MainForm.NPlist)
                {
                    playlist[i] = listitem;
                    NewPLlistBox.Items.Add(listitem.Substring(listitem.LastIndexOf("\\") + 1));
                    i++;
                }
            }
        }

        private void SaveNewPlaylist()
        {
            Boolean flag = true;
            foreach (String name in MyPlaylists.getPlaylistNames())
                if (name.Equals(PLNTextBox.Text))
                    flag = false;
            if (flag)
            {
                String[] playlists = new String[NewPLlistBox.Items.Count];
                int i = 0;
                foreach (String listitem in NewPLlistBox.Items)
                {
                    playlists[i] = listitem;
                    i++;
                }

                MyPlaylists.setPlaylistNames(new String[] { PLNTextBox.Text });
                MyPlaylistData.setPlaylist(PLNTextBox.Text, ANTextBox.Text, playlist);

                MessageBox.Show("Playlist Named: \"" + PLNTextBox.Text + "\" successfully saved");
                NewPLlistBox.Items.Clear();
                PLNTextBox.Clear();
                ANTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Playlist of Name: \"" + PLNTextBox.Text + "\" already exists");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlgOpenFile = new OpenFileDialog())
            {
                dlgOpenFile.Filter = "Media Files (*.3gp, *.avi, *.mp4, *.mpg, *.wmv, *.m4a, *.mp3, *.wav, *.wma)|*.3gp;*.avi;*.mp4;*.mpg;*.wmv;*.m4a;*.mp3;*.wav;*.wma";
                dlgOpenFile.Title = "Please select Media file(s)";
                dlgOpenFile.Multiselect = true;

                if (dlgOpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        foreach (String filename in dlgOpenFile.FileNames)
                        {
                            Boolean flag = true;
                            foreach (String listitem in NewPLlistBox.Items)
                                if (listitem.Equals(filename.Substring(filename.LastIndexOf("\\") + 1)))
                                    flag = false;
                            if (flag)
                                NewPLlistBox.Items.Add(filename.Substring(filename.LastIndexOf("\\") + 1));
                        }
                        if (playlist == null)
                            playlist = dlgOpenFile.FileNames;
                        else
                        {
                            String[] temp = new String[NewPLlistBox.Items.Count];

                            int j = 0;
                            for (int i = 0; i < playlist.Length; i++, j++)
                                temp[j] = playlist[i];
                            foreach (String filename in dlgOpenFile.FileNames)
                            {
                                Boolean flag = true;
                                foreach (String item in playlist)
                                    if (filename.Equals(item))
                                        flag = false;
                                if (flag)
                                {
                                    temp[j] = filename;
                                    j++;
                                }
                            }
                            playlist = temp;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to open File!\n\n" + ex.Message);
                    }
                }
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (PLNTextBox.Text.Equals("") && NewPLlistBox.Items.Count == 0)
            {
                MessageBox.Show("Please suggest any name to playlist and Please add track to playlist");
                return;
            }

            if (PLNTextBox.Text.Equals(""))
            {
                MessageBox.Show("Please suggest any name to playlist");
                return;
            }
            if (ANTextBox.Text.Equals(""))
            {
                MessageBox.Show("Please suggest any author name to playlist");
                return;
            }

            if (NewPLlistBox.Items.Count == 0)
            {
                MessageBox.Show("Please add track to playlist");
                return;
            }

            switch (action)
            {
                case "ADD":
                    {
                        SaveNewPlaylist();
                        break;
                    }
                case "SAVE":
                    {
                        SaveNewPlaylist();
                        break;
                    }
                case "EDIT":
                    {
                        if (!playlistName.Equals(PLNTextBox.Text))
                        {
                            MyPlaylistData.delete(playlistName);
                            MyPlaylists.delete(playlistName);
                            MyPlaylists.setPlaylistNames(new String[] { PLNTextBox.Text });
                        }

                        MyPlaylistData.setPlaylist(PLNTextBox.Text, ANTextBox.Text, playlist);

                        MessageBox.Show("Playlist Named: \"" + PLNTextBox.Text + "\" successfully edited");
                        NewPLlistBox.Items.Clear();
                        PLNTextBox.Clear();
                        ANTextBox.Clear();
                        this.Close();
                        break;
                    }
            }
            playlist = null;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String[] temp = new String[NewPLlistBox.Items.Count - 1];
                int i = 0;
                int j = 0;
                foreach (String item in playlist)
                {
                    if (j == (int)NewPLlistBox.SelectedIndex)
                    {
                        j++;
                        continue;
                    }
                    temp[i] = item;
                    i++; j++;
                }
                playlist = temp;
                int selIndex = NewPLlistBox.SelectedIndex;
                NewPLlistBox.Items.RemoveAt(NewPLlistBox.SelectedIndex);
                if (selIndex == 0 && NewPLlistBox.Items.Count > 0)
                    NewPLlistBox.SelectedIndex = 0;
                else
                    NewPLlistBox.SelectedIndex = selIndex - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Remove Open!\n\n" + ex.Message);
            }

            if (NewPLlistBox.Items.Count == 0)
            {
                RemoveBtn.Enabled = false;
                UpBtn.Enabled = false;
                DownBtn.Enabled = false;
                TopBtn.Enabled = false;
                Botmbtn.Enabled = false;
            }
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            int selItemIndex;

            try
            {
                selItemIndex = NewPLlistBox.Items.IndexOf(NewPLlistBox.SelectedItem);
                String temp;
                temp = playlist[selItemIndex];
                playlist[selItemIndex] = playlist[selItemIndex - 1];
                playlist[selItemIndex - 1] = temp;

                selItemIndex = NewPLlistBox.Items.IndexOf(NewPLlistBox.SelectedItem);
                if (selItemIndex > 0)
                {
                    temp = NewPLlistBox.SelectedItem.ToString();
                    NewPLlistBox.Items.RemoveAt(selItemIndex);
                    NewPLlistBox.Items.Insert(selItemIndex - 1, temp);
                    NewPLlistBox.SelectedIndex = selItemIndex - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Move!\n\nPlease check the selection of Item" + ex.Message);
            }
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            int selItemIndex;

            try
            {
                selItemIndex = NewPLlistBox.Items.IndexOf(NewPLlistBox.SelectedItem);

                String temp;
                temp = playlist[selItemIndex];
                playlist[selItemIndex] = playlist[selItemIndex + 1];
                playlist[selItemIndex + 1] = temp;

                selItemIndex = NewPLlistBox.Items.IndexOf(NewPLlistBox.SelectedItem);
                if (selItemIndex < NewPLlistBox.Items.Count - 1)
                {
                    temp = NewPLlistBox.SelectedItem.ToString();
                    NewPLlistBox.Items.RemoveAt(selItemIndex);
                    NewPLlistBox.Items.Insert(selItemIndex + 1, temp);
                    NewPLlistBox.SelectedIndex = selItemIndex + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Move!\n\nPlease check the selection of Item" + ex.Message);
            }
        }

        private void TopBtn_Click(object sender, EventArgs e)
        {
            int selItemIndex;

            try
            {
                selItemIndex = NewPLlistBox.Items.IndexOf(NewPLlistBox.SelectedItem);
                String temp;
                temp = playlist[selItemIndex];
                for (int j = selItemIndex; j > 0; j--)
                {
                    playlist[j] = playlist[j - 1];
                }
                playlist[0] = temp;

                selItemIndex = NewPLlistBox.Items.IndexOf(NewPLlistBox.SelectedItem);
                NewPLlistBox.Items.Insert(0, NewPLlistBox.SelectedItem.ToString());
                NewPLlistBox.Items.RemoveAt(selItemIndex + 1);
                NewPLlistBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Move!\n\nPlease check the selection of Item" + ex.Message);
            }
        }

        private void Botmbtn_Click(object sender, EventArgs e)
        {
            int selItemIndex;

            try
            {
                selItemIndex = NewPLlistBox.Items.IndexOf(NewPLlistBox.SelectedItem);

                String temp;
                temp = playlist[selItemIndex];
                for (int j = selItemIndex; j < playlist.Length - 1; j++)
                    playlist[j] = playlist[j + 1];

                playlist[playlist.Length - 1] = temp;

                selItemIndex = NewPLlistBox.Items.IndexOf(NewPLlistBox.SelectedItem);
                NewPLlistBox.Items.Insert(NewPLlistBox.Items.Count, NewPLlistBox.SelectedItem.ToString());
                NewPLlistBox.Items.RemoveAt(selItemIndex);
                NewPLlistBox.SelectedIndex = NewPLlistBox.Items.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Move!\n\nPlease check the selection of Item" + ex.Message);
            }
        }

        private void NewPLlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveBtn.Enabled = true;
            UpBtn.Enabled = true;
            DownBtn.Enabled = true;
            TopBtn.Enabled = true;
            Botmbtn.Enabled = true;
        }
    }
}