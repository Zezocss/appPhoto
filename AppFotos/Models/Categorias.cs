﻿namespace AppFotos.Models
{ 
    
    /// <summary>
  /// categorias a que as fotografias correspondem
  /// </summary>
    public class Categorias
    {

        /// <summary>
        /// Identificacao da categoria
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da Categoria que sera associada as fotos
        /// </summary>
        public string Categoria { get; set;}

    }
}
