using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace system_bdt.Models.Entities
{
	[Table("degree")]
	public class Degree
	{
		[Key]
		[Column("dgr_id")]
		public int Id { get; set; }

		[Column("dgr_name")]
		public string Name { get; set; }
	}
}