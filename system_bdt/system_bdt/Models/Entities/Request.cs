using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace system_bdt.Models.Entities
{
	[Table("requests")]
	public class Request
	{
        [Key]
        [Column("rqs_id")]
        public int Id { get; set; }

        [Column("ent_id")]
        public int EnterpriseId { get; set; }

        [Column("rqs_title")]
        public string Title { get; set; }

        [Column("rqs_description")]
        public string Description { get; set; }

        [Column("rqs_create_date")]
        public DateTime CreateDate { get; set; }

        [Column("rqs_expiration_date")]
        public DateTime? ExpirationDate { get; set; }

        [Column("rqs_status")]
        public string Status { get; set; }

        [ForeignKey("EnterpriseId")]
        public virtual Enterprise Enterprise { get; set; }
    }
}