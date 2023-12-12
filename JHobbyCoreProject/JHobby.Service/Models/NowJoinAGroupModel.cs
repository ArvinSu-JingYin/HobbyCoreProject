﻿using JHobby.Repository.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHobby.Service.Models
{
    public class NowJoinAGroupModel
    {
        public int ActivityUserId { get; set; }

        public int ActivityId { get; set; }

        //參團者ID
        public int MemberId { get; set; }

        public string ActivityName { get; set; } = null!;

        public string ReviewStatus { get; set; } = null!;

        public int? CurrentPeople { get; set; }

        public int? MaxPeople { get; set; }

        //團主NickName
        public string? NickName { get; set; }

        public string? DateConvert { get; set; }

        public string? TimeConvert { get; set; }

        public string ImageName { get; set; } = null!;

    }
}
