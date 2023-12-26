using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ScreenReaderAPIWrapper;
using System.Media;

namespace AccessibleConsole
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Process myProcess = new Process();
		ScreenReader ScreenReader = new ScreenReader();
		SoundPlayer error= new SoundPlayer("error.wav");
		SoundPlayer outPut = new SoundPlayer("feedback.wav");

		private void Form1_Load(object sender, EventArgs e){
			myProcess.StartInfo.FileName = "python";
			myProcess.StartInfo.Arguments = "-i";
			myProcess.StartInfo.UseShellExecute=false;
			myProcess.StartInfo.CreateNoWindow = true;
			myProcess.StartInfo.RedirectStandardInput=true;
			myProcess.StartInfo.RedirectStandardOutput = true;
			myProcess.StartInfo.RedirectStandardError = true;
			myProcess.OutputDataReceived += handleOutput;
			myProcess.ErrorDataReceived += handleErrors;
			myProcess.Start();
			myProcess.BeginOutputReadLine();
			myProcess.BeginErrorReadLine();
		}

		void handleOutput(object sender, DataReceivedEventArgs e){
            Invoke((MethodInvoker)(() => {
                outputBox.Text += e.Data + Environment.NewLine;
                ScreenReader.SayString(e.Data,false);
				outPut.Play();            }));        }

		void handleErrors(object sender, DataReceivedEventArgs e) {
			Invoke((MethodInvoker)(() => {
				outputBox.Text += e.Data + Environment.NewLine;
				ScreenReader.SayString(e.Data);
			error.Play();	}));		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) { 
			myProcess.Dispose();		}

		private void inputBox_KeyPress(object sender, KeyPressEventArgs e)		{
			if (e.KeyChar == (Char)Keys.Enter) {
				int index = inputBox.GetLineFromCharIndex(inputBox.GetFirstCharIndexOfCurrentLine());
				string[] lines = inputBox.Lines;
				string input= lines[index];
					myProcess.StandardInput.WriteLine(input);
					ScreenReader.SayString(input);
                    if (index != lines.Length - 1)
					e.Handled = true;
                if (input != "")
                    outputBox.Text += input + Environment.NewLine;
            }
		}

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)			{
				string path= saveFileDialog.FileName;
				System.IO.File.WriteAllText(path, outputBox.Text);
			}
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
