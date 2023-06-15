using System.ComponentModel;
using System.Diagnostics;

namespace Konwerter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = Path.Combine(Environment.CurrentDirectory, @"7z\", "7za.exe"); // 7za path
            string args = "a ";
            string outPath = OutputPath.Text;
            string method = "-mx=";
            var checkedButton = CompressionLevelGroupBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            method += CompCheck(checkedButton.Name);
            if(Type7z.Checked)
            {
                args += "-t7z ";
                outPath += ".7z";
                checkedButton = CompMethod7z.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
                method += Type7ZCheck(checkedButton.Name);
            }
            else
            {
                args += "-tzip ";
                outPath += ".zip";
                checkedButton = CompMethodZIP.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
                method += TypeZipCheck(checkedButton.Name);
            }
            args += outPath + " " + InputPath.Text + " " + method;
            p.Arguments = args;

            var process = Process.Start(p);
            process.WaitForExit();
        }

        private static string CompCheck(string buttonName)
        {
            return buttonName switch
            {
                "CompFastest" => "1",
                "CompNormal" => "5",
                _ => "9"
            };
        }

        private static string TypeZipCheck(string buttonName) 
        {
            return buttonName switch
            {
                "CompMethodDeflate64" => " -mm=Deflate64",
                "CompMethodBZip2" => " -mm=BZip2",
                "CompMethodLZMA" => " -mm=LZMA",
                "CompMethodDeflate" => " -mm=Deflate",
                _ => " -mm=PPWMd"
            };
        }

        private static string Type7ZCheck(string buttonName) 
        {
            return buttonName switch
            {
                "CompMethod7zBZip2" => " -m0=BZip2",
                "CompMethod7zLZMA2" => " -m0=LZMA2",
                "CompMethod7zLZMA" => " -m0=LZMA",
                _ => " -m0=PPMd"
            };
        }

    public static float GetFileSize(string file)
        {
            FileInfo info = new FileInfo(file);
            return info.Length;
        }

        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }

        private void Type7z_CheckedChanged(object sender, EventArgs e)
        {
            CompMethod7z.Enabled = true;
            CompMethodZIP.Enabled = false;
        }

        private void TypeZIP_CheckedChanged(object sender, EventArgs e)
        {
            CompMethod7z.Enabled = false;
            CompMethodZIP.Enabled = true;
        }
    }
}