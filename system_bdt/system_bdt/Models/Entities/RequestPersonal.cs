using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace system_bdt.Models.Entities
{
	[Table("rqs_personal")]
	public class RequestPersonal
	{
        [Key, Column(Order = 0)]
        public int rqs_id { get; set; }

        [Key, Column(Order = 1)]
        public int prl_id { get; set; }

        [ForeignKey("rqs_id")]
        public virtual Request Request { get; set; }

        [ForeignKey("prl_id")]
        public virtual Personal Personal { get; set; }
    }
}