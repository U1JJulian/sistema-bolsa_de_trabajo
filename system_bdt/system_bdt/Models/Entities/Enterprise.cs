using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace system_bdt.Models.Entities
{
	[Table("enterprise")]
	public class Enterprise
	{
        [Key]
        [Column("ent_id")]
        public int Id { get; set; }

        [Column("ent_name")]
        public string Name { get; set; }

        [Column("ent_description")]
        public string Description { get; set; }

        [Column("ent_phone")]
        public string Phone { get; set; }

        [Column("ent_logo")]
        public string Logo { get; set; }

        [Column("ent_address")]
        public string Address { get; set; }

        [Column("ent_links")]
        public string Links { get; set; }

        [Column("ent_rfc")]
        public string RFC { get; set; }

        [Column("acc_id")]
        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        public virtual ICollection<Manager> Managers { get; set; }
    }
}