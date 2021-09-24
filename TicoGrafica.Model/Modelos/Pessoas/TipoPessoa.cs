using System.ComponentModel.DataAnnotations;

namespace TicoGrafica.Model.Modelos.Pessoas
{
    public enum TipoPessoa
    {
        [Display(Name = "Física")]
        FISICA,
        [Display(Name = "Jurídica")]
        JURIDICA
    }
}
