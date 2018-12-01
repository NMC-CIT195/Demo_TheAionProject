using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheAionProject.Presenters;
using TheAionProject.Assets;

namespace TheAionProject.Views
{
    public partial class MainForm : Form
    {
        public enum MainFormStatusType
        {
            None,
            PlayerOnboarding,
            PlayerTraveling
        }

        private MainFormStatusType _mainFormStatus;

        public MainFormStatusType MainFormStatus
        {
            get { return _mainFormStatus; }
            set { _mainFormStatus = value; }
        }


        public MainForm()
        {
            InitializeComponent();
            MainPresenter mainPresenter = new MainPresenter(this);
            txt_GameMessage.Text = GameText.MissionIntro(); 
        }


        private void btn_QuitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grpbox_Onboarding_Enter(object sender, EventArgs e)
        {

        }
    }
}
