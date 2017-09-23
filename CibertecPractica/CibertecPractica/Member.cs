using System;
using System.ComponentModel.DataAnnotations;

namespace CibertecPractica.Models
{
    public class Member
    {
        [Key]
        public int Member_no { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Middleinitial { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State_prov { get; set; }
        public string Country { get; set; }
        public string Mail_code { get; set; }
        public string Phone_no { get; set; }
        public DateTime Issue_dt { get; set; }
        public DateTime Expr_dt { get; set; }
        public int? Corp_no { get; set; }
        public decimal Prev_balance { get; set; }
        public decimal Curr_balance { get; set; }
        public string Member_code { get; set; }


    }
}
