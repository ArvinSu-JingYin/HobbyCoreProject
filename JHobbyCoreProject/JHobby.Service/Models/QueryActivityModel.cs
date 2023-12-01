﻿using JHobby.Repository.Models.Entity;

namespace JHobby.Service.Models
{
    public class QueryActivityModel
    {
		public int ActivityId { get; set; }
		public int MemberId { get; set; }
		public string? NickName { get; set; }
		public string ActivityName { get; set; } = null!;
		public string ActivityStatus { get; set; } = null!;
		public string ActivityLocation { get; set; } = null!;
		public string? ActivityNotes { get; set; }
        public string? ShotActivityNotes { get; set; }
        public string? JoinDeadLine { get; set; }
		public virtual ICollection<ActivityImage> ActivityImages { get; set; } = new List<ActivityImage>();
	}
}
