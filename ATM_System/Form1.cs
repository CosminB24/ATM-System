﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tasta1.FlatStyle = FlatStyle.Flat;
            tasta1.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "1";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            tasta2.FlatStyle = FlatStyle.Flat;
            tasta2.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tasta_cancel.FlatStyle = FlatStyle.Flat;
            tasta_cancel.FlatAppearance.BorderSize = 0;

            DialogResult CancelButton;

            CancelButton = MessageBox.Show("Sunteti sigur ca vreti sa parasiti bancomatul?", "ATM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (CancelButton == DialogResult.Yes)
            {
                Application.Exit();
                    }
                
        }

        private void tasta3_Click(object sender, EventArgs e)
        {
            tasta3.FlatStyle = FlatStyle.Flat;
            tasta3.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "3";
        }

        private void tasta_subenter_Click(object sender, EventArgs e)
        {
            tasta_subenter.FlatStyle = FlatStyle.Flat;
            tasta_subenter.FlatAppearance.BorderSize = 0;
        }

        private void tasta_dreapta0_Click(object sender, EventArgs e)
        {
            tasta_dreapta0.FlatStyle = FlatStyle.Flat;
            tasta_dreapta0.FlatAppearance.BorderSize = 0;
        }

        private void tasta_stanga0_Click(object sender, EventArgs e)
        {
            tasta_stanga0.FlatStyle = FlatStyle.Flat;
            tasta_stanga0.FlatAppearance.BorderSize = 0;
        }

        private void tasta0_Click(object sender, EventArgs e)
        {
            tasta0.FlatStyle = FlatStyle.Flat;
            tasta0.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "0";
        }

        private void tasta4_Click(object sender, EventArgs e)
        {
            tasta4.FlatStyle = FlatStyle.Flat;
            tasta4.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "4";
        }

        private void tasta5_Click(object sender, EventArgs e)
        {
            tasta5.FlatStyle = FlatStyle.Flat;
            tasta5.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "5";
        }

        private void tasta6_Click(object sender, EventArgs e)
        {
            tasta6.FlatStyle = FlatStyle.Flat;
            tasta6.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "6";
        }

        private void tasta_clear_Click(object sender, EventArgs e)
        {
            tasta_clear.FlatStyle = FlatStyle.Flat;
            tasta_clear.FlatAppearance.BorderSize = 0;
            Pinbox.Text = "";
        }

        private void tasta_enter_Click(object sender, EventArgs e)
        {
            tasta_enter.FlatStyle = FlatStyle.Flat;
            tasta_enter.FlatAppearance.BorderSize = 0;

            String pin_1 = String.Format(Pinbox.Text);
            String pin_2 = String.Format(Pinbox.Text);
            String pin_3 = String.Format(Pinbox.Text);

            if (pin_1 == "0000")
            {
                Sold.Visible = true;
                Retragere.Visible = true;
                Depoziteaza.Visible = true;
                pintext.Visible = false;
                Pinbox.Text = "";
                lateral_drsus.Enabled = true;
                lateral_sgjos.Enabled = true;
                lateral_sgsus.Enabled = true;
            }
            else if (pin_2 == "1234")
            {
                Sold.Visible = true;
                Retragere.Visible = true;
                Depoziteaza.Visible = true;
                pintext.Visible = false;
                Pinbox.Text = "";
                lateral_drsus.Enabled = true;
                lateral_sgjos.Enabled = true;
                lateral_sgsus.Enabled = true;
            }
            else if (pin_3 == "4321")
            {
                Sold.Visible = true;
                Retragere.Visible = true;
                Depoziteaza.Visible = true;
                pintext.Visible = false;
                Pinbox.Text = "";
                lateral_drsus.Enabled = true;
                lateral_sgjos.Enabled = true;
                lateral_sgsus.Enabled = true;
            }
            else Pinbox.Text = "Pin invalid";
        }

        private void tasta7_Click(object sender, EventArgs e)
        {
            tasta7.FlatStyle = FlatStyle.Flat;
            tasta7.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "7";
        }

        private void tasta8_Click(object sender, EventArgs e)
        {
            tasta8.FlatStyle = FlatStyle.Flat;
            tasta8.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "8";
        }
        
        private void tasta9_Click(object sender, EventArgs e)
        {
            tasta9.FlatStyle = FlatStyle.Flat;
            tasta9.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lateral_drjos.FlatStyle = FlatStyle.Flat;
            lateral_drjos.FlatAppearance.BorderSize = 0;
        }

        private void lateral_sgsus_Click(object sender, EventArgs e)
        {
            lateral_sgsus.FlatStyle = FlatStyle.Flat;
            lateral_sgsus.FlatAppearance.BorderSize = 0;
        }

        private void lateral_drsus_Click(object sender, EventArgs e)
        {
            lateral_drsus.FlatStyle = FlatStyle.Flat;
            lateral_drsus.FlatAppearance.BorderSize = 0;
        }

        private void lateral_sgjos_Click(object sender, EventArgs e)
        {
            lateral_sgjos.FlatStyle = FlatStyle.Flat;
            lateral_sgjos.FlatAppearance.BorderSize = 0;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sold.Visible = false;
            Retragere.Visible = false;
            Depoziteaza.Visible = false;
            lateral_drsus.Enabled = false;
            lateral_drjos.Enabled = false;
            lateral_sgsus.Enabled = false;
            lateral_sgjos.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
