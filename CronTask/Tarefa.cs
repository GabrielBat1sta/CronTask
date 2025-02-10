using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronTask
{
    internal class Tarefa
    {
        //public string Nome { get; set; }
        //public TimeSpan Tempo { get; set; }

        public string NomeDaTarefa { get;  set; }

        public DateTime HorarioInicioTarefa { get; set; } = DateTime.MinValue;
        public DateTime HorarioFimTarefa { get; set; } = DateTime.MinValue;

        public TimeSpan TempoGastoTarefa => HorarioFimTarefa - HorarioInicioTarefa;

        public Tarefa()
        {

        }

        public Tarefa(string nomeDaTarefa, DateTime horarioInicioTarefa, DateTime horarioFimTarefa, TimeSpan TempoGastoTarefa)
        {
            NomeDaTarefa = nomeDaTarefa;
            HorarioInicioTarefa = horarioInicioTarefa;
            HorarioFimTarefa = horarioFimTarefa;
            
        }

        public Tarefa(string nomeDaTarefa)
        {
            NomeDaTarefa = nomeDaTarefa;
        }
    }
}
