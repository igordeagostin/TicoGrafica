using System.ComponentModel.DataAnnotations;

namespace TicoGrafica.Model.Modelos.Produtos
{
    public enum TipoUnidadeDeMedida
    {
        [Display(Name = "UN")]
        UNIDADE,
        [Display(Name = "M²")]
        METRO_QUADRADO,
        [Display(Name = "HORA")]
        HORA
    }
}
