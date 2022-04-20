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

        public string idCateogoria { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaCompra { get; set; }

        public int Stock { get; set; }

        public int PeriodoMantencion { get; set; }

        public bool SoftDelete { get; set; }

        public string idUsuarioCreador { get; set; }

    }
}
