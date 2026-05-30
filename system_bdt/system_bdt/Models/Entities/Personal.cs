using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace system_bdt.Models.Entities
{
	[Table("personal")]
	public class Personal
	{
		[Key]
		[Column("prl_id")]
		public int Id { get; set; }

		[Column("prl_name")]
		public string Name { get; set; }
	}
}