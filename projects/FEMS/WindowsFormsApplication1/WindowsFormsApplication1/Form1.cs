using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.IO.Ports;
using System.Drawing.Imaging;
namespace WindowsFormsApplication1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "SteelBlue.ssk";
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            label8.Text = "00";
            label9.Text = "00";
            label11.Text = "00";
            this.pictureBox2.Image = this.imageList1.Images[0];
            this.pictureBox3.Image = this.imageList1.Images[2];
            this.pictureBox4.Image = this.imageList1.Images[4];
            this.pictureBox5.Image = this.imageList1.Images[6];
            this.pictureBox6.Image = this.imageList1.Images[8];
            this.pictureBox7.Image = this.imageList1.Images[10];
            this.pictureBox8.Image = this.imageList1.Images[12];
            this.pictureBox9.Image = this.imageList1.Images[14];
            timer2.Enabled = true;
            additemcom();

            




        }

        public void additemcom()
        {
            string[] fileEntries = Directory.GetFiles(@"D:\ALARMSYS\BlueprintCollactions\");
            foreach (string fileName in fileEntries)
                if (!comboBox1.Items.Contains(fileName))
                {
                    comboBox1.Items.Add(fileName);
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                Bitmap bmp = new Bitmap(comboBox1.SelectedItem.ToString());
                //新建第二个bitmap类型的bmp2变量，。
                Bitmap bmp2 = new Bitmap(pictureBox1.Width,pictureBox1.Height,PixelFormat.Format16bppRgb555);
                //将第一个bmp拷贝到bmp2中
                Graphics draw = Graphics.FromImage(bmp2);
                draw.DrawImage(bmp,0,0);
                //读取bmp2到getPhoto
                pictureBox1.Image =bmp2;
                draw.Dispose();
                bmp.Dispose();//释放bmp文件资源
                string getfiletxt = comboBox1.SelectedItem.ToString();
                string mytxt = getfiletxt.Substring(32);
                string[] mytxt2 = mytxt.Split('.');
                string path = @"D:\ALARMSYS\datefile\" + mytxt2[0] + ".txt";
                string pic2pos = File.ReadAllLines(path).Skip(1).Take(1).First();
                string pic3pos = File.ReadAllLines(path).Skip(2).Take(1).First();
                string pic4pos = File.ReadAllLines(path).Skip(3).Take(1).First();
                string pic5pos = File.ReadAllLines(path).Skip(4).Take(1).First();
                string pic6pos = File.ReadAllLines(path).Skip(5).Take(1).First();
                string pic7pos = File.ReadAllLines(path).Skip(6).Take(1).First();
                string pic8pos = File.ReadAllLines(path).Skip(7).Take(1).First();
                string pic9pos = File.ReadAllLines(path).Skip(8).Take(1).First();
                string sensornum = File.ReadAllLines(path).Skip(10).Take(1).First();
                switch (sensornum)
                {
                    case "1":
                        {
                            pictureBox2.Visible = true;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = false;
                            pictureBox5.Visible = false;
                            pictureBox6.Visible = false;
                            pictureBox7.Visible = false;
                            pictureBox8.Visible = false;
                            pictureBox9.Visible = false;
                            string[] coords1 = pic2pos.Split(',');
                            string X2 = coords1[0];
                            string Y2 = coords1[1];
                            pictureBox2.Location = new Point(Convert.ToInt32(X2), Convert.ToInt32(Y2));
                            
                        }
                        break;
                    case "2":
                        {
                            pictureBox2.Visible = true;
                            string[] coords1 = pic2pos.Split(',');
                            string X2 = coords1[0];
                            string Y2 = coords1[1];
                            pictureBox2.Location = new Point(Convert.ToInt32(X2), Convert.ToInt32(Y2));
                            pictureBox3.Visible = true;
                            string[] coords2 = pic3pos.Split(',');
                            string X3 = coords2[0];
                            string Y3 = coords2[1];
                            pictureBox3.Location = new Point(Convert.ToInt32(X3), Convert.ToInt32(Y3));
                            pictureBox4.Visible = false;
                            pictureBox5.Visible = false;
                            pictureBox6.Visible = false;
                            pictureBox7.Visible = false;
                            pictureBox8.Visible = false;
                            pictureBox9.Visible = false;
                        }
                        break;
                    case "3":
                        {
                            pictureBox2.Visible = true;
                            string[] coords1 = pic2pos.Split(',');
                            string X2 = coords1[0];
                            string Y2 = coords1[1];
                            pictureBox2.Location = new Point(Convert.ToInt32(X2), Convert.ToInt32(Y2));
                            pictureBox3.Visible = true;
                            string[] coords2 = pic3pos.Split(',');
                            string X3 = coords2[0];
                            string Y3 = coords2[1];
                            pictureBox3.Location = new Point(Convert.ToInt32(X3), Convert.ToInt32(Y3));
                            pictureBox4.Visible = true;
                            string[] coords3 = pic4pos.Split(',');
                            string X4 = coords3[0];
                            string Y4 = coords3[1];
                            pictureBox4.Location = new Point(Convert.ToInt32(X4), Convert.ToInt32(Y4));
                            pictureBox5.Visible = false;
                            pictureBox6.Visible = false;
                            pictureBox7.Visible = false;
                            pictureBox8.Visible = false;
                            pictureBox9.Visible = false;
                        }
                        break;
                    case "4":
                        {
                            pictureBox2.Visible = true;
                            string[] coords1 = pic2pos.Split(',');
                            string X2 = coords1[0];
                            string Y2 = coords1[1];
                            pictureBox2.Location = new Point(Convert.ToInt32(X2), Convert.ToInt32(Y2));
                            pictureBox3.Visible = true;
                            string[] coords2 = pic3pos.Split(',');
                            string X3 = coords2[0];
                            string Y3 = coords2[1];
                            pictureBox3.Location = new Point(Convert.ToInt32(X3), Convert.ToInt32(Y3));
                            pictureBox4.Visible = true;
                            string[] coords3 = pic4pos.Split(',');
                            string X4 = coords3[0];
                            string Y4 = coords3[1];
                            pictureBox4.Location = new Point(Convert.ToInt32(X4), Convert.ToInt32(Y4));
                            pictureBox5.Visible = true;
                            string[] coords4 = pic5pos.Split(',');
                            string X5 = coords4[0];
                            string Y5 = coords4[1];
                            pictureBox5.Location = new Point(Convert.ToInt32(X5), Convert.ToInt32(Y5));
                            pictureBox6.Visible = false;
                            pictureBox7.Visible = false;
                            pictureBox8.Visible = false;
                            pictureBox9.Visible = false;
                        }
                        break;
                    case "5":
                        {
                            pictureBox2.Visible = true;
                            string[] coords1 = pic2pos.Split(',');
                            string X2 = coords1[0];
                            string Y2 = coords1[1];
                            pictureBox2.Location = new Point(Convert.ToInt32(X2), Convert.ToInt32(Y2));
                            pictureBox3.Visible = true;
                            string[] coords2 = pic3pos.Split(',');
                            string X3 = coords2[0];
                            string Y3 = coords2[1];
                            pictureBox3.Location = new Point(Convert.ToInt32(X3), Convert.ToInt32(Y3));
                            pictureBox4.Visible = true;
                            string[] coords3 = pic4pos.Split(',');
                            string X4 = coords3[0];
                            string Y4 = coords3[1];
                            pictureBox4.Location = new Point(Convert.ToInt32(X4), Convert.ToInt32(Y4));
                            pictureBox5.Visible = true;
                            string[] coords4 = pic5pos.Split(',');
                            string X5 = coords4[0];
                            string Y5 = coords4[1];
                            pictureBox5.Location = new Point(Convert.ToInt32(X5), Convert.ToInt32(Y5));
                            pictureBox6.Visible = true;
                            string[] coords5 = pic6pos.Split(',');
                            string X6 = coords5[0];
                            string Y6 = coords5[1];
                            pictureBox6.Location = new Point(Convert.ToInt32(X6), Convert.ToInt32(Y6));
                            pictureBox7.Visible = false;
                            pictureBox8.Visible = false;
                            pictureBox9.Visible = false;
                        }
                        break;
                    case "6":
                        {
                            pictureBox2.Visible = true;
                            string[] coords1 = pic2pos.Split(',');
                            string X2 = coords1[0];
                            string Y2 = coords1[1];
                            pictureBox2.Location = new Point(Convert.ToInt32(X2), Convert.ToInt32(Y2));
                            pictureBox3.Visible = true;
                            string[] coords2 = pic3pos.Split(',');
                            string X3 = coords2[0];
                            string Y3 = coords2[1];
                            pictureBox3.Location = new Point(Convert.ToInt32(X3), Convert.ToInt32(Y3));
                            pictureBox4.Visible = true;
                            string[] coords3 = pic4pos.Split(',');
                            string X4 = coords3[0];
                            string Y4 = coords3[1];
                            pictureBox4.Location = new Point(Convert.ToInt32(X4), Convert.ToInt32(Y4));
                            pictureBox5.Visible = true;
                            string[] coords4 = pic5pos.Split(',');
                            string X5 = coords4[0];
                            string Y5 = coords4[1];
                            pictureBox5.Location = new Point(Convert.ToInt32(X5), Convert.ToInt32(Y5));
                            pictureBox6.Visible = true;
                            string[] coords5 = pic6pos.Split(',');
                            string X6 = coords5[0];
                            string Y6 = coords5[1];
                            pictureBox6.Location = new Point(Convert.ToInt32(X6), Convert.ToInt32(Y6));
                            pictureBox7.Visible = true;
                            string[] coords6 = pic7pos.Split(',');
                            string X7 = coords6[0];
                            string Y7 = coords6[1];
                            pictureBox7.Location = new Point(Convert.ToInt32(X7), Convert.ToInt32(Y7));
                            pictureBox8.Visible = false;
                            pictureBox9.Visible = false;
                        }
                        break;
                    case "7":
                        {
                            pictureBox2.Visible = true;
                            string[] coords1 = pic2pos.Split(',');
                            string X2 = coords1[0];
                            string Y2 = coords1[1];
                            pictureBox2.Location = new Point(Convert.ToInt32(X2), Convert.ToInt32(Y2));
                            pictureBox3.Visible = true;
                            string[] coords2 = pic3pos.Split(',');
                            string X3 = coords2[0];
                            string Y3 = coords2[1];
                            pictureBox3.Location = new Point(Convert.ToInt32(X3), Convert.ToInt32(Y3));
                            pictureBox4.Visible = true;
                            string[] coords3 = pic4pos.Split(',');
                            string X4 = coords3[0];
                            string Y4 = coords3[1];
                            pictureBox4.Location = new Point(Convert.ToInt32(X4), Convert.ToInt32(Y4));
                            pictureBox5.Visible = true;
                            string[] coords4 = pic5pos.Split(',');
                            string X5 = coords4[0];
                            string Y5 = coords4[1];
                            pictureBox5.Location = new Point(Convert.ToInt32(X5), Convert.ToInt32(Y5));
                            pictureBox6.Visible = true;
                            string[] coords5 = pic6pos.Split(',');
                            string X6 = coords5[0];
                            string Y6 = coords5[1];
                            pictureBox6.Location = new Point(Convert.ToInt32(X6), Convert.ToInt32(Y6));
                            pictureBox7.Visible = true;
                            string[] coords6 = pic7pos.Split(',');
                            string X7 = coords6[0];
                            string Y7 = coords6[1];
                            pictureBox7.Location = new Point(Convert.ToInt32(X7), Convert.ToInt32(Y7));
                            pictureBox8.Visible = true;
                            string[] coords7 = pic8pos.Split(',');
                            string X8 = coords7[0];
                            string Y8 = coords7[1];
                            pictureBox8.Location = new Point(Convert.ToInt32(X8), Convert.ToInt32(Y8));
                            pictureBox9.Visible = false;
                        }
                        break;
                    case "8":
                        {
                            pictureBox2.Visible = true;
                            string[] coords1 = pic2pos.Split(',');
                            string X2 = coords1[0];
                            string Y2 = coords1[1];
                            pictureBox2.Location = new Point(Convert.ToInt32(X2), Convert.ToInt32(Y2));
                            pictureBox3.Visible = true;
                            string[] coords2 = pic3pos.Split(',');
                            string X3 = coords2[0];
                            string Y3 = coords2[1];
                            pictureBox3.Location = new Point(Convert.ToInt32(X3), Convert.ToInt32(Y3));
                            pictureBox4.Visible = true;
                            string[] coords3 = pic4pos.Split(',');
                            string X4 = coords3[0];
                            string Y4 = coords3[1];
                            pictureBox4.Location = new Point(Convert.ToInt32(X4), Convert.ToInt32(Y4));
                            pictureBox5.Visible = true;
                            string[] coords4 = pic5pos.Split(',');
                            string X5 = coords4[0];
                            string Y5 = coords4[1];
                            pictureBox5.Location = new Point(Convert.ToInt32(X5), Convert.ToInt32(Y5));
                            pictureBox6.Visible = true;
                            string[] coords5 = pic6pos.Split(',');
                            string X6 = coords5[0];
                            string Y6 = coords5[1];
                            pictureBox6.Location = new Point(Convert.ToInt32(X6), Convert.ToInt32(Y6));
                            pictureBox7.Visible = true;
                            string[] coords6 = pic7pos.Split(',');
                            string X7 = coords6[0];
                            string Y7 = coords6[1];
                            pictureBox7.Location = new Point(Convert.ToInt32(X7), Convert.ToInt32(Y7));
                            pictureBox8.Visible = true;
                            string[] coords7 = pic8pos.Split(',');
                            string X8 = coords7[0];
                            string Y8 = coords7[1];
                            pictureBox8.Location = new Point(Convert.ToInt32(X8), Convert.ToInt32(Y8));
                            pictureBox9.Visible = true;
                            string[] coords8 = pic9pos.Split(',');
                            string X9 = coords8[0];
                            string Y9 = coords8[1];
                            pictureBox9.Location = new Point(Convert.ToInt32(X9), Convert.ToInt32(Y9));
                        }
                        break;
                }
            }
            else
            {
                comboBox1.SelectedIndex = -1;
                MessageBox.Show("Check your connections !");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            additemcom();
        }


        int activesen;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

             timer1.Enabled = true;
             activesen = 1; 

        }
        string tempard;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label3.Text = "";
            mytemfun();
            label3.Text = tempard;

        }
        private void mytemfun()
        {

            string getfiletxt = comboBox1.SelectedItem.ToString();
            string mytxt = getfiletxt.Substring(32);
            string[] mytxt2 = mytxt.Split('.');// 
            string path = @"D:\ALARMSYS\datefile\" + mytxt2[0] + ".txt";
            switch (activesen)
            {
                
                case 1:
                    try
                    {
                        string pic2pos = File.ReadAllLines(path).Skip(11).Take(1).First();
                        string[] portname = pic2pos.Split(',');
                        SerialPort activeSerial1 = new SerialPort(portname[0], 9600, Parity.None, 8, StopBits.One);//port that picture box linked. 
                        activeSerial1.ReadBufferSize = 128;
                        activeSerial1.Open();
                        string dataFromArduino1 = activeSerial1.ReadLine();//get value from sensor.
                        string[] temp = dataFromArduino1.Split(',');
                        tempard = temp[0];// give value received value to the lable 
                        activeSerial1.Close();
                        string pathtxt = @"D:\ALARMSYS\datefile\" + mytxt2[0] + ".txt";
                        string takedes = File.ReadAllLines(path).Skip(1).Take(1).First();
                        string[] desc = takedes.Split(',');
                        label5.Text = desc[2];
                        string takeres = File.ReadAllLines(path).Skip(11).Take(1).First();
                        string[] res = takeres.Split(',');
                        label15.Text = res[1];
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Lost connnection with this port!");
                      
                    }

                    break;
                case 2:
                    try
                    {
                        string pic3pos = File.ReadAllLines(path).Skip(12).Take(1).First();
                        string[] portname = pic3pos.Split(',');
                        SerialPort activeSerial2 = new SerialPort(portname[0], 9600, Parity.None, 8, StopBits.One);//port that picture box linked. 
                        activeSerial2.ReadBufferSize = 128;
                        activeSerial2.Open();
                        string dataFromArduino2 = activeSerial2.ReadLine();//get value from sensor.
                        tempard = dataFromArduino2;// give value received value to the lable 
                        activeSerial2.Close();
                        string pathtxt = @"D:\ALARMSYS\datefile\" + mytxt2[0] + ".txt";
                        string takedes = File.ReadAllLines(path).Skip(2).Take(1).First();
                        string[] desc = takedes.Split(',');
                        label5.Text = desc[2];
                        string takeres = File.ReadAllLines(path).Skip(12).Take(1).First();
                        string[] res = takeres.Split(',');
                        label15.Text = res[1];
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lost connnection with this port!");
                    }
                    break;
                case 3:
                    try
                    {
                        string pic4pos = File.ReadAllLines(path).Skip(13).Take(1).First();
                        string[] portname = pic4pos.Split(',');
                        SerialPort activeSerial3 = new SerialPort(portname[0], 9600, Parity.None, 8, StopBits.One);//port that picture box linked. 
                        activeSerial3.ReadBufferSize = 128;
                        activeSerial3.Open();
                        string dataFromArduino3 = activeSerial3.ReadLine();//get value from sensor.
                        tempard = dataFromArduino3;// give value received value to the lable 
                        activeSerial3.Close();
                        string pathtxt = @"D:\ALARMSYS\datefile\" + mytxt2[0] + ".txt";
                        string takedes = File.ReadAllLines(path).Skip(3).Take(1).First();
                        string[] desc = takedes.Split(',');
                        label5.Text = desc[2];
                        string takeres = File.ReadAllLines(path).Skip(13).Take(1).First();
                        string[] res = takeres.Split(',');
                        label15.Text = res[1];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lost connnection with this port!");
                    }
                    break;
                case 4:
                    try
                    {
                        string pic5pos = File.ReadAllLines(path).Skip(14).Take(1).First();
                        string[] portname = pic5pos.Split(',');
                        SerialPort activeSerial4 = new SerialPort(portname[0], 9600, Parity.None, 8, StopBits.One);//port that picture box linked. 
                        activeSerial4.ReadBufferSize = 128;
                        activeSerial4.Open();
                        string dataFromArduino4 = activeSerial4.ReadLine();//get value from sensor.
                        tempard = dataFromArduino4;// give value received value to the lable 
                        activeSerial4.Close();
                        string pathtxt = @"D:\ALARMSYS\datefile\" + mytxt2[0] + ".txt";
                        string takedes = File.ReadAllLines(path).Skip(4).Take(1).First();
                        string[] desc = takedes.Split(',');
                        label5.Text = desc[2];
                        string takeres = File.ReadAllLines(path).Skip(14).Take(1).First();
                        string[] res = takeres.Split(',');
                        label15.Text = res[1];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lost connnection with this port!");
                    }
                    break;
                case 5:
                    try
                    {
                        string pic6pos = File.ReadAllLines(path).Skip(15).Take(1).First();
                        string[] portname = pic6pos.Split(',');
                        SerialPort activeSerial5 = new SerialPort(portname[0], 9600, Parity.None, 8, StopBits.One);//port that picture box linked. 
                        activeSerial5.ReadBufferSize = 128;
                        activeSerial5.Open();
                        string dataFromArduino5 = activeSerial5.ReadLine();//get value from sensor.
                        tempard = dataFromArduino5;// give value received value to the lable 
                        activeSerial5.Close();
                        string pathtxt = @"D:\ALARMSYS\datefile\" + mytxt2[0] + ".txt";
                        string takedes = File.ReadAllLines(path).Skip(5).Take(1).First();
                        string[] desc = takedes.Split(',');
                        label5.Text = desc[2];
                        string takeres = File.ReadAllLines(path).Skip(15).Take(1).First();
                        string[] res = takeres.Split(',');
                        label15.Text = res[1];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lost connnection with this port!");
                    }
                    break;
                case 6:
                    try
                    {
                        string pic7pos = File.ReadAllLines(path).Skip(16).Take(1).First();
                        string[] portname = pic7pos.Split(',');
                        SerialPort activeSerial6 = new SerialPort(portname[0], 9600, Parity.None, 8, StopBits.One);//port that picture box linked. 
                        activeSerial6.ReadBufferSize = 128;
                        activeSerial6.Open();
                        string dataFromArduino6 = activeSerial6.ReadLine();//get value from sensor.
                        tempard = dataFromArduino6;// give value received value to the lable 
                        activeSerial6.Close();
                        string pathtxt = @"D:\ALARMSYS\datefile\" + mytxt2[0] + ".txt";
                        string takedes = File.ReadAllLines(path).Skip(6).Take(1).First();
                        string[] desc = takedes.Split(',');
                        label5.Text = desc[2];
                        string takeres = File.ReadAllLines(path).Skip(16).Take(1).First();
                        string[] res = takeres.Split(',');
                        label15.Text = res[1];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lost connnection with this port!");
                    }
                    break;
                case 7:
                    try
                    {
                        string pic8pos = File.ReadAllLines(path).Skip(17).Take(1).First();
                        string[] portname = pic8pos.Split(',');
                        SerialPort activeSerial7 = new SerialPort(portname[0], 9600, Parity.None, 8, StopBits.One);//port that picture box linked. 
                        activeSerial7.ReadBufferSize = 128;
                        activeSerial7.Open();
                        string dataFromArduino7 = activeSerial7.ReadLine();//get value from sensor.
                        tempard = dataFromArduino7;// give value received value to the lable 
                        activeSerial7.Close();
                        string pathtxt = @"D:\ALARMSYS\datefile\" + mytxt2[0] + ".txt";
                        string takedes = File.ReadAllLines(path).Skip(7).Take(1).First();
                        string[] desc = takedes.Split(',');
                        label5.Text = desc[2];
                        string takeres = File.ReadAllLines(path).Skip(17).Take(1).First();
                        string[] res = takeres.Split(',');
                        label15.Text = res[1];
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lost connnection with this port!");
                    }
                    break;
                case 8:
                    try
                    {
                        string pic9pos = File.ReadAllLines(path).Skip(18).Take(1).First();
                        string[] portname = pic9pos.Split(',');
                        SerialPort activeSerial8 = new SerialPort(portname[0], 9600, Parity.None, 8, StopBits.One);//port that picture box linked. 
                        activeSerial8.ReadBufferSize = 128;
                        activeSerial8.Open();
                        string dataFromArduino8 = activeSerial8.ReadLine();//get value from sensor.
                        tempard = dataFromArduino8;// give value received value to the lable 
                        activeSerial8.Close();
                        string pathtxt = @"D:\ALARMSYS\datefile\" + mytxt2[0] + ".txt";
                        string takedes = File.ReadAllLines(path).Skip(8).Take(1).First();
                        string[] desc = takedes.Split(',');
                        label5.Text = desc[2];
                        string takeres = File.ReadAllLines(path).Skip(18).Take(1).First();
                        string[] res = takeres.Split(',');
                        label15.Text = res[1];
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lost connnection with this port!");
                    }
                    break;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string tempard1; 
            string soundpath = @"d:\ALARMSYS\sounds\lostconnection.wav";
            string pathforfire = @"d:\ALARMSYS\sounds\fire.wav";
            string[] ports = SerialPort.GetPortNames();
            int portsani = ports.Length;
            label11.Text = portsani.ToString();
            if (ports.Length == 0)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundpath);
                player.PlayLooping();
                string message = "Computer has jut lost connections, please check the connection !";
                string caption = "Lost connections !";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                Form1_Load(null,null);
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    player.Stop();
                }
            }
            else
            {

                int sani = comboBox1.Items.Count;
                label8.Text = sani.ToString();
                int saniumum = 0;
                for (int j = 0; j <= comboBox1.Items.Count - 1; j++)
                {
                    string filename = comboBox1.Items[j].ToString().Replace("BlueprintCollactions", "datefile");
                    string filefinal = filename.Replace("jpeg", "txt");
                    string detectdesc = File.ReadAllLines(filefinal).Skip(10).Take(1).First();
                    int sensorsani = Convert.ToInt32(detectdesc);
                    saniumum = saniumum + sensorsani;

                }
                label9.Text = saniumum.ToString();
                string datefilepath = @"d:\ALARMSYS\datefile\";        
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(datefilepath);
                int count = dir.GetFiles().Length;
                if (count != 0)
                {
                    for (int i = 0; i < ports.Length; i++)
                    {
                        SerialPort activeSerial8 = new SerialPort(ports[i], 9600, Parity.None, 8, StopBits.One);//port that picture box linked. 
                        activeSerial8.ReadBufferSize = 128;
                        activeSerial8.Open();
                        string dataFromArduino8 = activeSerial8.ReadLine();//get value from sensor.
                        tempard1 = dataFromArduino8;// give value received value to the lable
                        activeSerial8.Close();
                        for (int j = 0; j < comboBox1.Items.Count; j++)
                        {
                        string filename = comboBox1.Items[j].ToString().Replace("BlueprintCollactions", "datefile");
                        string filefinal = filename.Replace("jpeg", "txt");
                        for (int t = 11; t <= 18; t++)
                        {
                                string tempinfile = File.ReadAllLines(filefinal).Skip(t).Take(1).First();
                                string[] tempinfilesplit = tempinfile.Split(',');
                                string getmytempval = tempinfilesplit[1].ToString();
                                string realval = tempard1.TrimEnd('\r');
                                try  {
                                    if (Convert.ToDecimal(realval) > Convert.ToDecimal(getmytempval) && tempinfilesplit[0].Length == 4)
                                    {
                                        int yellow = t;
                                        switch (yellow)
                                        {
                                            case 11:
                                                pictureBox2.Image = imageList1.Images[1];
                                                pictureBox2_Click(null, null);
                                                pictureBox3.Image = imageList1.Images[2];
                                                pictureBox4.Image = imageList1.Images[4];
                                                pictureBox5.Image = imageList1.Images[6];
                                                pictureBox6.Image = imageList1.Images[8];
                                                pictureBox7.Image = imageList1.Images[10];
                                                pictureBox8.Image = imageList1.Images[12];
                                                pictureBox9.Image = imageList1.Images[14];
                                                break;
                                            case 12:
                                                pictureBox2.Image = imageList1.Images[0];
                                                pictureBox3.Image = imageList1.Images[3];
                                                pictureBox3_Click(null, null);
                                                pictureBox4.Image = imageList1.Images[4];
                                                pictureBox5.Image = imageList1.Images[6];
                                                pictureBox6.Image = imageList1.Images[8];
                                                pictureBox7.Image = imageList1.Images[10];
                                                pictureBox8.Image = imageList1.Images[12];
                                                pictureBox9.Image = imageList1.Images[14];
                                                break;
                                            case 13:
                                                pictureBox2.Image = imageList1.Images[0];
                                                pictureBox3.Image = imageList1.Images[2];
                                                pictureBox4.Image = imageList1.Images[5];
                                                pictureBox4_Click(null, null);
                                                pictureBox5.Image = imageList1.Images[6];
                                                pictureBox6.Image = imageList1.Images[8];
                                                pictureBox7.Image = imageList1.Images[10];
                                                pictureBox8.Image = imageList1.Images[12];
                                                pictureBox9.Image = imageList1.Images[14];
                                                break;
                                            case 14:
                                                pictureBox2.Image = imageList1.Images[0];
                                                pictureBox3.Image = imageList1.Images[2];
                                                pictureBox4.Image = imageList1.Images[4];
                                                pictureBox5.Image = imageList1.Images[7];
                                                pictureBox5_Click(null, null);
                                                pictureBox6.Image = imageList1.Images[8];
                                                pictureBox7.Image = imageList1.Images[10];
                                                pictureBox8.Image = imageList1.Images[12];
                                                pictureBox9.Image = imageList1.Images[14];
                                                break;
                                            case 15:
                                                pictureBox2.Image = imageList1.Images[0];
                                                pictureBox3.Image = imageList1.Images[2];
                                                pictureBox4.Image = imageList1.Images[4];
                                                pictureBox5.Image = imageList1.Images[6];
                                                pictureBox6.Image = imageList1.Images[9];
                                                pictureBox6_Click(null, null);
                                                pictureBox7.Image = imageList1.Images[10];
                                                pictureBox8.Image = imageList1.Images[12];
                                                pictureBox9.Image = imageList1.Images[14];
                                                break;
                                            case 16:
                                                pictureBox2.Image = imageList1.Images[0];
                                                pictureBox3.Image = imageList1.Images[2];
                                                pictureBox4.Image = imageList1.Images[4];
                                                pictureBox5.Image = imageList1.Images[6];
                                                pictureBox6.Image = imageList1.Images[8];
                                                pictureBox7.Image = imageList1.Images[11];
                                                pictureBox7_Click(null, null);
                                                pictureBox8.Image = imageList1.Images[12];
                                                pictureBox9.Image = imageList1.Images[14];
                                                break;
                                            case 17:
                                                pictureBox2.Image = imageList1.Images[0];
                                                pictureBox3.Image = imageList1.Images[2];
                                                pictureBox4.Image = imageList1.Images[4];
                                                pictureBox5.Image = imageList1.Images[6];
                                                pictureBox6.Image = imageList1.Images[8];
                                                pictureBox7.Image = imageList1.Images[10];
                                                pictureBox8.Image = imageList1.Images[13];
                                                pictureBox8_Click(null, null);
                                                pictureBox9.Image = imageList1.Images[14];
                                                break;
                                            case 18:
                                                pictureBox2.Image = imageList1.Images[0];
                                                pictureBox3.Image = imageList1.Images[2];
                                                pictureBox4.Image = imageList1.Images[4];
                                                pictureBox5.Image = imageList1.Images[6];
                                                pictureBox6.Image = imageList1.Images[8];
                                                pictureBox7.Image = imageList1.Images[10];
                                                pictureBox8.Image = imageList1.Images[12];
                                                pictureBox9.Image = imageList1.Images[15];
                                                pictureBox9_Click(null, null);
                                                break;
                                        }
                                        comboBox1.SelectedIndex = j;
                                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(pathforfire);
                                        player.PlayLooping();
                                        timer2.Enabled = false;
                                        string message = "High temperature detected!";
                                        string caption = "Caution!";
                                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                        DialogResult result;
                                        result = MessageBox.Show(message, caption, buttons);
                                        if (result == System.Windows.Forms.DialogResult.Yes)
                                        {
                                            player.Stop();
                                            timer2.Enabled = true;
                                        }
                                        else
                                        {
                                            timer2.Enabled = true;

                                        }
                                    }
                                    
                                }
                            catch (FormatException) {}
                            }
                        }
                    }
                }

            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            activesen = 2; 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            activesen = 3; 
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            activesen = 4; 
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            activesen = 5; 
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            activesen = 6; 
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            activesen = 7; 
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            activesen = 8; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1_Load(null,null);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                pictureBox1.Image = null;
                string getfiletxt = comboBox1.SelectedItem.ToString();
                string mytxt = getfiletxt.Substring(32);
                string[] mytxt2 = mytxt.Split('.');// 
                string path = @"D:\ALARMSYS\datefile\" + mytxt2[0] + ".txt";
                File.Delete(path);
                File.Delete(comboBox1.SelectedItem.ToString());
                comboBox1.Items.Clear();
                Form1_Load(null,null);
                timer1.Enabled = false;
                label3.Text = "";
                label5.Text = "";
                MessageBox.Show("Seccessfuly Deleted !");
            }
            else
            {
                MessageBox.Show("Select a Blueprint!");
            }


        }
        






    }
}


