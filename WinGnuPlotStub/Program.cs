using System;
using System.Diagnostics;
using System.IO;

namespace Sharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] arguments)
        {
            String newArguments = "";
            if (arguments.Length > 0)
            {
                newArguments = arguments[0];
                String path = Path.GetDirectoryName(newArguments);

                var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "gnuplot.ini");

                string[] lines = { "set terminal wxt;", "cd '" + path + "';"};
                // WriteAllLines creates a file, writes a collection of strings to the file, 
                // and then closes the file.
                System.IO.File.WriteAllLines(fileName, lines);
            }
            Process stubbedProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "gnuplot-stubbed.exe",
                    Arguments = newArguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };
            stubbedProcess.Start();

            while (!stubbedProcess.StandardOutput.EndOfStream)
            {
                string line = stubbedProcess.StandardOutput.ReadLine();
                Trace.WriteLine(line);
            }

            stubbedProcess.WaitForExit();

            Environment.Exit(stubbedProcess.ExitCode);
        }
    }
}
