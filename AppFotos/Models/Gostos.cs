using System.ComponentModel.DataAnnotations.Schema;

namespace AppFotos.Models
{

    /// <summary>
    /// regista os gostos que um utilizador da app tem
    /// pelas fotografias existentes
    /// </summary>
    public class Gostos
    {


        /// <summary>
        /// Data em que o utilizador deu gosto numa fotografia 
        /// </summary>
        public DateTime Data { get; set; }





        /// <summary>
        /// fOREIGN KEY para referenciar o utilizador que gosta da foto
        /// </summary>
        [ForeignKey(nameof(Utilizador))]
        public int UtilizadorFK { get; set; }
        /// <summary>
        /// Foreign Key para referenciar o Utilizador que gosta da fotografia
        /// </summary>
        public Utilizadores Utilizador { get; set; }




        /// <summary>
        /// fOREIGN KEY para referenciar a fotografia que o  utilizador gostou
        /// </summary>
        [ForeignKey(nameof(Fotografia))]
        public int FotografiasFK { get; set; }
        /// <summary>
        /// Foreign Key para referenciar a fotografia que o utilizador gostou
        /// </summary>
       public Fotografias Fotografia { get; set; }

    }
}
