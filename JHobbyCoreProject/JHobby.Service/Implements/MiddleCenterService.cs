﻿using JHobby.Repository.Interfaces;
using JHobby.Repository.Models.Dto;
using JHobby.Service.Interfaces;
using JHobby.Service.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHobby.Service.Implements
{
	public class MiddleCenterService : IMiddleCenterService
	{
		private readonly IMiddleCenterRepository _middleCenterRepository;
		private readonly ICommonService _commonService;

		public MiddleCenterService(IMiddleCenterRepository middleCenterRepository, ICommonService commonService)
		{
			_middleCenterRepository = middleCenterRepository;
			_commonService = commonService;
		}


		public IEnumerable<QueryCategoryTypeModel> GetCategoryTypeResult(SearchModel search)
		{
			var resporitory = _middleCenterRepository.GetCategoryTypeAll();
			var query = resporitory.Where(res => res.JoinDeadLine >= DateTime.Now && res.ActivityStatus=="1");
			if (search.categoryId != 0 && search.categoryTypeId != 0)
			{
				query = query.Where(res => res.CategoryId == search.categoryId && res.CategoryTypeId == search.categoryTypeId);
			}
			if (!string.IsNullOrEmpty(search.city) && !string.IsNullOrEmpty(search.area))
			{
				query = query.Where(res => res.ActivityCity == search.city && res.ActivityArea == search.area);
			}
			if (search.sort=="desc" )
			{
				query = query.OrderByDescending(res => res.JoinDeadLine);
			}
			return  query.Select(res => new QueryCategoryTypeModel
			{
				ActivityId = res.ActivityId,
				MemberId = res.MemberId,
				NickName = res.NickName,
                HeadShot = res.HeadShot,
                CategoryId = res.CategoryId,
				CategoryTypeId = res.CategoryTypeId,
				ActivityName = res.ActivityName.Trim(),
				ActivityStatus = res.ActivityStatus,
				ActivityLocation = res.ActivityLocation.Trim(),
				ActivityNotes = res.ActivityNotes?.Trim(),
                ShotActivityNotes = res.ActivityNotes.Substring(0, _commonService.ShotCheck(10, res.ActivityNotes)).Trim(),
                JoinDeadLine = res.JoinDeadLine.ToString("yyyy-MM-dd"),
				ActivityImages = res.ActivityImages.Where(ai => ai.IsCover == true).ToList()
			});

		}
	}
}
