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
    public partial class MainForm : Form
    {
        WMPLib.IWMPPlaylist playlist;
        WMPLib.IWMPMedia media;

        public static String[] NPlist;
        private PlaylistData MyPlaylistData;
        private playlists MyPlaylists;

        public MainForm(String[] file)
        {
            InitializeComponent();
            playlist = MediaPlayerControl.playlistCollection.newPlaylist("MyPlayList");
            MediaPlayerControl.currentPlaylist = playlist;

            NPlist = null;

            MyPlaylists = playlists.getInstance();
            MyPlaylistData = PlaylistData.getInstance();
            if (MyPlaylists.getPlaylistNames() != null)
                foreach (String filename in MyPlaylists.getPlaylistNames())
                    PLlistBox.Items.Add(filename);
            if (file.Length > 0)
            {
                NPlist = file;
                foreach (String listItem in file)
                {
                    string value = listItem.Substring(listItem.LastIndexOf("\\") + 1);
                    value = "    " + value;
                    NPlistbox.Items.Add(value);
                    media = MediaPlayerControl.newMedia(listItem);
                    playlist.appendItem(media);
                }
                MediaPlayerControl.Ctlcontrols.play();
                NPlistbox.SelectedIndex = 0;
            }
        }

        private void OpenFiles()
        {
            using (OpenFileDialog dlgOpenFile = new OpenFileDialog())
            {
                dlgOpenFile.Filter = "Media Files (*.3gp, *.avi, *.mp4, *.mpg, *.wmv, *.m4a, *.mp3, *.wav, *.wma)|*.3gp;*.avi;*.mp4;*.mpg;*.wmv;*.m4a;*.mp3;*.wav;*.wma";
                dlgOpenFile.Title = "Please select Media file(s)";
                dlgOpenFile.Multiselect = true;

                // Check the user response
                if (dlgOpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        String[] presentList = new String[NPlistbox.Items.Count];
                        int count = 0;

                        foreach (String listItem in NPlistbox.Items)
                        {
                            presentList[count] = listItem.Substring(4);
                            count++;
                        }

                        foreach (String listItem in dlgOpenFile.FileNames)
                        {
                            Boolean flag = true;
                            foreach (String item in presentList)
                                if (listItem.Substring(listItem.LastIndexOf("\\") + 1).Equals(item))
                                    flag = false;
                            if (flag)
                            {
                                string value = listItem.Substring(listItem.LastIndexOf("\\") + 1);
                                value = "    " + value;
                                NPlistbox.Items.Add(value);
                                media = MediaPlayerControl.newMedia(listItem);
                                playlist.appendItem(media);
                            }
                        }

                        if (NPlist != null)
                        {
                            count = NPlist.Length;
                            presentList = NPlist;
                            NPlist = new String[NPlistbox.Items.Count];
                            int i = 0;
                            foreach (String listItem in presentList)
                            {
                                NPlist[i] = listItem;
                                i++;
                            }

                            foreach (String listItem in dlgOpenFile.FileNames)
                            {
                                Boolean flag = true;
                                foreach (String item in NPlist)
                                    if (listItem.Equals(item))
                                        flag = false;

                                if (flag)
                                {
                                    NPlist[count] = listItem;
                                    count++;
                                }
                            }
                        }
                        else
                        {
                            NPlist = dlgOpenFile.FileNames;
                        }

                        if (MediaPlayerControl.playState != (WMPLib.WMPPlayState.wmppsPaused) && MediaPlayerControl.playState != (WMPLib.WMPPlayState.wmppsStopped))
                            MediaPlayerControl.Ctlcontrols.play();
                        tabControl1.SelectedTab = tabPage1;
                        NPlistbox.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to open File!\n\n" + ex.Message);
                    }
                }
            }
        }

        private void playTrack()
        {
            int CMindex = 0;
            int RMindex = NPlistbox.SelectedIndex;
            int i = 0;
            try
            {
                if ((MediaPlayerControl.playState != (WMPLib.WMPPlayState.wmppsPlaying)))
                    MediaPlayerControl.Ctlcontrols.play();

                //Find the index of current media
                foreach (String item in NPlist)
                {
                    if (item.Equals(MediaPlayerControl.currentMedia.sourceURL))
                        CMindex = i;
                    i++;
                }
                i = 0;
                NPlistbox.SelectedIndex = RMindex;

                //play the selected media
                if (RMindex > CMindex)
                    for (int j = CMindex; j < RMindex; j++)
                        MediaPlayerControl.Ctlcontrols.next();

                else if (CMindex > RMindex)
                    for (int j = CMindex; j > RMindex; j--)
                        MediaPlayerControl.Ctlcontrols.previous();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Play Media!\n\n" + ex.Message);
            }
        }

        private void addToNowPlaying()
        {
            string selItem = null;
            NPlist = null;
            try
            {
                String[] tempList = new String[NPlistbox.Items.Count];
                int i = 0;
                int count = playlist.count;

                for (int j = 0; j < count; j++)
                    playlist.removeItem(playlist.get_Item(0));

                NPlistbox.Items.Clear();

                selItem = PLlistBox.SelectedItem.ToString();
                Boolean firstLoopTurn = false;
                foreach (String listItem in MyPlaylistData.getPlaylist(selItem))
                {
                    if (firstLoopTurn)
                    {
                        string value = listItem.Substring(listItem.LastIndexOf("\\") + 1);
                        value = "    " + value;
                        NPlistbox.Items.Add(value);

                        media = MediaPlayerControl.newMedia(listItem);
                        playlist.appendItem(media);
                    }
                    firstLoopTurn = true;
                }

                NPlist = new String[MyPlaylistData.getPlaylist(selItem).Length - 1];
                i = 0;
                firstLoopTurn = true;
                foreach (String listitem in MyPlaylistData.getPlaylist(selItem))
                {
                    if (firstLoopTurn)
                    {
                        firstLoopTurn = false;
                        continue;
                    }
                    NPlist[i] = listitem;
                    i++;
                }

                MediaPlayerControl.Ctlcontrols.play();
                tabControl1.SelectedTab = tabPage1;
                NPlistbox.SelectedIndex = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to Play!\n\n" + ex.Message);
            }
        }

        private void OpenFilesBtn_Click(object sender, EventArgs e)
        {
            OpenFiles();
        }

        private void FSbtn_Click(object sender, EventArgs e)
        {
            if (MediaPlayerControl.playState == (WMPLib.WMPPlayState.wmppsPlaying))
                MediaPlayerControl.fullScreen = true;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFiles();
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MediaPlayerControl.playState == (WMPLib.WMPPlayState.wmppsPlaying))
                MediaPlayerControl.fullScreen = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddPLbtn_Click(object sender, EventArgs e)
        {
            PLForm FormPL = new PLForm(null, "ADD");
            FormPL.ShowDialog();

            if (MyPlaylists.getPlaylistNames() != null)
                foreach (String filename in MyPlaylists.getPlaylistNames())
                {
                    Boolean flag = false;
                    foreach (String listitem in PLlistBox.Items)
                        if (filename.Equals(listitem))
                            flag = true;
                    if (!flag)
                        PLlistBox.Items.Add(filename);
                }
            tabControl1.SelectedTab = tabPage2;
        }

        private void PLlistBox_DoubleClick(object sender, EventArgs e)
        {
            addToNowPlaying();
        }

        private void PlayBtnPL_Click(object sender, EventArgs e)
        {
            addToNowPlaying();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PLForm Form;
                Form = new PLForm(PLlistBox.SelectedItem.ToString(), "EDIT");
                Form.ShowDialog();
                PLlistBox.Items.Remove(PLlistBox.SelectedItem);

                if (MyPlaylists.getPlaylistNames() != null)
                    foreach (String filename in MyPlaylists.getPlaylistNames())
                    {
                        Boolean flag = false;
                        foreach (String listitem in PLlistBox.Items)
                            if (filename.Equals(listitem))
                                flag = true;
                        if (!flag)
                            PLlistBox.Items.Add(filename);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot edit the playlist!\n\n" + ex);
            }
        }

        private void NPlistbox_DoubleClick(object sender, EventArgs e)
        {
            playTrack();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            playTrack();
        }

        private void RmvBtn_Click(object sender, EventArgs e)
        {
            int selItemIndex;
            String[] tempList;

            selItemIndex = NPlistbox.Items.IndexOf(NPlistbox.SelectedItem);

            // Prepare a message, a caption and buttons for the user prompt
            string message = "Remove " + NPlist[selItemIndex].Substring(NPlist[selItemIndex].LastIndexOf("\\") + 1) + " from Now Playing list?";
            string caption = "Confirm Deletion";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

            // Prompt the user for permission to delete the object
            DialogResult result = MessageBox.Show(message, caption, buttons);

            // Check the user response
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                tempList = new String[NPlist.Length - 1];
                // Remove the item from NPlistbox
                NPlistbox.Items.Remove(NPlistbox.SelectedItem);

                playlist.removeItem(playlist.get_Item(selItemIndex));

                // Remove the item from NPlist
                for (int i = selItemIndex; i < NPlist.Length - 1; i++)
                    NPlist[i] = NPlist[i + 1];
                for (int i = 0; i < tempList.Length; i++)
                    tempList[i] = NPlist[i];

                NPlist = new String[tempList.Length];
                NPlist = tempList;

                // Report that the item was deleted
                MessageBox.Show("Item Deleted\t\t\t");
                if (selItemIndex == 0 && NPlistbox.Items.Count > 0)
                    NPlistbox.SelectedIndex = 0;
                else
                    NPlistbox.SelectedIndex = selItemIndex - 1;
            }

            if (NPlistbox.Items.Count == 0)
            {
                PlayBtn.Enabled = false;
                RmvBtn.Enabled = false;
                UpBtn.Enabled = false;
                DownBtn.Enabled = false;
                TopBtn.Enabled = false;
                Botmbtn.Enabled = false;
                SaveBtn.Enabled = false;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            PLForm Form;
            Form = new PLForm(null, "SAVE");
            Form.ShowDialog();
            if (MyPlaylists.getPlaylistNames() != null)
                foreach (String filename in MyPlaylists.getPlaylistNames())
                {
                    Boolean flag = false;
                    foreach (String listitem in PLlistBox.Items)
                        if (filename.Equals(listitem))
                            flag = true;
                    if (!flag)
                        PLlistBox.Items.Add(filename);
                }
        }
        private void UpBtn_Click(object sender, EventArgs e)
        {
            string temp = null;
            int selItemIndex;
            try
            {
                selItemIndex = NPlistbox.Items.IndexOf(NPlistbox.SelectedItem);
                if (selItemIndex > 0)
                {
                    playlist.moveItem(selItemIndex, selItemIndex - 1);

                    temp = NPlist[selItemIndex];
                    NPlist[selItemIndex] = NPlist[selItemIndex - 1];
                    NPlist[selItemIndex - 1] = temp;

                    temp = NPlistbox.SelectedItem.ToString();
                    NPlistbox.Items.RemoveAt(selItemIndex);
                    NPlistbox.Items.Insert(selItemIndex - 1, temp);

                    NPlistbox.SelectedIndex = selItemIndex - 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Move!\n\nPlease check the selection of Item" + ex.Message);
            }
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            string temp = null;
            int selItemIndex;
            try
            {
                selItemIndex = NPlistbox.Items.IndexOf(NPlistbox.SelectedItem);

                if (selItemIndex < NPlistbox.Items.Count - 1)
                {
                    playlist.moveItem(selItemIndex, selItemIndex + 1);

                    temp = NPlist[selItemIndex];
                    NPlist[selItemIndex] = NPlist[selItemIndex + 1];
                    NPlist[selItemIndex + 1] = temp;

                    temp = NPlistbox.SelectedItem.ToString();
                    NPlistbox.Items.RemoveAt(selItemIndex);
                    NPlistbox.Items.Insert(selItemIndex + 1, temp);

                    NPlistbox.SelectedIndex = selItemIndex + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Move!\n\nPlease check the selection of Item" + ex.Message);
            }
        }

        private void TopBtn_Click(object sender, EventArgs e)
        {
            string temp = null;
            int selItemIndex;
            try
            {
                selItemIndex = NPlistbox.Items.IndexOf(NPlistbox.SelectedItem);
                if (selItemIndex > 0)
                {
                    playlist.moveItem(selItemIndex, 0);

                    temp = NPlist[selItemIndex];
                    for (int j = selItemIndex; j > 0; j--)
                        NPlist[j] = NPlist[j - 1];

                    NPlist[0] = temp;

                    NPlistbox.Items.Insert(0, NPlistbox.SelectedItem.ToString());
                    NPlistbox.Items.RemoveAt(selItemIndex + 1);

                    NPlistbox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Move!\n\nPlease check the selection of Item" + ex.Message);
            }
        }

        private void Botmbtn_Click(object sender, EventArgs e)
        {
            string temp = null;
            int selItemIndex;
            try
            {
                selItemIndex = NPlistbox.Items.IndexOf(NPlistbox.SelectedItem);
                if (selItemIndex < NPlistbox.Items.Count - 1)
                {
                    playlist.moveItem(selItemIndex, NPlistbox.Items.Count - 1);

                    temp = NPlist[selItemIndex];
                    for (int j = selItemIndex; j < NPlist.Length - 1; j++)
                        NPlist[j] = NPlist[j + 1];

                    NPlist[NPlist.Length - 1] = temp;

                    NPlistbox.Items.Insert(NPlistbox.Items.Count, NPlistbox.SelectedItem.ToString());
                    NPlistbox.Items.RemoveAt(selItemIndex);

                    NPlistbox.SelectedIndex = NPlistbox.Items.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Move!\n\nPlease check the selection of Item" + ex.Message);
            }
        }

        private void NPlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayBtn.Enabled = true;
            RmvBtn.Enabled = true;
            UpBtn.Enabled = true;
            DownBtn.Enabled = true;
            TopBtn.Enabled = true;
            Botmbtn.Enabled = true;
            SaveBtn.Enabled = true;
        }

        private void MediaPlayerControl_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            int CMindex = 0, i = 0;
            string temp;

            if (NPlist != null)
            {
                //Find the index of current media
                foreach (String listItem in NPlist)
                {
                    if (listItem.Equals(MediaPlayerControl.currentMedia.sourceURL))
                        CMindex = i;
                    i++;
                }
                temp = NPlist[CMindex].Substring(NPlist[CMindex].LastIndexOf("\\") + 1);
                temp = "♫   " + temp;

                for (int j = 0; j < NPlistbox.Items.Count; j++)
                {
                    string value = NPlist[j].Substring(NPlist[j].LastIndexOf("\\") + 1);
                    value = "    " + value;
                    NPlistbox.Items[j] = value;
                }

                NPlistbox.Items[CMindex] = temp;
                //NPlistbox.SelectedIndex = CMindex;
            }
        }

        private void DelBtnPL_Click(object sender, EventArgs e)
        {
            int selIndex = PLlistBox.SelectedIndex;

            // Prepare a message, a caption and buttons for the user prompt
            string message = "Remove \"" + PLlistBox.Items[selIndex] + "\" Playlist?";
            string caption = "Confirm Deletion";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

            // Prompt the user for permission to delete the object
            DialogResult result = MessageBox.Show(message, caption, buttons);

            // Check the user response
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    String name = PLlistBox.SelectedItem.ToString();
                    PLlistBox.Items.Remove(PLlistBox.SelectedItem);
                    MyPlaylistData.delete(name);
                    MyPlaylists.delete(name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Delete PlayList!\n\n" + ex.Message);
                }

                // Report that the item was deleted
                MessageBox.Show("Item Deleted\t\t\t");

                if (selIndex == 0 && PLlistBox.Items.Count > 0)
                    PLlistBox.SelectedIndex = 0;
                else
                    PLlistBox.SelectedIndex = selIndex - 1;
            }

            if (PLlistBox.Items.Count == 0)
            {
                PlayBtnPL.Enabled = false;
                DelBtnPL.Enabled = false;
                EditBtn.Enabled = false;
            }
        }

        private void PLlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayBtnPL.Enabled = true;
            DelBtnPL.Enabled = true;
            EditBtn.Enabled = true;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About FormPL = new About();
            FormPL.ShowDialog();
        }
    }
}