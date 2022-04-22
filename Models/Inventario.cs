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

        [Display(Name = "Código")]
        public string Codigo { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime? FechaCreacion { get; set; }

        [Display(Name = "Fecha de Compra")]
        public DateTime? FechaCompra { get; set; }

        public int Stock { get; set; }

        [Display(Name = "Periodo de Mantención")]
        public int PeriodoMantencion { get; set; }

        public bool SoftDelete { get; set; }

        [Display(Name = "idUsuarioCreador")]
        public string Id { get; set; }

        [ForeignKey("categoria")]
        [Display(Name = "Categoria")]
        public int idCategoria { get; set; }

        // FK's

        public virtual Categoria categoria { get; set; }

        public virtual AspNetUsers usuario { get; set; }

    }
}
