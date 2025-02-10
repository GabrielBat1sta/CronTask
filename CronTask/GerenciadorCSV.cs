using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronTask
{
    internal class GerenciadorCSV
    {
        public static string NomeDaTarefa { get; set; }

        public static DateTime HorarioInicioTarefa { get;  set; }

        public static DateTime HorarioFimTarefa { get;  set; }

        public static TimeSpan TempoGastoTarefa { get; set; }

        public static List<Tarefa> CarregarCSV(string path)
        {
            List<Tarefa> tarefas = new List<Tarefa>();

            if (File.Exists(path))
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    sr.ReadLine();
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var dados = linha.Split(',');
                        tarefas.Add(new Tarefa(NomeDaTarefa = dados[0], HorarioInicioTarefa = DateTime.Parse(dados[1]), HorarioFimTarefa = DateTime.Parse(dados[2]), TempoGastoTarefa = TimeSpan.Parse(dados[3])));
                    }
                }
            }
            return tarefas;
        }
    }
}
