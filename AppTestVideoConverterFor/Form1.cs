using Accord.Video.FFMPEG;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTestVideoConverterFor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        string file;
        string url_save;
        string itemname;
        static string[] mediaExtensions = {
           // ".PNG", ".JPG", ".JPEG", ".BMP", ".GIF", //etc
            ".WAV", ".MID", ".MIDI", ".WMA", ".MP3", ".OGG", ".RMA", //etc
            ".AVI", ".MP4", ".DIVX", ".WMV", //etc
            };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar.Visible = false;
            CountFramesLabel.Visible = false;

            Task.Run(() => TackProcessCpuAndMemory());
        }

        /// <summary>
        /// เช็คว่าเป็นไฟล์ media หรือเปล่า
        /// </summary>
        /// <param name="path">ที่อยู่ไฟล์</param>
        /// <returns></returns>
        static bool IsMediaFile(string path)
        {
            return -1 != Array.IndexOf(mediaExtensions, Path.GetExtension(path).ToUpperInvariant());
        }

        /// <summary>
        /// ปุ่มเลือกไฟล์ วีดีโอ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3;*.mp4|All Files|*.*";
           // f.Multiselect = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (f.FileName != null)
                {
                    var CheckFile = IsMediaFile(f.FileName);
                    if (CheckFile == true)
                    {
                        file = f.FileName.Trim();
                        LUrl.Text = f.FileName.Trim();
                    }
                    else
                    {
                        //ProgressText(1,"### รูปแบบไฟล์ไม่ถูกต้อง " + f.FileName + " ###");
                        MessageBox.Show("รูปแบบไฟล์ไม่ถูกต้อง. " + f.FileName.Trim(), "แจ้งเตือน");
                    }
                }
            }
        }

        /// <summary>
        /// ปุ่มเลือกไฟล์ บันทึก
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButVdoSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (f.SelectedPath != null && f.SelectedPath.Trim().Length > 0)
                {
                    SUrl.Text = string.Format("{0}\\", f.SelectedPath.Trim());
                    url_save = string.Format("{0}\\", f.SelectedPath.Trim());
                }
                else
                {
                    //ProgressText(1,"### ที่บันทึกไฟล์ผิดพลาด " + f.SelectedPath + " ###");
                    MessageBox.Show("ที่บันทึกไฟล์ผิดพลาด. " + f.SelectedPath.Trim(), "แจ้งเตือน");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BConverter_Click(object sender, EventArgs e)
        {

            if (file == null)
            {
                MessageBox.Show("ยังไม่ได้เลือกไฟล์.", "แจ้งเตือน");
            }
            else if (url_save == null)
            {
                MessageBox.Show("ยังไม่ได้เลือกที่อยู่ที่จะทำการบันทึกไฟล์.", "แจ้งเตือน");
            }
            else if (TBoxName != null && TBoxName.Text.Length <= 0) 
            {
                MessageBox.Show("โปรดตั้งชื่อรูปภาพ.", "แจ้งเตือน");
            }
            else
            {
                BOpen.Enabled = false;
                BSave.Enabled = false;
                BConverter.Enabled = false;
                progressBar.Minimum = 0;
                progressBar.Visible = true;
                CountFramesLabel.Visible = true;
                TextBox objTextBox = (TextBox)TBoxName;
                if (objTextBox != null && objTextBox.Text.Trim().Length > 0)
                {
                    itemname = objTextBox.Text.Trim();
                }

                if (url_save == null && url_save.Trim().Length <= 0 && itemname == null && itemname.Trim().Length <= 0) {
                    MessageBox.Show("ไม่พบที่อยู่ที่จะทำการบันทึก กรุณาเลือกที่อยู่ที่จะทำการบันทึก.", "แจ้งเตือน");
                }

                Task.Run(() => ConverterForFfmpeg(file));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        private void ConverterForFfmpeg(string file)
        {
            try
            {
                using (var vFReader = new VideoFileReader())
                {
                    vFReader.Open(file);
                    ProgressBarRun(1, (int)vFReader.FrameCount);
                    TextFrames((int)vFReader.FrameCount);
                    ProgressText(3, "---- เริ่มทำงาน ----");
                    Directory.CreateDirectory(url_save + itemname);

                    for (int i = 0; i < vFReader.FrameCount; i++)
                    {
                        using (Bitmap bmpBaseOriginal = vFReader.ReadVideoFrame())
                        {
                            DateTime Dtime = DateTime.Now;
                            string PSave = url_save + itemname + "\\" + Dtime.Year + Dtime.Month + Dtime.Day + Dtime.Hour + Dtime.Minute + Dtime.Second + itemname + i + ".jpg";
                            bmpBaseOriginal.Save(PSave, ImageFormat.Jpeg);
                            ProgressBarRun(3, i);
                            ProgressText(3, PSave);
                        }
                    }
                    vFReader.Close();
                }
                Task.Delay(800).ContinueWith(t => ProgressBarRun(2, 0));
                ResetDataDefaultLabel(LUrl);
                ResetDataDefaultLabel(SUrl);
                ResetDataDefaultLabel(CountFramesLabel);
                ResetDataDefaultTextBox(TBoxName);
                ProgressText(2, "---- ทำงานเสร็จ ----");
            }
            catch {
                ResetDataDefaultLabel(LUrl);
                ResetDataDefaultLabel(SUrl);
                ResetDataDefaultLabel(CountFramesLabel);
                ResetDataDefaultTextBox(TBoxName);
                Task.Delay(800).ContinueWith(t => ProgressBarRun(2, 0));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        internal void ProgressBarRun(int type,int value)
        {
            if (progressBar.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    ProgressBarRun(type, value)
                ));
                return;
            }
            if (type == 1)  // บอกขนาด  ProgressBar
            {
                progressBar.Maximum = value;
            }
            else if (type == 2) // true() = 1 / false(ซ่อน) = 0   โชว์หรือซ่อน ProgressBar
            {
                progressBar.Visible = Convert.ToBoolean(value);
            }
            else if (type == 3) // เพื่ม value ใน ProgressBar ที่ละ 1
            {
                progressBar.Value = value+1;
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        internal void ProgressText(int type, string text) 
        {
            if (richTextBox.InvokeRequired) 
            {
                this.Invoke((Action)(() =>
                   ProgressText(type, text)
               ));
                return;

            }

            if (type == 1) // แจ้งเตือน text สีแดง
            {
                richTextBox.SelectionColor = Color.Red;
            }
            else if (type == 2)  // ทำงานเสร็จสิ้น text สีเขียว
            {
                richTextBox.SelectionColor = Color.Green;
            }
            else if (type == 3) // กำลังทำงาน text สีฟ้า
            {
                richTextBox.SelectionColor = Color.Blue;
            }

            richTextBox.ScrollToCaret();
            richTextBox.AppendText(text + Environment.NewLine);

            //this.Invoke((Action)(() =>
            //        richTextBox.AppendText(text+Environment.NewLine)

            //   ));
            //this.Invoke((Action)(() =>
            //        richTextBox.ScrollToCaret()
            // ));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CountFrames"></param>
        private void TextFrames(int CountFrames) 
        {
            this.Invoke((Action)(() =>
                    CountFramesLabel.Text = CountFrames.ToString()
                 ));
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        private void TackProcessCpuAndMemory() {
            Process p = System.Diagnostics.Process.GetCurrentProcess();
            PerformanceCounter ramCounter = new PerformanceCounter("Process", "Working Set", p.ProcessName);
            PerformanceCounter cpuCounter = new PerformanceCounter("Process", "% Processor Time", p.ProcessName);
            while (true)
            {
                Thread.Sleep(500);
                double ram = ramCounter.NextValue();
                double cpu = (cpuCounter.NextValue() / (float)Environment.ProcessorCount)*100;
                TextProcessCpuAndMemory(ram, cpu);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ram"></param>
        /// <param name="cpu"></param>
        private void TextProcessCpuAndMemory(double ram, double cpu)
        {
            double sram = Math.Round(ram / 1024 / 1024, 2);
            double scpu = Math.Round(cpu, 2);
            this.Invoke((Action)(() =>
                   metroLabel4.Text = "RAM: " + (sram) + " MB; CPU: " + (scpu) + " %"

                 ));
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="label"></param>
        private void ResetDataDefaultLabel(Label label) 
        {
            if (label.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                   ResetDataDefaultLabel(label)
               ));
                return;
            }
            label.Text = String.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="textBox"></param>
        private void ResetDataDefaultTextBox(TextBox textBox)
        {
            if (textBox.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                   ResetDataDefaultTextBox(textBox)
               ));
                return;
            }      
            
            textBox.Text = String.Empty;
            itemname = String.Empty;
            url_save = String.Empty;
            BOpen.Enabled = true;
            BSave.Enabled = true;
            BConverter.Enabled = true;
          
        }



    }
}
