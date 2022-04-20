namespace SGC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("InventarioCaracteristicas")]
    public class InventarioCaracteristicas
    {
        [Key]
        public int idInventarioCaracteristicas { get; set; }

        public int idCategoria { get; set; }

        public string Detalle{ get; set; }

        public bool SoftDelete { get; set; }

        public string Codigo { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Procesador { get; set; }

        public string Ram { get; set; }

        public string Almacenamiento1 { get; set; }

        public string Almacenamiento2 { get; set; }

        public virtual Categoria categoria { get; set; }

    }
}
