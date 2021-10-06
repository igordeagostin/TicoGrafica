using System;
using TicoGrafica.Model.Modelos.ContasAReceber;

namespace TicoGrafica.Forms.DTOs
{
    public class ContasReceberDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataDeEntrega { get; set; }
        public DateTime DataDeVencimento { get; set; }
        public int IdPessoa { get; set; }
        public TipoSituacao Situacao { get; set; }
        public string NomePessoa { get; set; }
    }
}
