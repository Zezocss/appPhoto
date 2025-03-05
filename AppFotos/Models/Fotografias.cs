using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppFotos.Models
{

    /// <summary>
    /// fotografias disponiveis na aplicacao
    /// </summary>
    public class Fotografias
    {
        public int Id { get; set; }

        /// <summary>
        /// titulo da foto
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// descricao da foto
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// nome do ficheiro no disco rigido do server
        /// </summary>
        public string Ficheiro { get; set; }

        /// <summary>
        /// data em que a fotografia foi tirada
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Preço de venda da foto
        /// </summary>
        public decimal Preco { get; set; }

        /* ***********************
         * Definicao dos relacionamentos 
         * *********************** */

        /********* FOREIGN KEYS **********/

        /// <summary>
        /// fOREIGN KEY para a tabela Categoria
        /// </summary>
        [ForeignKey(nameof(Categoria))]
        public  int CategoriaFK { get; set; }
        /// <summary>
        /// Foreign Key para as Categorias
        /// </summary>
        public Categorias Categoria { get; set; }


        /// <summary>
        /// fOREIGN KEY para referenciar o dono da foto
        /// </summary>
        [ForeignKey(nameof(Dono))]
        public int DonoFK { get; set; }
        /// <summary>
        /// Foreign Key para referenciar o dono da fotografia
        /// </summary>
        public Utilizadores Dono { get; set; }

        /// <summary>
        /// Lista dos gostos de uma fotografia
        /// </summary>
        public ICollection<Gostos> ListaGostos { get; set; }


        /// <summary>
        /// Lista de 'compras' que compraram a fotografia
        /// </summary>
        public ICollection<Compras> ListaCompras { get; set; }


    }
}
