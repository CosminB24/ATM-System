using System;
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

        string pin1="1111";
        float suma1=4300.50f;

        string pin2="2222";
        float suma2=1200.10f;

        string pin3="3333";
        float suma3=300.50f;

        string pin4 = "2686";
        float suma4 = 2710;

        int user_curent = 0;
        float suma_user=0f;

        bool mustClear = false;

        int stare = 0;// 1: depozitare, 2: retragere


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkClearText();
            tasta1.FlatStyle = FlatStyle.Flat;
            tasta1.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "1";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkClearText();
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

                if (user_curent == 1)
                    suma1 = suma_user;

                if (user_curent == 2)
                    suma2 = suma_user;


                if (user_curent == 1)
                    suma3 = suma_user;

                if (user_curent == 4)
                    suma4 = suma_user;

                pintext.Text = "Introduceti codul PIN";

                //Delogare

                user_curent = 0;
                suma_user = 0f;

                Sold.Visible = false;
                pintext.Visible = true;
                Retragere.Visible = false;
                Depoziteaza.Visible = false;
                lateral_drsus.Enabled = false;
                lateral_drjos.Enabled = false;
                lateral_sgsus.Enabled = false;
                lateral_sgjos.Enabled = false;
                Pinbox.Text = "";
            }
                
        }

        private void tasta3_Click(object sender, EventArgs e)
        {
            checkClearText();
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
            checkClearText();
            tasta0.FlatStyle = FlatStyle.Flat;
            tasta0.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "0";
        }

        private void tasta4_Click(object sender, EventArgs e)
        {
            checkClearText();
            tasta4.FlatStyle = FlatStyle.Flat;
            tasta4.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "4";
        }

        private void tasta5_Click(object sender, EventArgs e)
        {
            checkClearText();
            tasta5.FlatStyle = FlatStyle.Flat;
            tasta5.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "5";
        }

        private void tasta6_Click(object sender, EventArgs e)
        {
            checkClearText();
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

            if (stare == 0)
            {
                String pin = String.Format(Pinbox.Text);


                if (pin == pin1)
                {

                    user_curent = 1;
                    suma_user = suma1;

                    Sold.Visible = true;
                    Retragere.Visible = true;
                    Depoziteaza.Visible = true;
                    pintext.Visible = false;
                    Pinbox.Text = "";
                    lateral_drsus.Enabled = true;
                    lateral_sgjos.Enabled = true;
                    lateral_sgsus.Enabled = true;
                }
                else if (pin == pin2)
                {
                    user_curent = 2;
                    suma_user = suma2;


                    Sold.Visible = true;
                    Retragere.Visible = true;
                    Depoziteaza.Visible = true;
                    pintext.Visible = false;
                    Pinbox.Text = "";
                    lateral_drsus.Enabled = true;
                    lateral_sgjos.Enabled = true;
                    lateral_sgsus.Enabled = true;
                }
                else if (pin == pin3)
                {
                    user_curent = 3;
                    suma_user = suma3;


                    Sold.Visible = true;
                    Retragere.Visible = true;
                    Depoziteaza.Visible = true;
                    pintext.Visible = false;
                    Pinbox.Text = "";
                    lateral_drsus.Enabled = true;
                    lateral_sgjos.Enabled = true;
                    lateral_sgsus.Enabled = true;
                }
                else if (pin == pin4)
                {
                    user_curent = 4;
                    suma_user = suma4;


                    Sold.Visible = true;
                    Retragere.Visible = true;
                    Depoziteaza.Visible = true;
                    pintext.Visible = false;
                    Pinbox.Text = "";
                    lateral_drsus.Enabled = true;
                    lateral_sgjos.Enabled = true;
                    lateral_sgsus.Enabled = true;
                }
                else
                {
                    Pinbox.Text = "Pin invalid";
                    mustClear = true;
                }
            }
            if (stare == 1)// Depozitare
            {
                float suma_depusa = float.Parse(Pinbox.Text);
                suma_user += suma_depusa;
                pintext.Text = "A fost depozitata suma: "+suma_depusa.ToString();
                stare = 0;
            }
            if (stare == 2)// Retragere
            {
                float suma_retrasa = float.Parse(Pinbox.Text);
                suma_user -= suma_retrasa;
                pintext.Text = "A fost retrasa suma: "+suma_retrasa.ToString();
                stare = 0;
            }
        }

        private void tasta7_Click(object sender, EventArgs e)
        {
            checkClearText();
            tasta7.FlatStyle = FlatStyle.Flat;
            tasta7.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "7";
        }

        private void tasta8_Click(object sender, EventArgs e)
        {
            checkClearText();
            tasta8.FlatStyle = FlatStyle.Flat;
            tasta8.FlatAppearance.BorderSize = 0;
            Pinbox.Text = Pinbox.Text + "8";
        }
        
        private void tasta9_Click(object sender, EventArgs e)
        {
            checkClearText();
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
            Pinbox.Text = ""+  suma_user.ToString();
            lateral_sgsus.FlatStyle = FlatStyle.Flat;
            lateral_sgsus.FlatAppearance.BorderSize = 0;
            pintext.Visible = false;
        }

        private void lateral_drsus_Click(object sender, EventArgs e)
        {
            lateral_drsus.FlatStyle = FlatStyle.Flat;
            lateral_drsus.FlatAppearance.BorderSize = 0;
            pintext.Text = "Retrageti suma:";
            Pinbox.Text = "";

            pintext.Visible = true;
            stare = 2;
        }

        private void lateral_sgjos_Click(object sender, EventArgs e)
        {
            lateral_sgjos.FlatStyle = FlatStyle.Flat;
            lateral_sgjos.FlatAppearance.BorderSize = 0;
            pintext.Text = "Depozitati suma:";
            Pinbox.Text = "";

            pintext.Visible = true;
            stare = 1;
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

        private void checkClearText()
        { 
            if(mustClear)
                Pinbox.Text = "";

            mustClear = false;
        }

        
    }
}
