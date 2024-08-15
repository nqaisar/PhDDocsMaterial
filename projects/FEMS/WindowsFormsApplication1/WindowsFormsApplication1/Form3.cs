using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "SteelBlue.ssk"; 
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
                
                label1.Text = "Choose port for sensor numner " + mykeeper.picname;
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    comboBox1.Items.Add(port);
                }
                label2.Text = "Amounts of alive ports now in this computer : " + comboBox1.Items.Count.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
                Form2 frm2=(Form2)this.Owner;
                int piclocini=mykeeper.piclocini;
                switch (piclocini)
                {
                    case 1:
                        frm2.pictureBox2.Location = new Point(110, 515); break;
                    case 2:
                        frm2.pictureBox3.Location = new Point(198, 515); break;
                    case 3:
                        frm2.pictureBox4.Location = new Point(294, 515); break;
                    case 4:
                        frm2.pictureBox5.Location = new Point(390, 515); break;
                    case 5:
                        frm2.pictureBox6.Location = new Point(110, 596); break;
                    case 6:
                        frm2.pictureBox7.Location = new Point(198, 596); break;
                    case 7:
                        frm2.pictureBox8.Location = new Point(294, 596); break;
                    case 8:
                        frm2.pictureBox9.Location = new Point(390, 596); break;

                }
                
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label7.Text != ""&&label7.Text!="0")
            {
                if (textBox1.Text != "")
                {
                    string descrip = textBox1.Text;
                    if (comboBox1.SelectedIndex >= 0)
                    {
                        string giveport = mykeeper.picname;
                        string tempvalue = label7.Text;
                        switch (giveport)
                        {
                            case "1":
                                mykeeper.sens1port = comboBox1.SelectedItem.ToString();
                                mykeeper.sens1portfrm2 = 1;
                                mykeeper.descripsen1 = descrip;
                                mykeeper.tempvalue1 = tempvalue;
                                break;
                            case "2":
                                mykeeper.sens2port = comboBox1.SelectedItem.ToString();
                                mykeeper.sens2portfrm2 = 1;
                                mykeeper.descripsen2 = descrip;
                                mykeeper.tempvalue2 = tempvalue;
                                break;
                            case "3":
                                mykeeper.sens3port = comboBox1.SelectedItem.ToString();
                                mykeeper.sens3portfrm2 = 1;
                                mykeeper.descripsen3 = descrip;
                                mykeeper.tempvalue3 = tempvalue;
                                break;
                            case "4":
                                mykeeper.sens4port = comboBox1.SelectedItem.ToString();
                                mykeeper.sens4portfrm2 = 1;
                                mykeeper.descripsen4 = descrip;
                                mykeeper.tempvalue4 = tempvalue;
                                break;
                            case "5":
                                mykeeper.sens5port = comboBox1.SelectedItem.ToString();
                                mykeeper.sens5portfrm2 = 1;
                                mykeeper.descripsen5 = descrip;
                                mykeeper.tempvalue5 = tempvalue;
                                break;
                            case "6":
                                mykeeper.sens6port = comboBox1.SelectedItem.ToString();
                                mykeeper.sens6portfrm2 = 1;
                                mykeeper.descripsen6 = descrip;
                                mykeeper.tempvalue6 = tempvalue;
                                break;
                            case "7":
                                mykeeper.sens7port = comboBox1.SelectedItem.ToString();
                                mykeeper.sens7portfrm2 = 1;
                                mykeeper.descripsen7 = descrip;
                                mykeeper.tempvalue7 = tempvalue;
                                break;
                            case "8":
                                mykeeper.sens8port = comboBox1.SelectedItem.ToString();
                                mykeeper.sens8portfrm2 = 1;
                                mykeeper.descripsen8 = descrip;
                                mykeeper.tempvalue8 = tempvalue;
                                break;

                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("You do not have working port or you have not choosen any yet , try to choose one  ! ");
                    }
                }
                else
                {
                    MessageBox.Show("Import some description !");
                }
            }
            else
            {
                MessageBox.Show("Scroll temperature value ! ");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar1.Value.ToString();
        }





    }
}
