using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFile
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btn_Opt1_Click(object sender, EventArgs e)
        {
            string path = txt_Origin.Text;

            FolderBrowserDialog dialog1 = new FolderBrowserDialog()
            {
                DirectoryPath = path !="" && Directory.Exists(path) ? path: "c:\\"
            };
            if (dialog1.ShowDialog(this) == DialogResult.OK)
            {
                txt_Origin.Text = dialog1.DirectoryPath;
            }
        }

        private void btn_Opt2_Click(object sender, EventArgs e)
        {
            string path = txt_Purpose.Text;

            FolderBrowserDialog dialog1 = new FolderBrowserDialog()
            {
                DirectoryPath = path != "" && Directory.Exists(path) ? path : "c:\\"
            };
            if (dialog1.ShowDialog(this) == DialogResult.OK)
            {
                txt_Purpose.Text = dialog1.DirectoryPath;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AllCopy_Click(object sender, EventArgs e)
        {
            DirectoryFileCopy(txt_Origin.Text,txt_Purpose.Text ,true);
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            DirectoryFileCopy(txt_Origin.Text, txt_Purpose.Text, false);
        }

        //-------------------------------------------//
        public void DirectoryFileCopy(string removeDir, string desDir, bool copySubDirs)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            DirectoryCopy(removeDir, desDir, copySubDirs);
            timer.ElapsedMilliseconds.ToString();
            timer.Stop();
        }

        /// <summary>
        ///  複製檔案
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>
        /// <param name="copySubDirs">是否複製子目錄</param>
        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, bool AllDelete = true)
        {
            Stopwatch timer = new Stopwatch();
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo dirDest = new DirectoryInfo(destDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "此目錄不存在或找不到: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            if (AllDelete)
            {
                //如果有存在的檔案，就會把他先刪除
                if (Directory.Exists(destDirName))
                {
                    Directory.Delete(destDirName, true);
                }

                Directory.CreateDirectory(destDirName);
                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string tempPath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(tempPath, false);
                }

                //如果複製子目錄，請將它們及其內容複製到新位置
                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string tempPath = Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, tempPath, copySubDirs, AllDelete);
                    }
                }
            }//if (!AllDelete)
            else
            {
                FileInfo[] files = dir.GetFiles();
                FileInfo[] filesDest = dirDest.GetFiles();
                foreach (FileInfo file in files)
                {
                    if(filesDest.Where(x=>x.Name == file.Name && x.LastWriteTime == file.LastWriteTime).Any()) break;
                    string tempPath = Path.Combine(destDirName, file.Name);
                    if (File.Exists(tempPath)) { File.Delete(tempPath); }
                    file.CopyTo(tempPath, false);
                }

                //如果複製子目錄，請將它們及其內容複製到新位置
                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string tempPath = Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, tempPath, copySubDirs, AllDelete);
                    }
                }
            }
        }//DirectoryCopy()

        private void Chk_ConfigIsNull()
        {
            string savePath = System.Windows.Forms.Application.StartupPath + "\\Setting.config";
            if (!File.Exists(savePath)) {
                File.WriteAllText(savePath,txt_Origin.Text+'\n' + txt_Purpose.Text);
            };
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Chk_ConfigIsNull();
            Set_PathStr();
        }
        private void Set_PathStr()
        {
            string line; int counter = 0;
            string setPath = System.Windows.Forms.Application.StartupPath + "\\Setting.config";
            StreamReader stream = new StreamReader(setPath);
            while ((line = stream.ReadLine()) != null)
            {
                switch (counter)
                {
                    case 0: txt_Origin.Text = line; break;
                    case 1: txt_Purpose.Text = line; break;
                }
                counter++;
            }
            stream.Close();
        }
        private void txt_Origin_TextChanged(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                //延遲2秒執行
                Thread.Sleep(1000);
                BeginInvoke(new Action(() =>
                {
                    string setPath = System.Windows.Forms.Application.StartupPath + "\\Setting.config";
                    string setText = "";
                    setText += txt_Origin.Text + '\n';
                    setText += txt_Purpose.Text + '\n';
                    if (File.Exists(setPath) && setText != "") File.WriteAllText(setPath, setText);
                }));
            });
        }

        private void txt_Purpose_TextChanged(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                //延遲2秒執行
                Thread.Sleep(1000);
                BeginInvoke(new Action(() =>
                {
                    string setPath = System.Windows.Forms.Application.StartupPath + "\\Setting.config";
                    string setText = "";
                    setText += txt_Origin.Text + '\n';
                    setText += txt_Purpose.Text + '\n';
                    if (File.Exists(setPath) && setText != "") File.WriteAllText(setPath, setText);
                }));
            });
        }
    }
}
