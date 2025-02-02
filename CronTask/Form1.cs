using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace CronTask
{
    public partial class Form1 : Form
    {

        private DateTime HorarioInicioTarefa;
        private DateTime HorarioFimTarefa;
        private TimeSpan tempoDecorrido;
        private bool tarefaAtiva;
        private Timer timer;
        private Tarefa tarefaAtual;
        private List<Tarefa> tarefas = new List<Tarefa>();
        private FileStream fileStream;

        public string path = "c:\\temp\\tarefas.csv";
        public TimeSpan TempoGastoTarefa { get; set; }

        public Form1()
        {
            InitializeComponent();
            timer = new Timer { Interval = 1000 };
            timer.Tick += Timer_Tick;
            tempoDecorrido = TimeSpan.Zero;
            tarefaAtiva = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (tarefaAtiva && tarefaAtual != null)
            {
                tarefaAtual.HorarioInicioTarefa = tarefaAtual.HorarioInicioTarefa.Add(TimeSpan.FromSeconds(1));
                AtualizarLabelTempo();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!tarefaAtiva)
            {
                if (string.IsNullOrEmpty(tbTarefa.Text))
                {
                    MessageBox.Show("Digite um nome para a tarefa.");
                    return;
                }
                tarefaAtiva = true;
                HorarioInicioTarefa = DateTime.Now;
                tarefaAtual = new Tarefa();
                timer.Start();
                btnIniciar.Enabled = false;
                btnParar.Enabled = true;
            }

        }

        private void btnParar_Click_1(object sender, EventArgs e)
        {
            if (tarefaAtiva)
            {
                HorarioFimTarefa = DateTime.Now;
                lblTime.Text = $"{(HorarioFimTarefa - HorarioInicioTarefa).ToString(@"hh\:mm\:ss")}";
                timer.Stop();
                btnIniciar.Enabled = true;
                btnParar.Enabled = false;
                tarefaAtiva = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTarefa.Text))
            {
                tarefas.Add(new Tarefa(tbTarefa.Text, HorarioInicioTarefa, HorarioFimTarefa, TempoGastoTarefa));

                GerenciadorCSV.SalvarTarefa(path, tarefas);
                AtualizarGrid();
                MessageBox.Show("Tarefa salva com sucesso!");
            }
            else
            {
                MessageBox.Show("Digite um nome para a tarefa.");
            }
        }

        private void btnCarregar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv";
            openFileDialog.Title = "Selecione um arquivo CSV";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    MessageBox.Show("Arquivo selecionado:" + filePath);
                    tarefas = GerenciadorCSV.CarregarCSV(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao abrir arquivo: " + ex.Message);
                }

            }
            AtualizarGrid();
        }
        private void btnFecharCSV_Click(object sender, EventArgs e)
        {
            if (fileStream != null)
            {
                fileStream.Close();
                MessageBox.Show("Arquivo fecheado com sucesso!");
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Nenhum arquivo está aberto.");
            }
        }
        private void AtualizarLabelTempo()
        {
            lblTime.Text = tarefaAtual.TempoGastoTarefa.ToString(@"hh\:mm\:ss") ?? "00:00:00";
        }
        private void AtualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tarefas.Select(t => new
            {
                t.NomeDaTarefa,
                HorarioInicioTarefa = t.HorarioInicioTarefa.ToString("HH:mm:ss"),
                HorarioFimTarefa = t.HorarioFimTarefa.ToString("HH:mm:ss"),
                TempoGastoTarefa = t.TempoGastoTarefa.ToString(@"hh\:mm\:ss")
            }).ToList();
        }

        private void btnSalvarCSV_Click(object sender, EventArgs e)
        {
            btnSalvarCSV.Enabled = false;

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Arquivo CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Selecione o caminho para salvar o arquivo CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                GerenciadorCSV.SalvarTarefa(filePath, tarefas);
                try
                {
                    fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                    MessageBox.Show("Arquivo salvo: " + filePath);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
