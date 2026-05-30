using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace system_bdt.Models.Entities
{
	[Table("users")]
	public class User
	{
        [Key]
        [Column("usr_id")]
        public int Id { get; set; }

        [Column("usr_name")]
        public string Name { get; set; }

        [Column("acc_id")]
        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
    }
}