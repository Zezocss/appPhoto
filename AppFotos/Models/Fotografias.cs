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




    }
}
