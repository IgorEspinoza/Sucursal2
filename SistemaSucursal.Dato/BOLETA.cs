//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaSucursal.Dato
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOLETA
    {
        public int id_boleta { get; set; }
        public Nullable<int> monto_venta { get; set; }
        public Nullable<System.DateTime> fecha_venta { get; set; }
        public string rut_vendedor { get; set; }
    
        public virtual VENDEDOR VENDEDOR { get; set; }
    }
}