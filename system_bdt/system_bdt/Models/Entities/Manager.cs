using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace system_bdt.Models.Entities
{
	[Table("manager")]
	public class Manager
	{
        [Key]
        [Column("mngr_id")]
        public int Id { get; set; }

        [Column("mngr_name")]
        public string Name { get; set; }

        [Column("mngr_email")]
        public string Email { get; set; }

        [Column("mngr_phone")]
        public string Phone { get; set; }

        [Column("ent_id")]
        public int EnterpriseId { get; set; }

        [ForeignKey("EnterpriseId")]
        public virtual Enterprise Enterprise { get; set; }
    }
}