using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using System.Threading.Tasks;

using IR.Shared.Interfaces;
using IR.Shared.Dtos;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IR.Shared.Infrastructure;

namespace IR.Server.Controllers
{
	/// <summary>
	/// Issue Controller
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	[Produces(MediaTypeNames.Application.Json)]
	[Consumes(MediaTypeNames.Application.Json)]
	public class IssueController : ControllerBase
	{
		private readonly IIssueService _issueService;
		private readonly ILogger<IssueController> _logger;

		/// <summary>
		/// IssueController Constructor
		/// </summary>
		/// <param name="issueService">IIssueService</param>
		/// <param name="logger">ILogger</param>
		/// <exception cref="ArgumentNullException">ArgumentNullException</exception>
		public IssueController(IIssueService issueService, ILogger<IssueController> logger)
		{
			_issueService = issueService ?? throw new ArgumentNullException(nameof(issueService));
			_logger = logger;
		}

		/// <summary>
		/// Get All Issues
		/// </summary>
		/// <returns>IActionResult</returns>
		[HttpGet("/issues", Name = nameof(GetIssuesAsync))]
		[ProducesResponseType(typeof(IEnumerable<IssueDto>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetIssuesAsync()
		{
			try
			{
				var allIssues = await _issueService.GetIssuesAsync();

				_logger.LogInformation("Returned all issues from database");

				return Ok(allIssues);
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside GetIssuesAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}

		/// <summary>
		/// Issue By Id
		/// </summary>
		/// <param name="id">int</param>
		/// <returns>IActionResult</returns>
		[HttpGet("/issues/{id}", Name = nameof(GetIssueByIdAsync))]
		[ProducesResponseType(typeof(IssueDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> GetIssueByIdAsync([Required] long id)
		{
			try
			{
				var issue = await _issueService.GetIssueByIdAsync(id);

				_logger.LogInformation("Returned issue with Id: {Id} from database", id);

				return Ok(issue);
			}
			catch (IssueNotFoundException)
			{
				return NotFound();
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside IssueByIdAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}

		/// <summary>
		/// Create Issue Async
		/// </summary>
		/// <param name="issue">IssueForCreationDto</param>
		/// <returns>IActionResult</returns>
		[HttpPost("/issues", Name = nameof(CreateIssueAsync))]
		[ProducesResponseType(typeof(IssueDto), StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateIssueAsync([FromBody] NewIssueDto issue)
		{
			try
			{
				if (issue == null)
				{
					_logger.LogError("Issue object sent from client is null");
					return BadRequest("Issue object sent from client is null.");
				}

				if (!this.ModelState.IsValid)
				{
					_logger.LogError("Invalid issue object sent from client");
					return BadRequest(ModelState);
				}

				var createdIssue = await _issueService.CreateIssueAsync(issue);

				return CreatedAtRoute(nameof(GetIssueByIdAsync), new { id = createdIssue.Id }, createdIssue);
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside CreateIssueAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}

		/// <summary>
		/// Update Issue Async
		/// </summary>
		/// <param name="id">int Issue Id</param>
		/// <param name="issue">IssueForUpdateDto</param>
		/// <returns>IActionResult</returns>
		[HttpPut("/issues/{id}", Name = nameof(UpdateIssueAsync))]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateIssueAsync([FromRoute] long id, [FromBody] IssueForUpdateDto issue)
		{
			try
			{
				if (issue == null)
				{
					_logger.LogError("Issue object sent from client is null");
					return BadRequest("Issue object sent from client is null.");
				}

				if (!ModelState.IsValid)
				{
					_logger.LogError("Invalid issue object sent from client");
					return BadRequest(ModelState);
				}

				await _issueService.UpdateIssueAsync(id, issue);

				return NoContent();
			}
			catch (IssueNotFoundException)
			{
				return NotFound();
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside UpdateIssueAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}

		/// <summary>
		/// Delete Issue Async
		/// </summary>
		/// <param name="issue">IssueForDeleteDto</param>
		/// <returns>IActionResult</returns>
		[HttpDelete("/issues", Name = nameof(DeleteIssueAsync))]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteIssueAsync([FromBody] IssueForDeleteDto issue)
		{
			try
			{
				if (issue == null)
				{
					_logger.LogError("Issue object sent from client is null");
					return BadRequest("Issue object sent from client is null.");
				}

				await _issueService.DeleteIssueAsync(issue);

				return NoContent();
			}
			catch (IssueNotFoundException)
			{
				return NotFound();
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside DeleteIssueAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}
	}
}
