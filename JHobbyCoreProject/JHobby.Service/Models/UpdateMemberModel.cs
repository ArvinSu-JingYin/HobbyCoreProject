﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHobby.Service.Models
{
	public class UpdateMemberModel
	{
		public string OldPassword { get; set; } = null!;
		//public string HashPassword { get; set; } = null!;
		public string NewPassword { get; set; } = null!;
		public string PasswordTwo { get; set; } = null!;

	}
}
