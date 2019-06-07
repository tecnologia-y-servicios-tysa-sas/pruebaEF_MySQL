using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CnxCodeFirst.Models
{
    public class tiponaturalezas
    {
        [Key, ForeignKey("tipospersonas")]
        public long Naturaleza_Id { get; set; }
        public string descripcion { get; set; }

        public virtual tipospersonas tipospersonas { get; set; }
    }
}