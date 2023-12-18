﻿using Business.Dtos.Requests.Skill;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.Skill;
using Business.Dtos.Responses.User;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
	public interface ISkillService
	{
		Task<CreatedSkillResponse> AddAsync(CreateSkillRequest createSkillRequest);
		Task<IPaginate<GetListSkillResponse>> GetListAsync(PageRequest pageRequest);
		Task<DeletedSkillResponse> DeleteAsync(DeleteSkillRequest deleteSkillRequest);
		Task<UpdatedSkillResponse> UpdateAsync(UpdateSkillRequest UpdateSkillRequest);
		Task<GetSkillResponse> GetByIdAsync(GetSkillRequest getSkillRequest);
	}
}
