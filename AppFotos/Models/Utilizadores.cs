namespace AppFotos.Models
{

    /// <summary>
    /// utilizadores da aplicacao
    /// </summary>
    public class Utilizadores
    {


        /// <summary>
        /// Identificacao 
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Nome do Utilizador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Morada do Utilizador
        /// </summary>
        public string Morada { get; set; }


        /// <summary>
        /// Codigo Postal do utilizador
        /// </summary>
        public string CodPostal { get; set;}


        /// <summary>
        /// País do utilizador
        /// </summary>
        public string Pais { get; set; }


        /// <summary>
        /// Numero de Identificao fiscal do utilizador 
        /// </summary>
        public string NIF { get; set;}


        /// <summary>
        /// Número de Telemovel do Utilizador
        /// </summary>
        public string Telemovel { get; set; }

        /// <summary>
        /// Lista das fotos que sao propriedade do utilizador
        /// </summary>
        public ICollection<Fotografias> ListaFotos { get; set; }

        /// <summary>
        /// Lista dos gostos de fotografias do utilizador
        /// </summary>
        public ICollection<Gostos> ListaGostos { get; set; }

        /// <summary>
        /// Lista de compras de fotografias do utilizador
        /// </summary>
        public ICollection<Compras> ListaCompras { get; set; }

    }

}
