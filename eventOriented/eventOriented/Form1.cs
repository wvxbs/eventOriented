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

        private void TarefaLonga(int p)
        {
            for (int i = 0; i <= 10; i++)
            {
                // faz a thread dormir por "p" milissegundos a cada passagem do loop
                //Thread.Sleep(p);
                lblProgresso.Text = "Tarefa: " + i.ToString() + " comcluída";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)//representa uma tarefa com 100 processos.
            {
                //Executa o método longo 100 vezes.
                TarefaLonga(20);
                //incrementa o progresso do backgroundWorker 
                //a cada passagem do loop.
                this.backgroundWorker1.ReportProgress(i);

                //Verifica se houve uma requisição para cancelar a operação.
                if (backgroundWorker1.CancellationPending)
                {
                    //se sim, define a propriedade Cancel para true
                    //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                    e.Cancel = true;

                    //zera o percentual de progresso do backgroundWorker1.
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
            //Finalmente, caso tudo esteja ok, finaliza
            //o progresso em 100%.
            backgroundWorker1.ReportProgress(100);
        }

        /// <summary>
        /// Aqui implementamos o que desejamos fazer enquanto o progresso
        /// da tarefa é modificado,[incrementado].
        /// </summary>
        private void backgroundWorker1_ProgressChanged(object sender,
        ProgressChangedEventArgs e)
        {
            //Incrementa o valor da progressbar com o valor
            //atual do progresso da tarefa.
            pgProgresso.Value = e.ProgressPercentage;

            //informa o percentual na forma de texto.
            label1.Text = e.ProgressPercentage.ToString() + "%";
        }

        /// <summary>
        /// Após a tarefa ser concluida, esse metodo e chamado para
        /// implementar o que deve ser feito imediatamente após a conclusão da tarefa.
        /// </summary>
        private void backgroundWorker1_RunWorkerCompleted(object sender,
        RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //caso a operação seja cancelada, informa ao usuario.
                label2.Text = "Operação Cancelada pelo Usuário!";

                //habilita o Botao cancelar
                btnCancelar.Enabled = true;
                //limpa a label
                label1.Text = string.Empty;
            }
            else if (e.Error != null)
            {
                //informa ao usuario do acontecimento de algum erro.
                label2.Text = "Aconteceu um erro durante a execução do processo!";
            }
            else
            {
                //informa que a tarefa foi concluida com sucesso.
                label2.Text = "Tarefa Concluida com sucesso!";
            }
            //habilita os botões.
            //btnTarefaDeterminada.Enabled = true;
            //btnTarefaIndeterminada.Enabled = true;
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

        //ex3

        private void InvokeTextFIle(object sender, EventArgs e)
        {
            using (OpenFileDialog f = new OpenFileDialog() { Filter= "Text File | *.txt", Multiselect=false })
            {
                if(f.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader st = new StreamReader(f.FileName))
                    {

                    }
                }
            }
        }

        private void label5_Click_3(object sender, EventArgs e)
        {

        }

        //
    }
}
