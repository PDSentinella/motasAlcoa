namespace motasAlcoa.Models
{
    /// <summary>
    /// Regista o preço das peças tanto de compra como de venda
    /// </summary>
    public class PrecoPecas
    {
        /// <summary>
        /// Identificador do preço das peças quando 
        /// foram compradas e vendidas
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador da peça 
        /// </summary>
        public int PecaID { get; set; }

        /// <summary>
        /// Preço ao qual foi comprada a peça
        /// </summary>
        public int PrecoCompra { get; set; }

        /// <summary>
        /// Preço ao qual foi vendida a peça
        /// </summary>
        public int PrecoVenda { get; set; }

        /// <summary>
        /// DEFINIR............................................
        /// </summary>
        public DateTime DataCriacao { get; set; }

        /// <summary>
        /// DEFINIR............................................
        /// </summary>
        public DateTime DataAtualizacao { get; }

    }
}
