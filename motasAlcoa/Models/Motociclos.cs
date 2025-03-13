using System.ComponentModel.DataAnnotations;

namespace motasAlcoa.Models
{
    /// <summary>
    /// Regista os motociclos que dão entrada na oficina
    /// </summary>
    public class Motociclos
    {

        /// <summary>
        /// Identificador do motociclo
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// A marca do motociclo
        /// </summary>
        public string Marca { get; set; }

        /// <summary>
        /// Modelo do motociclo
        /// </summary>
        public string Modelo { get; set; }  

        /// <summary>
        /// Ano de fabricação do motociclo
        /// </summary>
        public string Ano {  get; set; }

        /// <summary>
        /// Placa de identificação do motociclo
        /// </summary>
        public string Matricula { get; set; }

        /// <summary>
        /// Data em que foi criado o perfil do motociclo
        /// </summary>
        public DateTime DataCriacao { get; set; }

        /// <summary>
        /// Data da última atualização do perfil do motociclo
        /// </summary>
        public DateTime DataAtualizacao { get; }

        /// <summary>
        /// Identificador do cliente ao qual o motociclo está associado
        /// </summary>
        public int ClienteID { get; set; }
    }
}
