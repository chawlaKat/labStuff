using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HerbCollection.Models
{
	public class Safety
	{
		public int ID { get; set; }

		[Display(Name = "Safety")]
		[MaxLength(64, ErrorMessage = "Max length of 64 characters")]
		[Required(ErrorMessage = "Please choose a safety value")]
		public string SafetyName { get; set; }

		public DateTime LastModified { get; set; }
		public string LastModifiedBy { get; set; }
	}
}