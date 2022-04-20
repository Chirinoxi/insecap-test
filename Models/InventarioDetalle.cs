namespace SGC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("InventarioDetalle")]
    public class InventarioDetalle
    {
        [Key]
        public int idInventarioDetalle { get; set; }

        public string Detalle { get; set; }

        public bool SoftDelete { get; set; }

        public int idInventario{ get; set; }

        public int idInventarioCaracteristicas { get; set; }
    }
}
