﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHobby.Repository.Models.Dto
{
    public class LaunchaTeamDto
    {
        public int MemberId { get; set; }
        public string ActivityName { get; set; } = null!;
        public string ActivityStatus { get; set; } = null!;

        public string ReviewStatus { get; set; } = null!;
        public int? CurrentPeople { get; set; }
        public DateTime StartTime { get; set; }
        public bool IsCover { get; set; }
        public string ImageName { get; set; } = null!;
    	public int ActivityImageId { get; set; }
		public DateTime Created { get; set; }

		
    }
}
