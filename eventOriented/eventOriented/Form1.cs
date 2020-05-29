using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace eventOriented
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        //ex1

        string text = "";

        private void txtCaixa_TextChanged(object sender, EventArgs e)
        {
            text = txtCaixa.Text;
            lblLabel.Text = text;
        }

        private void clearTextField(object sender, EventArgs e)
        {
            text = "";
            txtCaixa.Text = "";
            lblLabel.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        //

        //ex2

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                for (int i = 0; i <= 100; i++)
                {
                    if (!backgroundWorker1.CancellationPending)
                    {
                        Thread.Sleep(100);
                        backgroundWorker1.ReportProgress(i);
                    }
                    else
                    {
                        backgroundWorker1.ReportProgress(0);
                        break;
                    }
                }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgProgresso.Value = e.ProgressPercentage;
            lblProgresso.Text = $"{e.ProgressPercentage.ToString()}%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }



        private void pgProgresso_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            } else
            {
                MessageBox.Show("Thread ja em execução");
            }
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                MessageBox.Show("ta doido");
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //

        //ex3

        private string FileName = "";
        private List<string> FileContent;

        private void InvokeTextFIle(object sender, EventArgs e)
        {
            using (OpenFileDialog f = new OpenFileDialog() { Filter= "Text File | *.txt", Multiselect=false })
            {
                if(f.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader st = new StreamReader(f.FileName))
                    {
                        List<string> l = new List<string>();
                        string line = "";
                        while((line = st.ReadLine()) != null)
                        {
                            l.Add(line);
                        }

                        FileContent = l;

                        FileName = f.FileName.ToString(); 
                        lbFileName.Text = FileName;

                        btnAnalisar.Enabled = true;

                        //lbFileName.Text = FileText;
                    }
                }
                else
                {
                    FileName = "<Nenhum Arquivo Selecionado>";
                    MessageBox.Show(FileName);
                }
            }
        }

        private void ProcessFileData(object sender, EventArgs e)
        {
            //sampleRichTestBox.Text = FileContent;

            string st = String.Concat(FileContent.ToArray());

            string[] Words = st.Split(' ');


            LetterLabel.Text = letterCount(st);
            NumLabel.Text = numberCount(st);
            SpacesLabel.Text = spaceCount(st);
            LinesLabel.Text = lineCount(FileContent);
            CharLabel.Text = charCount(st);
            WordsLabel.Text = wordCount(Words);
            ThreeLettersWordsLabel.Text = threeLetterWordCount(Words);
            BiggestWordLabel.Text = biggestWord(Words);
        }

        private string letterCount(string st)
        {
            return Regex.Matches(st, @"[A-Za-z]").Count.ToString();
        }

        private string numberCount(string st)
        {
            return Regex.Matches(st, @"[0-9]").Count.ToString();
        }

        private string spaceCount(string st)
        {
            int spcctr = 0;
            string str1;
            for (int i = 0; i < st.Length; i++)
            {
                str1 = st.Substring(i, 1);
                if (str1 == " ")
                    spcctr++;
            }
            return spcctr.ToString();
        }

        private string lineCount(List<string> st)
        {
            return st.Count.ToString();
        }

        private string charCount(string st)
        {
            return Regex.Matches(st, @"[^-]").Count.ToString();
        }

        private string wordCount(string [] st)
        {
            return st.Length.ToString();
        }

        private string threeLetterWordCount(string [] st)
        {
            List<string> results = new List<string>();

            foreach(string i in st)
            {
                if(i.Length == 3)
                {
                    results.Add(i);
                }
            }

            return results.Count.ToString();
        }

        private string biggestWord(string [] st)
        {

            string temp = "";
            foreach(string i in st)
            {
                if (i.Length > temp.Length)
                {
                    if (i.Length== temp.Length)
                    {
                        if(i.CompareTo(temp) == 1)
                        {
                            temp = i;
                        }
                        else
                        if(i.CompareTo(temp) == -1)
                        {
                            temp = temp;
                        }
                        else
                        if(i.CompareTo(temp) == 0)
                        {
                            temp = temp;
                        }
                    }

                    temp = i;
                }
            }

            return temp;
        }

        private void label5_Click_3(object sender, EventArgs e)
        {

        }

        private void lbFileName_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

 

        //
    }
}
