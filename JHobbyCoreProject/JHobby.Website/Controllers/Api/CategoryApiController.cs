﻿using AutoMapper;
using Hangfire;
using JHobby.Service.Interfaces;
using JHobby.Service.Models;
using JHobby.Website.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JHobby.Website.Controllers.Api
{
	[Route("[controller]/[action]")]
	[ApiController]
	public class CategoryApiController : ControllerBase
	{
		private readonly ICategoryService _categoryService;
		private readonly IMapper _mapper;
        private readonly IBackgroundJobClient backgroundJobs;
        private readonly ISendMailService _sendMailService;

        public CategoryApiController(ICategoryService categoryService, IMapper mapper, IBackgroundJobClient backgroundJobs, ISendMailService sendMailService)
		{
			_categoryService = categoryService;
			_mapper = mapper;
            this.backgroundJobs = backgroundJobs;
            _sendMailService = sendMailService;
        }

        [HttpGet]
        public string ExecJob()
        {
            return backgroundJobs.Enqueue(() => _sendMailService.SendLetter("Guo1997tw@gmail.com"));
        }

        [HttpGet]
		public IEnumerable<CategoryViewModel> GetCategoriesAll()
		{
			return _mapper.Map<IEnumerable<CategoryViewModel>>(_categoryService.GetList());
		}

		[HttpGet("{id}")]
		public ActionResult<IEnumerable<CategoryViewModel>> GetCategoriesById(int id)
		{
			var servicesDto = _categoryService.GetDetail(id);

			if (servicesDto == null) { return NotFound(); }

			var viewModel = new CategoryViewModel
			{
				CategoryId = servicesDto.CategoryId,
				CategoryName = servicesDto.CategoryName
			};

			return Ok(viewModel);
		}

		[HttpPost]
		public IActionResult InsertCategory(CreateCategoryViewModel createCategoryViewModel)
		{
			var mapper = new CreateCategoryModel
            {
				CategoryName = createCategoryViewModel.CategoryName
			};

			var result = _categoryService.CreateCategory(mapper);

			return Ok(result);
		}

		[HttpPut("{id}")]
		public IActionResult UpdateCategory(int id, [FromBody] UpdateCategoryViewModel updateCategoryViewModel)
		{
			if(id < 0) {  return BadRequest(); }

			var mapper = new UpdateCategoryModel
			{
				CategoryName = updateCategoryViewModel.CategoryName
			};

			var result = _categoryService.UpdateCategory(id, mapper);

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteCategory(int id)
		{
			if (id < 0) { return BadRequest(); }

			var result = _categoryService.DeleteCategory(id);

			return Ok(result);
		}
    }
}