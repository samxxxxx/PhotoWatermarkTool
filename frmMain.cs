using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoWatermarkTool.UserControls;
using static System.Net.WebRequestMethods;

namespace PhotoWatermarkTool
{
    public partial class frmMain : Form
    {
        private ServiceController _controller;
        public frmMain()
        {
            InitializeComponent();
        }

        public void StopService(string serviceName)
        {
            this._controller = new ServiceController(serviceName);
            if (this._controller.Status != ServiceControllerStatus.Stopped)
            {
                this._controller.Stop();
                this._controller.WaitForStatus(ServiceControllerStatus.Stopped);
                this._controller.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ffmpeg.exe -i Chrysanthemum.jpg -vf drawtext="fontcolor=white:fontsize=50:fontfile=FreeSerif.ttf:text='2022-12-09 17\:26\:12':x=w-tw-50:y=h-100" test.jpg -y
            var config = new DrawConfig()
            {
                Color = txtColor.Text,
                DrawText = txtDrawText.Text,
                FontFile = txtFontFile.Text,
                FontSize = Convert.ToInt32(txtFontSize.Text),
                X = Convert.ToInt32(txtX.Text),
                Y = Convert.ToInt32(txtY.Text)
            };

            var savePath = txtSaveDir.Text ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tmp");
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }

            foreach (ListViewItem item in listView1.Items)
            {
                var sourceFile = item.Text;
                var fileName = Path.GetFileName(sourceFile);
                var saveFile = Path.Combine(savePath, fileName);

                var fontFile = config.FontFile;
                var param = $" -i \"{sourceFile}\" -vf \"drawtext=fontfile='{fontFile}':fontcolor={config.Color}:fontsize={config.FontSize}:text='{config.DrawText}':x={config.X}:y=H-th-100:shadowy=3\" -q:v 1 -movflags use_metadata_tags \"{saveFile}\" -y";

                ProcessUtil.ExecuteFFmpeg(param);
            }

            MessageBox.Show("已经完成啦", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string SearchFontFile(string searchFile)
        {
            var files = Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory, searchFile, SearchOption.AllDirectories);
            return files.FirstOrDefault();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link; //重要代码：表明是链接类型的数据，比如文件路径
            else e.Effect = DragDropEffects.None;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            textBox1.Text = path;

            listView1.Items.Clear();

            var files = ShowFile(path);

            foreach (var file in files)
            {
                listView1.Items.Add(file);
            }
            staFileCount.Text = $"文件数:{listView1.Items.Count}";
        }

        private void GetExif(string filePath)
        {
            var infos = FileExifUtil.GetExifByMe(filePath);

        }

        private IEnumerable<string> ShowFile(string path)
        {
            if (!Directory.Exists(path))
                return null;
            try
            {
                var exts = txtExt.Text.Split('|');

                var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories).Where(x =>
                {
                    var fileName = Path.GetFileName(x);
                    if (exts.Any(s => fileName.Contains(s) || s == "*"))
                    {
                        return true;
                    }

                    return false;
                });

                return files;
            }
            catch
            {
            }
            return null;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link; //重要代码：表明是链接类型的数据，比如文件路径
            else e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected && !string.IsNullOrEmpty(e.Item.Text))
            {
                var dicExif = FileExifUtil.GetExifByMe(e.Item.Text);
                flowLayoutPanel1.Controls.Clear();

                foreach (var exif in dicExif)
                {
                    var exifCtl = new ucExif(exif.Key, exif.Value, e.Item.Text);
                    flowLayoutPanel1.Controls.Add(exifCtl);
                }

                pictureBox1.Load(e.Item.Text);
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link; //重要代码：表明是链接类型的数据，比如文件路径
            else e.Effect = DragDropEffects.None;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            textBox1.Text = path;

            listView1.Items.Clear();

            var files = ShowFile(path);
            if (System.IO.File.Exists(path))
            {
                listView1.Items.Add(path);
            }
            if (files != null)
            {
                foreach (var file in files)
                {
                    listView1.Items.Add(file);
                }
            }
            staFileCount.Text = $"文件数:{listView1.Items.Count}";
        }

        private void tbFontSize_ValueChanged(object sender, EventArgs e)
        {
            txtFontSize.Text = tbFontSize.Value.ToString();
        }

        private void tbX_Scroll(object sender, EventArgs e)
        {

        }

        private void tbX_ValueChanged(object sender, EventArgs e)
        {
            txtX.Text = tbX.Value.ToString();
        }

        private void tbY_ValueChanged(object sender, EventArgs e)
        {
            txtY.Text = tbY.Value.ToString();
        }

        private void btnShowPath_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSaveDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
