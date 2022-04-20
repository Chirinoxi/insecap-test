namespace SGC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Inventario")]
    public class Inventario
    {
        [Key]
        public int idInventario { get; set; }

        public string Codigo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaCompra { get; set; }

        public int Stock { get; set; }

        public int PeriodoMantencion { get; set; }

        public bool SoftDelete { get; set; }

        [Display(Name = "idUsuarioCreador")]
        public string Id { get; set; }

        [Display(Name = "idCategoria")]
        public string idCategoria { get; set; }

        // FK's

        public virtual Categoria categoria { get; set; }

        public virtual AspNetUsers usuario { get; set; }

    }
}
