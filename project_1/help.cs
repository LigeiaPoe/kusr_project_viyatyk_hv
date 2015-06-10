using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SKYPE4COMLib;
using System.Threading;

namespace project_1
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }
        private static Skype _skype = new Skype();

       


        

        

        private void btnOpenProfil_Click(object sender, EventArgs e)
        {
            if (_skype.Client.IsRunning)
            {
                _skype.Client.OpenProfileDialog();
            }
        }

        private void btnOpenFriend_Click(object sender, EventArgs e)
        {
            if (_skype.Client.IsRunning)
            {
                _skype.Client.OpenUserInfoDialog(txtFriend.Text);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_skype.Client.IsRunning)
            {
                string Search_word = cmbSearch.Text;
                switch (Search_word)
                {
                    case "List":
                        _skype.Client.OpenContactsTab();
                    break;
                    case "Black List":
                        _skype.Client.OpenBlockedUsersDialog();
                    break;
                    case "Conference":
                        _skype.Client.OpenConferenceDialog();
                    break;
                    case "Search":
                        _skype.Client.OpenSearchDialog();
                    break;

                    default:
                    cmbSearch.Text = "Error";
                    break;

                }
            }
        }

       

        private void btnOpenFriendContact_Click(object sender, EventArgs e)
        {
            string usname = txtFriendContact.Text;
            if (_skype.Client.IsRunning)
            {
                _skype.Client.OpenMessageDialog(usname);
            }
        }

        private void btnSearchOptions_Click(object sender, EventArgs e)
        {
            string Search = cmbSearchOptions.Text;
            switch (Search)
            {
                case "General":
                    _skype.Client.OpenOptionsDialog("General");
                break;
                case "Audio settings":
                    _skype.Client.OpenOptionsDialog("SOUNDDEVICES");
                break;
                case "Sounds":
                    _skype.Client.OpenOptionsDialog("SOUNDALERTS");
                break;
                /*case "General.Video settings":
                    _skype.Client.OpenOptionsDialog("Video settings");
                break;
                case "Skype WiFi":
                    _skype.Client.OpenOptionsDialog("Skype WiFi");
                break;*/
                case "Privacy":
                    _skype.Client.OpenOptionsDialog("Privacy");
                //_skype.Client.Focus();
                break;
                case "Notifications":
                    _skype.Client.OpenOptionsDialog("Notifications");
                break;
                case "Video settings":
                _skype.Client.OpenOptionsDialog("VIDEO");
                break;
                case "Call forwarding":
                _skype.Client.OpenOptionsDialog("CALLFORWARD");
                break;
                case "Vioce messages":
                _skype.Client.OpenOptionsDialog("VOICEMAIL");
                break;
                case "Hotkeys":
                _skype.Client.OpenOptionsDialog("HOTKEYS");
                break;
                case "Connection":
                _skype.Client.OpenOptionsDialog("CONNECTION");
                break;

               
                default:
                    cmbSearchOptions.Text = "Error";
                break;

            }
        }


       private void btn_online_Click(object sender, EventArgs e)
       {
           _skype.ChangeUserStatus(TUserStatus.cusOnline);
       }

       private void btn_disconect_Click(object sender, EventArgs e)
       {
           _skype.ChangeUserStatus(TUserStatus.cusDoNotDisturb);
       }

       private void btn_available_Click(object sender, EventArgs e)
       {
           _skype.ChangeUserStatus(TUserStatus.cusNotAvailable);
       }

       private void help_Load(object sender, EventArgs e)
       {

       }

       private void futureButton1_Click(object sender, EventArgs e)
       {
           help.ActiveForm.Close();
       }

       private void btn_open_skype_Click_1(object sender, EventArgs e)
       {
           _skype.Client.Start(true, true);
       }

       private void button1_Click(object sender, EventArgs e)
       {
           if (_skype.Client.IsRunning)
           {
               _skype.Client.Shutdown();
           }
       }

       private void button2_Click(object sender, EventArgs e)
       {
           if (_skype.Client.IsRunning)
           {
               _skype.Client.Minimize();
           }
       }

       private void button3_Click(object sender, EventArgs e)
       {
           if (_skype.Client.IsRunning)
           {
               _skype.Client.OpenGettingStartedWizard();
           }
       }

    }
}
