namespace motasAlcoa.Models
{
    /// <summary>
    /// Tem como função registar os serviços que são prestados
    /// </summary>
    public class Servicos
    {
        /// <summary>
        /// Identificador do servico
        /// </summary>
        public int Id { get; set; } 

        /// <summary>
        /// Nome dado ao serviço
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Descrição do que é necessário ser feito no serviço
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Valor que será pago pelo serviço
        /// </summary>
        public decimal Preco { get; set; }

        /// <summary>
        /// Data em que o serviço é criado
        /// </summary>
        public DateTime DataServico { get; set; }

        /// <summary>
        /// Data em que é previsto o serviço estar finalizado
        /// </summary>
        public DateTime DataPrevistaFinalizacao { get; set; }


        public Prioridades Prioridade { get; set; }

        /// <summary>
        /// Nivel de prioridade correspondente ao serviço 
        /// ("Baixa, média e alta")
        /// </summary>
        public enum Prioridades
        {
            Baixa,
            Media,
            Alta

        }

        public Estados Estado { get; set; }

        /// <summary>
        /// Estado em que se encontra o serviço. Representa um conjunto de valores pre-determinados
        /// que representam a evolução do 'serviço'
        /// </summary>
        public enum Estados
        {
            Pendente,
            Preparacao,
            Finalizado

        }

        /// <summary>
        /// Identificador do motociclo ao qual vai ser feito o serviço
        /// </summary>
        public int MotocicloID { get; set; }

        /// <summary>
        /// Identificador do cliente ao qual vai ser prestado o serviço
        /// </summary>
        public int ClienteID { get; set; }

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
