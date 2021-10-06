using System.ComponentModel.DataAnnotations;

namespace TicoGrafica.Model.Modelos.Orcamentos
{
    public enum TipoFormaDePagamento
    {
        [Display(Name = "Dinheiro")]
        DINHEIRO,
        [Display(Name = "PIX")]
        PIX,
        [Display(Name = "Crédito")]
        CARTAO_CREDITO,
        [Display(Name = "Débito")]
        CARTAO_DEBITO,
        [Display(Name = "Transferência")]
        TRANSFERENCIA,
        [Display(Name = "PIC PAY")]
        PIC_PAY
    }
}
