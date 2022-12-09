using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoWatermarkTool
{
    internal class ProcessUtil
    {
        /// <summary>
        /// 执行FFmpeg命令
        /// </summary>
        /// <param name="Arguments"></param>
        /// <returns></returns>
        public static bool ExecuteFFmpeg(string Arguments)
        {
            try
            {
                var workingDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res", "ffmpeg");
                Process process = new Process();
                process.StartInfo.FileName = Path.Combine(workingDirectory, "ffmpeg.exe");                                                                                      //绝对路径 如 E:\Projects\AiShangVideo\wwwroot\files\ffmpeg.exe
                process.StartInfo.Arguments = Arguments;
                process.StartInfo.WorkingDirectory = workingDirectory;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();
                process.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
