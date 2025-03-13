namespace motasAlcoa.Models
{
    /// <summary>
    /// Regista os pedidos de compra de peças
    /// </summary>
    public class PedidoPecas
    {
        /// <summary>
        /// Identificador do pedido da peça
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da peça que foi pedida
        /// </summary>
        public string Nome { get; set; }
        
        /// <summary>
        /// Número de unidades da peça solicitada no pedido
        /// </summary>
        public int Quantidade{ get; set; }

        /// <summary>
        /// O estado em que se encontra o pedido
        /// </summary>
        public Estados Estado { get; set; }


        /// <summary>
        /// Estado do pedido. Representa um conjunto de valores pre-determinados
        /// que representam a evolução do 'pedido'
        /// </summary>
        public enum Estados
        {
            Pendente,
            Entregue

        }

        /// <summary>
        /// Identificador do serviço ao qual está associado o pedido
        /// </summary>
        public int ServicoID { get; set; }

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
