using System;
using System.ComponentModel.DataAnnotations;

namespace CibertecPractica.Models
{
    public class Corporation
    {
        [Key]
        public int Corp_no { get; set; }
        public string Corp_name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State_prov { get; set; }
        public string Country { get; set; }
        public string Mail_code { get; set; }
        public string Phone_no { get; set; }
        public DateTime Expr_dt { get; set; }
        public string Corp_code { get; set; }

    }
}
