using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace CronTask
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Tarefa tarefaAtual;
        private List<Tarefa> tarefas = new List<Tarefa>();
        private FileStream fileStream;

        //public string filePath = @"c:\temp\tarefas.csv";

        public Form1()
        {
            InitializeComponent();
            timer = new Timer { Interval = 1000 };
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (tarefaAtual != null)
            {
                AtualizarLabelTempo();
            }
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {

            tarefaAtual = tarefas.FirstOrDefault(t => t.NomeDaTarefa == tbTarefa.Text);

            if (tarefaAtual == null)
            {
                tarefaAtual = new Tarefa
                {
                    NomeDaTarefa = tbTarefa.Text,
                    HorarioInicioTarefa = DateTime.Now
                };
                tarefas.Add(tarefaAtual);
            }
            else
            {
                tarefaAtual.HorarioInicioTarefa = DateTime.Now;
                tarefaAtual.HorarioFimTarefa = DateTime.MinValue;
            }

            timer.Start();
            btnIniciar.Enabled = false;
            btnParar.Enabled = true;
            AtualizarGrid();
        }

        private void btnParar_Click_1(object sender, EventArgs e)
        {
            if (tarefaAtual != null)
            {
                tarefaAtual.HorarioFimTarefa = DateTime.Now;
                timer.Stop();

                lblTime.Text = tarefaAtual.TempoGastoTarefa.ToString(@"hh\:mm\:ss");
                btnIniciar.Enabled = true;
                btnParar.Enabled = false;

                AtualizarGrid();
            }
        }

        private void btnAdicionarTarefa_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTarefa.Text))
            {
                if (!tarefas.Any(t => t.NomeDaTarefa == tbTarefa.Text))
                {
                    Tarefa novaTarefa = new Tarefa(tbTarefa.Text);
                    tarefas.Add(novaTarefa);
                }

                AtualizarGrid();
                MessageBox.Show("Nome da tarefa salvo com sucesso!");
                btnIniciar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Digite um nome para a tarefa.");
            }
        }

        private void AtualizarLabelTempo()
        {
            if (tarefaAtual != null)
                lblTime.Text = tarefaAtual.TempoGastoTarefa.ToString(@"hh\:mm\:ss");
        }

        private void AtualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tarefas.Select(t => new
            {
                t.NomeDaTarefa,
                HorarioInicio = t.HorarioInicioTarefa != DateTime.MinValue ? t.HorarioInicioTarefa.ToString("HH:mm:ss") : "",
                HorarioFim = t.HorarioFimTarefa != DateTime.MinValue ? t.HorarioFimTarefa.ToString("HH:mm:ss") : "",
                TempoGasto = t.HorarioFimTarefa != DateTime.MinValue ? t.TempoGastoTarefa.ToString(@"hh\:mm\:ss") : ""
            }).ToList();
        }

        private void btnSalvarCSV_Click(object sender, EventArgs e)
        {
            if (tarefaAtual != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivo CSV (*.csv)|*.csv";
                saveFileDialog.Title = "Selecione o caminho para salvar o arquivo CSV";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
                        {
                            writer.WriteLine("NomeDaTarefa,HorarioInicio,HorarioFim,TempoGasto");

                            foreach (var tarefa in tarefas)
                            {
                                string linha = $"{tarefa.NomeDaTarefa}," +
                                       $"{(tarefa.HorarioInicioTarefa != DateTime.MinValue ? tarefa.HorarioInicioTarefa.ToString("yyyy-MM-dd HH:mm:ss") : "")}," +
                                       $"{(tarefa.HorarioFimTarefa != DateTime.MinValue ? tarefa.HorarioFimTarefa.ToString("yyyy-MM-dd HH:mm:ss") : "")}," +
                                       $"{(tarefa.HorarioFimTarefa != DateTime.MinValue ? tarefa.TempoGastoTarefa.ToString(@"hh\:mm\:ss") : "")}";
                                writer.WriteLine(linha);
                            }
                        }
                        MessageBox.Show("Arquivo CSV salvo com sucesso!\n" + filePath, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar arquivo CSV: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Não há tarefas para salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
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

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFecharCSV_Click(object sender, EventArgs e)
        {
            if (fileStream != null)
            {
                try
                {
                    fileStream.Close();
                    fileStream = null;
                    dataGridView1.DataSource = null;
                    tarefas.Clear();
                    MessageBox.Show("Arquivo fechado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao fechar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Nenhum arquivo está aberto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
