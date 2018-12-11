//ssl url https://localhost:44359/
//client id 661980703581-s4b0e4f4qkt6bi1aecsnf396e6ni53ek.apps.googleusercontent.com
//client secret mYWbss3mSnRwOOdeC-D89bOa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HerbCollection.Models
{


	public class Herb
	{

		public int ID { get; set; }

		[Display(Name = "Scientific Name")]
		[Required(ErrorMessage = "Please enter the scientific name")]
		public string HerbName_scientific { get; set; }

		[Display(Name = "Common Name")]
		[Required(ErrorMessage = "Please enter the common name")]
		public string HerbName_common { get; set; }

		[Display(Name = "Use")]
		public string Effect { get; set; }

		[Display(Name = "Harmful Conditions")]
		public string HarmfulConditions { get; set; }

		[Display(Name = "Flowering?")]
		public bool IsFlowering { get; set; }

		[Display(Name = "Daily Sunlight (hours)")]
		public int HoursOfSunlight { get; set; }

		[Display(Name = "Seed Depth (inches)")]
		public double SeedDepth { get; set; }

		public string Other { get; set; }

		[Display(Name = "Safety Type")]
		public int SafetyID { get; set; }

		public virtual Safety Safety { get; set; }

		public virtual ICollection<Category> Categories { get; set; }

		public Herb()
		{
			this.Categories = new HashSet<Category>();
		}

	}
}