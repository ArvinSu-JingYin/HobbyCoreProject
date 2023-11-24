﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHobby.Service.Models
{
	public class SearchModel
	{
		public int categoyId { get; set; }
		public int categoryTypeId { get; set; }
		public int top { get; set; }
		public string? city { get; set; }
		public string? area { get; set; }

		public string? sort { get; set; }
	}
}
