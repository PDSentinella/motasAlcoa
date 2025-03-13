namespace motasAlcoa.Models
{
    /// <summary>
    /// Regista as peças que são adicionadas ao inventário
    /// </summary>
    public class Pecas
    {
        /// <summary>
        /// Identificador da peça
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da peça
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Preço ao qual foi comprada a peça
        /// </summary>
        public Decimal PrecoCompra {  get; set; }

        /// <summary>
        /// Preço ao qual foi vendida a peça
        /// </summary>
        public Decimal PrecoVenda { get; set; }

        /// <summary>
        /// Quantidade da peça disponível em armazém 
        /// </summary>
        public int QuantidadeStock { get; set; }    

        /// <summary>
        /// Data em que foi criado o perfil do cliente
        /// </summary>
        public DateTime DataCriacao { get; set; }

        /// <summary>
        /// Data da última atualização do perfil do cliente
        /// </summary>
        public DateTime DataAtualizacao { get; }
    }
}
