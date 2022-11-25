using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AlarmSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        string data;
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
                cbxPort.Items.Add(port);

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            data = serialPort1.ReadLine();
            this.Invoke(new EventHandler(DisplayData)); 
        }
       
        private void DisplayData(object sender, EventArgs e)
        {
            string[] value = data.Split('/');
            int oku = Convert.ToInt32(value[0]);
            int hareket=Convert.ToInt32(value[1]);
            if (oku==1 && hareket == 1){// yetkisiz kart ile hareket algılandı
                panel1.BackColor = Color.Yellow;
                lblMesaj.Text = " Yetkisiz Kullanıcı - Hareket Algılandı!";
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("elagurler45@gmail.com", "sifre"),
                    EnableSsl = true
                };
                client.Send("elagurler45@gmail.com", "elagurler45@gmail.com", "Yetkisiz Kullanıcı Tarafından Hareket algılandı!", "Ortama kayıtlı olmayan kart ile giriş yapıldı.");
                 
                System.Threading.Thread.Sleep(2000); 
            }
            else if(oku ==0 && hareket == 1) {// kartsız hareket algılandı
                panel1.BackColor = Color.OrangeRed;
                lblMesaj.Text = "Ortamda Hareket Algılandı!";
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("elagurler45@gmail.com", "sifre"),
                    EnableSsl = true
                };
                client.Send("elagurler45@gmail.com", "elagurler45@gmail.com", "Hareket algılandı!", "Ortamda hareket algılandı.");
                 
                System.Threading.Thread.Sleep(2000);
             
                Console.ReadLine();
            }
            else if (oku == 1 && hareket == 0){// kartlı hareket algılandı
                panel1.BackColor = Color.LightGreen;
                lblMesaj.Text = " Yetkili Kullanıcı - Hareket Algılandı!";
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("elagurler45@gmail.com", "sifre"),
                    EnableSsl = true
                };
                client.Send("elagurler45@gmail.com", "elagurler45@gmail.com", "Yetkili Kullanıcı Tarafından Hareket algılandı!", "Ortama Yetkili kişi giriş yaptı.");       
                System.Threading.Thread.Sleep(2000); 
            } 
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                { 
                    serialPort1.PortName = cbxPort.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open();

                    lblPort.Text = "Bağlantı Sağlandı.";
                    lblPort.ForeColor = Color.Green;
                    btnBaglan.Text = "BAĞLANTIYI KES";
                }
                else
                {
                    lblPort.Text = "Bağlantı Kesildi.";
                    lblPort.ForeColor = Color.Red;
                    btnBaglan.Text = "BAĞLAN";               
                    serialPort1.Close();     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");      
            }
        }
    }
}
