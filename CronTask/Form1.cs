using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace CronTask
{
    public partial class Form1 : Form
    {
        private TimeSpan tempoDecorrido;
        private bool tarefaAtiva;
        private List<Tarefa> listaTarefas;
        private Tarefa tarefaAtual;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            listaTarefas = new List<Tarefa>();
            tarefaAtiva = false;
            tempoDecorrido = TimeSpan.Zero;
            timer = new Timer { Interval = 1000 };
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (tarefaAtiva && tarefaAtual != null)
            {
                tarefaAtual.Tempo = tarefaAtual.Tempo.Add(TimeSpan.FromSeconds(1));
                AtualizarlabelTempo();
            }
        }

        private void AtualizarlabelTempo()
        {
            lblTime.Text = tarefaAtual?.Tempo.ToString(@"hh\:mm\:ss") ?? "00:00:00";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!tarefaAtiva)
            {
                if (string.IsNullOrWhiteSpace(tbTarefa.Text))
                {
                    MessageBox.Show("Digite um nome para a tarefa.");
                    return;
                }
                tarefaAtual = new Tarefa(tbTarefa.Text);
                listaTarefas.Add(tarefaAtual);
                tarefaAtiva = true;
                timer.Start();
                btnIniciar.Text = "Parar";
            }
            else
            {
                tarefaAtiva = false;
                timer.Stop();
                btnIniciar.Text = "Iniciar";
            }
        }

        private void btnZerar_Click_1(object sender, EventArgs e)
        {
            if (tarefaAtual != null)
            {
                tarefaAtual.Tempo = TimeSpan.Zero;
                AtualizarlabelTempo();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(listaTarefas);
            File.WriteAllText("tarefas.json", json);
            MessageBox.Show("Tarefas salvas com sucesso.");
        }

        private void btnCarregar_Click_1(object sender, EventArgs e)
        {
            if (File.Exists("tarefas.json"))
            {
                string json = File.ReadAllText("tarefas.json");
                listaTarefas = JsonSerializer.Deserialize<List<Tarefa>>(json) ?? new List<Tarefa>();
                MessageBox.Show("Tarefas carregadas com sucesso.");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (!tarefaAtiva)
            {
                if(string.IsNullOrWhiteSpace(tbTarefa.Text))
                {
                    MessageBox.Show("Digite um nome para a tarefa.");
                    return;
                }
                else
                {
                    ListTarefas.Items.Add(tbTarefa.Text);
                    tbTarefa.Clear();
                }
            }
        }
    }
}
