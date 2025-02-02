using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronTask
{
    internal class Tarefa
    {
        public string Nome { get; set; }
        public TimeSpan Tempo { get; set; }
        public DateTime DataInicio { get; set; }


        public Tarefa(string nome)
        {
            Nome = nome;
            Tempo = TimeSpan.Zero;
            DataInicio = DateTime.Now;
        }
    }
}
