using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos_Delegados
{
    public partial class Form1 : Form
    {
        Video video1 = new Video() { Title = "Video 1" };
        VideoEncoder videoEncoder1 = new VideoEncoder(); //Publicador
        MailService mailservice1 = new MailService(); //Subscripor
        Message_Service messageservice1 = new Message_Service(); //Subscripor
        
        public Form1()
        {
            InitializeComponent();
            videoEncoder1.VideoEncoded += messageservice1.OnVideoEncoded;
            videoEncoder1.VideoEncoded += mailservice1.OnVideoEncoded;
            //Limpiar TextBox
            this.txt_Texto.GotFocus += txt_Texto_TextFocus;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoEncoder1.Encode(video1);
        }

        private void txt_Texto_TextFocus(object sender, EventArgs e)
        {
            txt_Texto.Text = "";
        }
    }
}
