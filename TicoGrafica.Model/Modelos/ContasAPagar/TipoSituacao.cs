using System.ComponentModel.DataAnnotations;

namespace TicoGrafica.Model.Modelos.ContasAPagar
{
    public enum TipoSituacao
    {
        [Display(Name = "Pendente")]
        PENDENTE,
        [Display(Name = "Quitado")]
        QUITADO
    }
}
