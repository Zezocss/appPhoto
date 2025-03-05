using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppFotos.Models
{

    /// <summary>
    /// compras efetuadas pelo utilizador
    /// </summary>
    public class Compras
    {


        /// <summary>
        /// Identificacao da compra 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// data em que a compra foi realizada
        /// </summary>
        public DateTime Data { get; set; }


        /// <summary>
        /// fase do processo da compra
        /// variavel "Estado" é do tipo "Estados
        /// </summary>
        public Estados Estado { get; set; }


        /// <summary>
        /// estados associados a uma compra
        /// </summary>
        public enum Estados
        {
            Pendente,
            Pago,
            Enviada,
            Entregue,
            Concluída
        }


        /// <summary>
        /// fOREIGN KEY para referenciar o comprador da foto
        /// </summary>
        [ForeignKey(nameof(Comprador))]
        public int CompradorFK { get; set; }
        /// <summary>
        /// Foreign Key para referenciar o comprador da fotografia
        /// </summary>
        public Utilizadores Comprador { get; set; }


        /// <summary>
        /// Lista de 'compras' que compraram a fotografia
        /// </summary>
        public ICollection<Fotografias> ListaFotografiasCompradas { get; set; }

    }
}
