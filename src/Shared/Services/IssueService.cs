using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using IR.Shared.Interfaces;
using IR.Shared.Dtos;

using Microsoft.Extensions.Logging;
using IR.Shared.Models;
using IR.Shared.Infrastructure;

namespace IR.Shared.Services
{
	/// <summary>
	/// Issue Service
	/// </summary>
	public class IssueService : IIssueService
	{
		private readonly IRepositoryWrapper _repositoryWrapper;
		private readonly IMapper _mapper;
		private readonly ILogger<IssueService> _logger;

		/// <summary>
		/// Issue Service Constructor
		/// </summary>
		/// <param name="repositoryWrapper"></param>
		/// <param name="mapper"></param>
		/// <param name="logger"></param>
		public IssueService(IRepositoryWrapper repositoryWrapper, IMapper mapper, ILogger<IssueService> logger)
		{
			_repositoryWrapper = repositoryWrapper ?? throw new ArgumentNullException(nameof(repositoryWrapper));
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
			_logger = logger;
		}

		/// <summary>
		/// Get all the Issues
		/// </summary>
		/// <returns>A Task of IEnumerable IssueDto's</returns>
		public async Task<IEnumerable<IssueDto>> GetIssuesAsync()
		{
			var result = await _repositoryWrapper.Issue.GetIssuesAsync();
			var items = _mapper.Map<List<IssueDto>>(result).AsEnumerable();
			return items;
		}

		/// <summary>
		/// Get an Issue with the passed in id
		/// </summary>
		/// <param name="id">int Issue Id</param>
		/// <returns>A single IssueDto</returns>
		public async Task<IssueDto> GetIssueByIdAsync(int id)
		{
			await EnforceIssueExistenceAsync(id);
			var issue = await _repositoryWrapper.Issue.GetIssueByIdAsync(id);
			return _mapper.Map<IssueDto>(issue);
		}

		/// <summary>
		/// Creates a new Issue
		/// </summary>
		/// <param name="issue">A NewIssueDto</param>
		/// <returns>A Task of IssueDto</returns>
		public async Task<IssueDto> CreateIssueAsync(NewIssueDto issue)
		{
			var issueEntity = _mapper.Map<Issue>(issue);

			_repositoryWrapper.Issue.CreateIssue(issueEntity);

			try
			{
				await _repositoryWrapper.SaveAsync();

				return _mapper.Map<Issue, IssueDto>(issueEntity);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Creating new Issue: {Id} Failed!", issue);
				throw new IssueNotCreatedException(_mapper.Map<Issue>(issue));
			}
		}

		/// <summary>
		/// Updates an Issue
		/// </summary>
		/// <param name="id">int Issue Id</param>
		/// <param name="issue">An IssueForUpdateDto</param>
		/// <returns>A Task of Boolean</returns>
		public async Task<bool> UpdateIssueAsync(int id, IssueForUpdateDto issue)
		{
			var issueEntity = await EnforceIssueExistenceAsync(id);

			_mapper.Map(issue, issueEntity);

			_repositoryWrapper.Issue.UpdateIssue(issueEntity);

			try
			{
				await _repositoryWrapper.SaveAsync();
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
			issueEntity.IsDeleted = true;
			issueEntity.DateModifiedUtc = DateTimeOffset.Now;
			;
			_repositoryWrapper.Issue.DeleteIssue(issueEntity);

			try
			{
				await _repositoryWrapper.SaveAsync();
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
		public async Task<bool> IssueExistsAsync(int id)
		{
			var issue = await _repositoryWrapper.Issue.GetIssueByIdAsync(id);
			return issue != null;
		}

		/// <summary>
		/// Checks if an issue exsists
		/// </summary>
		/// <param name="id">An Issue Id</param>
		/// <returns>A Task of Issue</returns>
		/// <exception cref="IssueNotFoundException">If the Issue does not exist throws a IssueNotFoundException</exception>
		public async Task<Issue> EnforceIssueExistenceAsync(int id)
		{
			var issue = await _repositoryWrapper.Issue.GetIssueByIdAsync(id);
			if (issue == null)
			{
				_logger.LogError("Issue with id: {Id}, hasn't been found in", id);
				throw new IssueNotFoundException(new Issue { Id = id });
			}

			return issue;
		}
	}
}
