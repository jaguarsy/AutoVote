using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace 通用投票软件
{
    public partial class MainForm : Form
    {
        private int limit = 10;
        private Process process = new Process();
        private string cmdStr = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            process.StartInfo.FileName = "cmd.exe";//要执行的程序名称 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;//可接受来自调用程序的输入信息 
            process.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息 
            process.StartInfo.CreateNoWindow = true;//不显示程序窗口 
            process.Start();  //启动程序 
        }

        private string PostWebRequest(string postUrl, string paramData, Encoding dataEncode)
        {
            string ret = string.Empty;
            try
            {
                byte[] byteArray = dataEncode.GetBytes(paramData); //转化
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(new Uri(postUrl));
                webReq.Method = "POST";
                webReq.ContentType = "application/x-www-form-urlencoded";
                webReq.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 8_0 like Mac OS X) AppleWebKit/600.1.3 (KHTML, like Gecko) Version/8.0 Mobile/12A4345d Safari/600.1.4";
                webReq.ContentLength = byteArray.Length;
                Stream newStream = webReq.GetRequestStream();
                newStream.Write(byteArray, 0, byteArray.Length);//写入参数
                newStream.Close();
                HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                ret = sr.ReadToEnd();
                sr.Close();
                response.Close();
                newStream.Close();
            }
            catch (Exception ex)
            {
                log(ex.Message);
            }
            return ret;
        }

        private void btBegin_Click(object sender, EventArgs e)
        {
            int.TryParse(tbLimit.Text, out limit);
            cmdStr = string.Format("rasdial {0} {1} {2}", tbEntryName.Text, tbUserName.Text, tbPassword.Text);
            timer.Start();
            btStop.Enabled = true;
            btBegin.Enabled = false;
        }

        int count = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            log(PostWebRequest(tbPostUrl.Text, tbPostData.Text, Encoding.UTF8));
            count++;
            if (count >= limit)
            {
                count = 0;
                changeIP(cmdStr);
            }
            timer.Interval = getInterval();
        }

        Random rand = new Random();
        private int getInterval()
        {
            return rand.Next(1000, 5000);
        }

        private void log(string message)
        {
            RtbLog.AppendText(message);
            RtbLog.AppendText("\n");
            RtbLog.ScrollToCaret();
        }

        private void changeIP(string cmd)
        {
            try
            {
                process.StandardInput.WriteLine(cmd);//向CMD窗口发送输入信息
                string outStr = "", tmptStr = "";
                while (tmptStr != "")
                {
                    outStr += outStr;
                    tmptStr = process.StandardOutput.ReadLine();
                }
                log(outStr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            count = 0;
            timer.Stop();
            btStop.Enabled = false;
            btBegin.Enabled = true;
        }
    }
}
