﻿namespace JHobby.Repository.Models.Dto
{
    public class CreateWishDto
    {
		public int MemberId { get; set; }

		public int ActivityId { get; set; }

		public DateTime AddTime { get; set; }
	}
}