﻿namespace JHobby.Website.Models.ViewModels
{
	public class UpdateMemberViewModel
	{
		public string OldPassword { get; set; } = null!;
		//public string HashPassword { get; set; } = null!;
		public string NewPassword { get; set; } = null!;
		public string PasswordTwo { get; set; } = null!;

	}
}
