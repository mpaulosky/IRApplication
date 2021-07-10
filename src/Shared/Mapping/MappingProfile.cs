﻿using System.Collections.Generic;

using AutoMapper;

using IR.Shared.Dtos;
using IR.Shared.Models;

namespace IR.Shared.Mapping
{
	/// <summary>
	///   MappingProfile
	/// </summary>
	public class MappingProfile : Profile
	{
		/// <summary>
		///   MappingProfile Constructor
		/// </summary>
		public MappingProfile()
		{
			// Issues
			CreateMap<Issue, IssueDto>();
			CreateMap<IssueDto, Issue>();
			CreateMap<NewIssueDto, Issue>();
			CreateMap<IssueForUpdateDto, Issue>();
			CreateMap<IssueForDeleteDto, Issue>();
			CreateMap<List<Issue>, List<IssueDto>>();
			CreateMap<List<IssueDto>, List<Issue>>();
		}
	}
}
