using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Ports;


namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        string fileadd;// keeps file address
        int pic1mode;// 1 for image exist,0 for image does not exit
        int actimode;// 1 for exist activated sensors , 0 for does not exist
        int sensornum;// keeps how many sensors have activated
        public Form2()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "SteelBlue.ssk"; 
        }

        private void v(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    this.pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                    fileadd = openFileDialog1.FileName.ToString();
                    pic1mode = 1;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image" + ex.Message);
                }
            }
        }


        public void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            this.pictureBox2.Visible = false;
            this.pictureBox3.Visible = false;
            this.pictureBox4.Visible = false;
            this.pictureBox5.Visible = false;
            this.pictureBox6.Visible = false;
            this.pictureBox7.Visible = false;
            this.pictureBox8.Visible = false;
            this.pictureBox9.Visible = false;
            
            this.comboBox1.SelectedIndex = 0;
            piclocationinitial();
            this.pictureBox2.Image = this.imageList1.Images[0];
            this.pictureBox3.Image = this.imageList1.Images[2];
            this.pictureBox4.Image = this.imageList1.Images[4];
            this.pictureBox5.Image = this.imageList1.Images[6];
            this.pictureBox6.Image = this.imageList1.Images[8];
            this.pictureBox7.Image = this.imageList1.Images[10];
            this.pictureBox8.Image = this.imageList1.Images[12];
            this.pictureBox9.Image = this.imageList1.Images[14];

        }
        public void piclocationinitial()
        {
            this.pictureBox2.Location = new Point(110, 515);
            this.pictureBox3.Location = new Point(198, 515);
            this.pictureBox4.Location = new Point(294, 515);
            this.pictureBox5.Location = new Point(390, 515);
            this.pictureBox6.Location = new Point(110, 596);
            this.pictureBox7.Location = new Point(198, 596);
            this.pictureBox8.Location = new Point(294, 596);
            this.pictureBox9.Location = new Point(390, 596);
        }
        const uint WM_SYSCOMMAND = 0x0112;
        const uint SC_MOVE = 0xF010;
        const uint HTCAPTION = 0x0002;
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, uint wMsg, uint wParam, uint lParam);
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();

        private void button4_Click(object sender, EventArgs e)
        {
            if(pic1mode==1)
            {
                if (this.textBox1.Text == "")
                {
                    MessageBox.Show("You have not add descreption yet !");
                    actimode = 0;
                    this.textBox1.Focus();
                    this.comboBox1.SelectedIndex = 0;
                }

                else
                {
                    if (this.comboBox1.SelectedIndex == 0)
                    {
                        MessageBox.Show("df");
                    }
                    else
                    {
                        string sensum = this.comboBox1.SelectedItem.ToString();
                        MessageBox.Show("you have activated " + sensum + " sensors successfuly !");
                        string acti = this.comboBox1.SelectedItem.ToString();
                        actimode = 1;

                        switch (acti)
                        {
                            case "1":
                              
                                this.pictureBox2.Visible = true;
                                this.pictureBox3.Visible = false;
                                this.pictureBox4.Visible = false;
                                this.pictureBox5.Visible = false;
                                this.pictureBox6.Visible = false;
                                this.pictureBox7.Visible = false;
                                this.pictureBox8.Visible = false;
                                this.pictureBox9.Visible =false;
                                sensornum = 1;

                                break;
                            case "2":

                                this.pictureBox2.Visible = true;
                                this.pictureBox3.Visible = true;
                                this.pictureBox4.Visible = false;
                                this.pictureBox5.Visible = false;
                                this.pictureBox6.Visible = false;
                                this.pictureBox7.Visible = false;
                                this.pictureBox8.Visible = false;
                                this.pictureBox9.Visible = false;
                                sensornum = 2;
                                break;
                            case "3":

                                this.pictureBox2.Visible = true;
                                this.pictureBox3.Visible = true;
                                this.pictureBox4.Visible = true;
                                this.pictureBox5.Visible = false;
                                this.pictureBox6.Visible = false;
                                this.pictureBox7.Visible = false;
                                this.pictureBox8.Visible = false;
                                this.pictureBox9.Visible = false;
                                sensornum = 3;
                                break;
                            case "4":

                                this.pictureBox2.Visible = true;
                                this.pictureBox3.Visible = true;
                                this.pictureBox4.Visible = true;
                                this.pictureBox5.Visible = true;
                                this.pictureBox6.Visible = false;
                                this.pictureBox7.Visible = false;
                                this.pictureBox8.Visible = false;
                                this.pictureBox9.Visible = false;
                                sensornum = 4;
                                break;
                            case "5":

                                this.pictureBox2.Visible = true;
                                this.pictureBox3.Visible = true;
                                this.pictureBox4.Visible = true;
                                this.pictureBox5.Visible = true;
                                this.pictureBox6.Visible = true;
                                this.pictureBox7.Visible = false;
                                this.pictureBox8.Visible = false;
                                this.pictureBox9.Visible = false;
                                sensornum = 5;
                                break;
                            case "6":

                                this.pictureBox2.Visible = true;
                                this.pictureBox3.Visible = true;
                                this.pictureBox4.Visible = true;
                                this.pictureBox5.Visible = true;
                                this.pictureBox6.Visible = true;
                                this.pictureBox7.Visible = true;
                                this.pictureBox8.Visible = false;
                                this.pictureBox9.Visible = false;
                                sensornum = 6;
                                break;
                            case "7":

                                this.pictureBox2.Visible = true;
                                this.pictureBox3.Visible = true;
                                this.pictureBox4.Visible = true;
                                this.pictureBox5.Visible = true;
                                this.pictureBox6.Visible = true;
                                this.pictureBox7.Visible = true;
                                this.pictureBox8.Visible = true;
                                this.pictureBox9.Visible = false;
                                sensornum = 7;

                                break;
                            case "8":

                                this.pictureBox2.Visible = true;
                                this.pictureBox3.Visible = true;
                                this.pictureBox4.Visible = true;
                                this.pictureBox5.Visible = true;
                                this.pictureBox6.Visible = true;
                                this.pictureBox7.Visible = true;
                                this.pictureBox8.Visible = true;
                                this.pictureBox9.Visible = true;
                                sensornum = 8;
                                break;
                            default: break;
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Choose blueprint first by importing!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Form2_Load(null, null);
            this.textBox1.Clear();

        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {

                ReleaseCapture();
                SendMessage((sender as Control).Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
                if (this.pictureBox2.Left < this.pictureBox1.Left)
                {
                    this.pictureBox2.Location = new Point(110, 515);

                }
                if (pictureBox2.Left > pictureBox1.Left)
                {

                    mykeeper.picname = "1";
                    mykeeper.piclocini = 1;
                    Form3 sensorpor = new Form3();
                    sensorpor.Owner = this;
                    sensorpor.ShowDialog();
                }

            
            

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage((sender as Control).Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            if (this.pictureBox3.Left < this.pictureBox1.Left)
            {
                this.pictureBox3.Location = new Point(198, 515);

            }
            if (pictureBox3.Left > pictureBox1.Left)
            {
                mykeeper.picname = "2";
                mykeeper.piclocini = 2;
                Form3 sensorpor = new Form3();
                sensorpor.Owner = this;
                sensorpor.ShowDialog();

            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage((sender as Control).Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            if (this.pictureBox4.Left < this.pictureBox1.Left)
            {
                this.pictureBox4.Location = new Point(294, 515);

            }
            if (pictureBox4.Left > pictureBox1.Left)
            {
                mykeeper.picname = "3";
                mykeeper.piclocini = 3;
                Form3 sensorpor = new Form3();
                sensorpor.Owner = this;
                sensorpor.ShowDialog();

            }
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage((sender as Control).Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            if (this.pictureBox5.Left < this.pictureBox1.Left)
            {
                this.pictureBox5.Location = new Point(390, 515);

            }
            if (pictureBox5.Left > pictureBox1.Left)
            {
                mykeeper.picname = "4";
                mykeeper.piclocini = 4;
                Form3 sensorpor = new Form3();
                sensorpor.Owner = this;
                sensorpor.ShowDialog();

            }
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage((sender as Control).Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            if (this.pictureBox6.Left < this.pictureBox1.Left)
            {
                this.pictureBox6.Location = new Point(110, 596);
 
            }
            if (pictureBox6.Left > pictureBox1.Left)
            {
                mykeeper.picname = "5";
                mykeeper.piclocini = 5;
                Form3 sensorpor = new Form3();
                sensorpor.Owner = this;
                sensorpor.ShowDialog();

            }
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage((sender as Control).Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            if (this.pictureBox7.Left < this.pictureBox1.Left)
            {
                this.pictureBox7.Location = new Point(198, 596);

            }
            if (pictureBox7.Left > pictureBox1.Left)
            {
                mykeeper.picname = "6";
                mykeeper.piclocini = 6;
                Form3 sensorpor = new Form3();
                sensorpor.Owner = this;
                sensorpor.ShowDialog();

            }
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage((sender as Control).Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            if (this.pictureBox8.Left < this.pictureBox1.Left)
            {
                this.pictureBox8.Location = new Point(294, 596);

            }
            if (pictureBox8.Left > pictureBox1.Left)
            {
                mykeeper.picname = "7";
                mykeeper.piclocini = 7;
                Form3 sensorpor = new Form3();
                sensorpor.Owner = this;
                sensorpor.ShowDialog();

            }
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage((sender as Control).Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            if (this.pictureBox9.Left < this.pictureBox1.Left)
            {
                this.pictureBox9.Location = new Point(390, 596);
            }
            if (pictureBox9.Left > pictureBox1.Left)
            {
                mykeeper.picname = "8";
                mykeeper.piclocini = 8;
                Form3 sensorpor = new Form3();
                sensorpor.Owner = this;
                sensorpor.ShowDialog();

            }
        }
        private void save_picfun()
        {
            string mapname = textBox1.Text;
            int iWidth = this.pictureBox1.Width;
            int iHeight = this.pictureBox1.Height;
            string subfol = @"D:\ALARMSYS\BlueprintCollactions\";
            if (!Directory.Exists(subfol))
            {
                Directory.CreateDirectory(subfol);
            }
            string newpath = @"D:\ALARMSYS\BlueprintCollactions\" + mapname + ".jpeg";
            Image myImage = new Bitmap(iWidth, iHeight);
            Graphics g = Graphics.FromImage(myImage);
            g.CopyFromScreen(new Point(this.Left + 572, this.Top + 52), new Point(0, 0), new Size(iWidth, iHeight));
            myImage.Save(newpath);
        }
        
        private void filewritefun()
        {
            string[] lines = { textBox1.Text, pictureBox2.Location.X.ToString() + "," + pictureBox2.Location.Y.ToString()+","+mykeeper.descripsen1, pictureBox3.Location.X.ToString() + "," + pictureBox3.Location.Y.ToString()+","+mykeeper.descripsen2, pictureBox4.Location.X.ToString() + "," + pictureBox4.Location.Y.ToString()+","+mykeeper.descripsen3, pictureBox5.Location.X.ToString() + "," + pictureBox5.Location.Y.ToString()+","+mykeeper.descripsen4,
                                 pictureBox6.Location.X.ToString() + "," + pictureBox6.Location.Y.ToString()+","+mykeeper.descripsen5, pictureBox7.Location.X.ToString() + "," + pictureBox7.Location.Y.ToString()+","+mykeeper.descripsen6, pictureBox8.Location.X.ToString() + "," + pictureBox8.Location.Y.ToString()+","+mykeeper.descripsen7, pictureBox9.Location.X.ToString() + "," + pictureBox9.Location.Y.ToString()+","+mykeeper.descripsen8,
                                 DateTime.Now.ToString(), sensornum.ToString(),mykeeper.sens1port+','+mykeeper.tempvalue1,mykeeper.sens2port+','+mykeeper.tempvalue2,mykeeper.sens3port+','+mykeeper.tempvalue3,mykeeper.sens4port+','+mykeeper.tempvalue4,mykeeper.sens5port+','+mykeeper.tempvalue5,mykeeper.sens6port+','+mykeeper.tempvalue6,mykeeper.sens7port+','+mykeeper.tempvalue7,mykeeper.sens8port+','+mykeeper.tempvalue8 };
            System.IO.File.WriteAllLines(@"D:\ALARMSYS\datefile\" + textBox1.Text + ".txt", lines);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (pic1mode == 1)
            {
                if (actimode == 0)
                {
                    MessageBox.Show("You have not choosed any sensors !");
                }
                else
                {
                    switch (sensornum)
                    {
                            
                        case 1:
                            if (pictureBox2.Left < pictureBox1.Left)
                            {
                                MessageBox.Show("At least one sensor is not in correct position !");
                            }

                            else
                            {

                                //SerialPort activeSerial2 = new SerialPort(mykeeper.sens1port, 9600, Parity.None, 8, StopBits.One);//port that picture box linked. 
                                //activeSerial2.ReadBufferSize = 128;
                                //activeSerial2.Open();
                                //string dataFromArduino2 = activeSerial2.ReadLine();//get value from sensor.
                                //string tempard = dataFromArduino2;// give value received value to the lable 
                                //activeSerial2.Close();
                                save_picfun();
                                MessageBox.Show("Saved successfuly ! ");
                                filewritefun();
                                button2_Click(null, null);
                                Form1 parent = (Form1)this.Owner;
                                parent.Form1_Load(null, null);
                                this.Close();
                                
                            }

                            break;
                        case 2:
                            if (pictureBox2.Left < pictureBox1.Left || pictureBox3.Left < pictureBox1.Left)
                            {
                                MessageBox.Show("At least one sensor is not in correct position !");
                            }
                            else
                            {
                                save_picfun();
                                MessageBox.Show("Saved successfuly ! ");
                                filewritefun();
                                button2_Click(null, null);
                                Form1 parent = (Form1)this.Owner;
                                parent.Form1_Load(null, null);
                                this.Close();
                                 
                            }
                            break;
                        case 3:
                            if (pictureBox2.Left < pictureBox1.Left || pictureBox3.Left < pictureBox1.Left || pictureBox4.Left < pictureBox1.Left)
                            {
                                MessageBox.Show("At least one sensor is not in correct position !");
                            }
                            else
                            {
                                save_picfun();
                                MessageBox.Show("Saved successfuly ! ");
                                filewritefun();
                                button2_Click(null, null);
                                Form1 parent = (Form1)this.Owner;
                                parent.Form1_Load(null, null);
                                this.Close();
                               
                            }
                            break;
                        case 4:
                            if (pictureBox2.Left < pictureBox1.Left || pictureBox3.Left < pictureBox1.Left || pictureBox4.Left < pictureBox1.Left || pictureBox5.Left < pictureBox1.Left)
                            {
                                MessageBox.Show("At least one sensor is not in correct position !");
                            }
                            else
                            {
                                save_picfun();
                                MessageBox.Show("Saved successfuly ! ");
                                filewritefun();
                                button2_Click(null, null);
                                Form1 parent = (Form1)this.Owner;
                                parent.Form1_Load(null, null);
                                this.Close();
                                
                            }
                            break;
                        case 5:
                            if (pictureBox2.Left < pictureBox1.Left || pictureBox3.Left < pictureBox1.Left || pictureBox4.Left < pictureBox1.Left || pictureBox5.Left < pictureBox1.Left || pictureBox6.Left < pictureBox1.Left)
                            {
                                MessageBox.Show("At least one sensor is not in correct position !");
                            }
                            else
                            {
                                save_picfun();
                                MessageBox.Show("Saved successfuly ! ");
                                filewritefun();
                                button2_Click(null, null);
                                Form1 parent = (Form1)this.Owner;
                                parent.Form1_Load(null, null);
                                this.Close();
                                
                            }
                            break;
                        case 6:
                            if (pictureBox2.Left < pictureBox1.Left || pictureBox3.Left < pictureBox1.Left || pictureBox4.Left < pictureBox1.Left || pictureBox5.Left < pictureBox1.Left || pictureBox6.Left < pictureBox1.Left || pictureBox7.Left < pictureBox1.Left)
                            {
                                MessageBox.Show("At least one sensor is not in correct position !");
                            }
                            else
                            {
                                save_picfun();
                                MessageBox.Show("Saved successfuly ! ");
                                filewritefun();
                                button2_Click(null, null);
                                Form1 parent = (Form1)this.Owner;
                                parent.Form1_Load(null, null);
                                this.Close();
                                
                            }
                            break;
                        case 7:

                            if (pictureBox2.Left < pictureBox1.Left || pictureBox3.Left < pictureBox1.Left || pictureBox4.Left < pictureBox1.Left || pictureBox5.Left < pictureBox1.Left || pictureBox6.Left < pictureBox1.Left || pictureBox7.Left < pictureBox1.Left || pictureBox8.Left < pictureBox1.Left)
                            {
                                MessageBox.Show("At least one sensor is not in correct position !");
                            }
                            else
                            {
                                save_picfun();
                                MessageBox.Show("Saved successfuly ! ");
                                filewritefun();
                                button2_Click(null, null);
                                Form1 parent = (Form1)this.Owner;
                                parent.Form1_Load(null, null);
                                this.Close();
                                
                            }
                            break;
                        case 8:
                            if (pictureBox2.Left < pictureBox1.Left || pictureBox3.Left < pictureBox1.Left || pictureBox4.Left < pictureBox1.Left || pictureBox5.Left < pictureBox1.Left || pictureBox6.Left < pictureBox1.Left || pictureBox7.Left < pictureBox1.Left || pictureBox8.Left < pictureBox1.Left || pictureBox9.Left < pictureBox1.Left)
                            {
                                MessageBox.Show("At least one sensor is not in correct position !");
                            }
                            else
                            {
                                save_picfun();
                                MessageBox.Show("Saved successfuly ! ");
                                filewritefun();
                                button2_Click(null, null);
                                Form1 parent = (Form1)this.Owner;
                                parent.Form1_Load(null, null);
                                this.Close();
                                
                            }
                            break;
                        default: break;         
                    }




                }


            }
            else
            {
                MessageBox.Show("Choose blueprint by importing!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            piclocationinitial();  
        }



    }
}
