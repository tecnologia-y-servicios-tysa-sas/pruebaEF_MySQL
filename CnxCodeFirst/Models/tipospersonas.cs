using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CnxCodeFirst.Models
{
    public class tipospersonas
    {
        [Key, ForeignKey("personas")]
        public long TipoPersona_Id { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Naturaleza_Id { get; set; }
        public string Cargo { get; set; }

        public virtual personas personas { get; set; }
        public virtual tiponaturalezas tiponaturalezas { get; set; }
    }
}