﻿using JHobby.Repository.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHobby.Repository.Interfaces
{
	public interface IActivityRepository		
	{
		public bool InsertActivityBuild(ActivityBuildDto activityBuildDto);

		/// <summary>
		/// 活動頁面查詢
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public IQueryable<ActivityPageDto> GetActivityPageById(int id);
	}
}