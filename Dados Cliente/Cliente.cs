using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ListagemClientes
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public long Rg { get; set; }
        public string InscricaoEst { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
    }
}
