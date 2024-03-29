﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAB.Forms.UserManagement;
using PAB.Forms.DevicesManagement;
using PAB.Models;
using PAB.Services;

namespace PAB.Forms.Main
{
    public partial class BasicUserForm : Form
    {
        public User user;

        public BasicUserForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelLogin.Text = user.Login;

            var frm = new HomeForm(user);
            OpenFormInPanel(frm);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            frm.Show();
            this.Dispose();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var frm = new HomeForm(user);
            OpenFormInPanel(frm);
        }

        public void OpenFormInPanel(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelForm.Controls.Clear();
            panelForm.Controls.Add(frm);
            frm.Show();
        }

        private void BasicUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            var frm = new OptionSelectorForm(this, user);
            OpenFormInPanel(frm);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var frm = new SettingsForm(user);
            OpenFormInPanel(frm);
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            var frm = new RequestsForm(user);
            OpenFormInPanel(frm);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var frm = new ReportsForm(user);
            OpenFormInPanel(frm);
        }
    }
}