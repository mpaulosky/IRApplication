using AutoMapper;

using IR.Shared.Dtos;
using IR.Shared.Infrastructure;
using IR.Shared.Interfaces;
using IR.Shared.Models;

using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IR.Shared.Services
{
	/// <summary>
	/// Issue Service
	/// </summary>
	public class IssueService : IIssueService
	{
		private readonly IRepository _repository;
		private readonly IMapper _mapper;
		private readonly ILogger<IssueService> _logger;

		/// <summary>
		/// Issue Service Constructor
		/// </summary>
		/// <param name="repository"></param>
		/// <param name="mapper"></param>
		/// <param name="logger"></param>
		public IssueService(IRepository repository, IMapper mapper, ILogger<IssueService> logger)
		{
			_repository = repository ?? throw new ArgumentNullException(nameof(repository));
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
			_logger = logger;
		}

		/// <summary>
		/// Get all the Issues
		/// </summary>
		/// <returns>A Task of IEnumerable IssueDto's</returns>
		public async Task<IEnumerable<IssueDto>> GetIssuesAsync()
		{
			var results = await _repository.SelectAllAsync<Issue>();

			var orderByResult = from s in results
													orderby s.Id
													select s;

			var items = _mapper.Map<IEnumerable<IssueDto>>(orderByResult.ToList<Issue>());
			return items;
		}

		/// <summary>
		/// Get an Issue with the passed in id
		/// </summary>
		/// <param name="id">int Issue Id</param>
		/// <returns>A single IssueDto</returns>
		public async Task<IssueDto> GetIssueByIdAsync(long id)
		{
			await EnforceIssueExistenceAsync(id);
			var issue = await _repository.SelectByIdAsync<Issue>(id);
			return _mapper.Map<IssueDto>(issue);
		}

		/// <summary>
		/// Creates a new Issue
		/// </summary>
		/// <param name="issue">A NewIssueDto</param>
		/// <returns>A Task of IssueDto</returns>
		public async Task<IssueDto> CreateIssueAsync(NewIssueDto issue)
		{
			try
			{
				var issueEntity = _mapper.Map<Issue>(issue);

				await _repository.CreateAsync(issueEntity);

				return _mapper.Map<Issue, IssueDto>(issueEntity);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Creating new Issue Failed!");
				throw new IssueNotCreatedException(_mapper.Map<Issue>(issue));
			}
		}

		/// <summary>
		/// Updates an Issue
		/// </summary>
		/// <param name="id">long Issue Id</param>
		/// <param name="issue">An IssueForUpdateDto</param>
		/// <returns>A Task of Boolean</returns>
		public async Task<bool> UpdateIssueAsync(long id, IssueForUpdateDto issue)
		{
			var issueEntity = await EnforceIssueExistenceAsync(id);

			try
			{
				_mapper.Map(issue, issueEntity);

				await _repository.UpdateAsync(issueEntity);

				return true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Updating Issue: {Id} Failed!", issue.Id);
				throw new IssueNotUpdatedException(issueEntity);
			}
		}

		/// <summary>
		/// Deletes an Issue
		/// </summary>
		/// <param name="issue">An IssueForDeleteDto</param>
		/// <returns>A Task of Boolean</returns>
		public async Task<bool> DeleteIssueAsync(IssueForDeleteDto issue)
		{
			var issueEntity = await EnforceIssueExistenceAsync(issue.Id);

			try
			{
				issueEntity.IsDeleted = true;
				issueEntity.DateModifiedUtc = DateTimeOffset.Now;

				await _repository.UpdateAsync(issueEntity);

				return true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Delete Issue: {Id} Failed!", issueEntity.Id);
				throw new IssueNotDeletedException(issueEntity);
			}
		}

		/// <summary>
		/// Checks that an issue exist
		/// </summary>
		/// <param name="id">An Issue Id</param>
		/// <returns>A Task of Boolean</returns>
		public async Task<bool> IssueExistsAsync(long id)
		{
			var issue = await _repository.SelectByIdAsync<Issue>(id);
			return issue != null;
		}

		/// <summary>
		/// Checks if an issue exsists
		/// </summary>
		/// <param name="id">An Issue Id</param>
		/// <returns>A Task of Issue</returns>
		/// <exception cref="IssueNotFoundException">If the Issue does not exist throws a IssueNotFoundException</exception>
		public async Task<Issue> EnforceIssueExistenceAsync(long id)
		{
			var issue = await _repository.SelectByIdAsync<Issue>(id);

			if (issue == null)
			{
				_logger.LogError("Issue with id: {Id}, hasn't been found in data", id);
				throw new IssueNotFoundException(new Issue { Id = id });
			}

			return issue;
		}
	}
}