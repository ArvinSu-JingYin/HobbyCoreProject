﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHobby.Service.Models
{
    public class ProfileModel
    {
        public int MemberId { get; set; }
        public string? NickName { get; set; }
        public string? Gender { get; set; }
        public string? AcitveCity { get; set; }
        public string? PersonalProfile { get; set; }
    }
}
