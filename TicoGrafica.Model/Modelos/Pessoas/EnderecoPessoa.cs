namespace TicoGrafica.Model.Modelos.Pessoas
{
    public class EnderecoPessoa
    {
        public int IdPessoa { get; private set; }
        public string Endereco { get; private set; }
        public string Bairro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Municipio { get; private set; }
        public string Cep { get; private set; }
        public virtual Pessoa Pessoa { get; set; }

        public EnderecoPessoa()
        {

        }

        public EnderecoPessoa(int idPessoa, string endereco, string bairro, string numero, string complemento, string municipio, string cep)
        {
            IdPessoa = idPessoa;
            Endereco = endereco;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;
            Municipio = municipio;
            Cep = cep;
        }
    }
}
