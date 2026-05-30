using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace system_bdt.Models.Entities
{
    [Table("account")]
    public class Account
    {
        [Key]
        [Column("acc_id")]
        public int Id { get; set; }

        [Column("acc_email")]
        public string Email { get; set; }

        [Column("acc_pssword")]
        public string Password { get; set; }

        [Column("acc_role")]
        public string Role { get; set; }

        [Column("acc_verified")]
        public string Verified { get; set; }

        [Column("acc_status")]
        public bool Status { get; set; }

        [Column("acc_token")]
        public string Token { get; set; }

        [Column("acc_datecreated")]
        public DateTime DateCreated { get; set; }
    }
}