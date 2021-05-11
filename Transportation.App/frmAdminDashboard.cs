﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportation.App
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
            this.pnlRed.Height = this.btnHome.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.btnHome.Height;
            this.pnlRed.Top = this.btnHome.Top;
            
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.btnProfile.Height;
            this.pnlRed.Top = this.btnProfile.Top;


            controlUser user = new controlUser();
            MainControl.showControl(user, frmAdminDashboard.ActiveForm);

        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.btnBus.Height;
            this.pnlRed.Top = this.btnBus.Top;
        }




        /* private void SetPanelPosition(object button)
{
this.pnlRed.Height = button.Height;
this.pnlRed.Top = this.btnProfile.Top;
} */
    }
}
