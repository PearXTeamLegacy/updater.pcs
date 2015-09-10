using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace updater.pcs
{
    public partial class Main : Form
    {

        public static WebClient client = new WebClient();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            labelDownloading.Text = "Удаление старого файла игры...";
            File.Delete("pcs.exe");
            labelDownloading.Text = "Переименовывание нового файла игры...";
            File.Move("new.pcs.exe", "pcs.exe");
            labelDownloading.Text = "Все готово!";
            Process.Start("pcs.exe");
            Application.Exit();
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            barDownloading.Maximum = (int)e.TotalBytesToReceive / 100;
            barDownloading.Value = (int)e.BytesReceived / 100;
            labelDownloading.Text = "Загрузка игры... (" + e.ProgressPercentage + "%)";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            client.DownloadFileAsync(new Uri("http://pcs.pearx.ru/pcs.exe"), "new.pcs.exe");
        }
    }
}
