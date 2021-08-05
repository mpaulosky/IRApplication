using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using System.Threading.Tasks;

using IR.Shared.Dtos;
using IR.Shared.Infrastructure;
using IR.Shared.Interfaces;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IR.Server.Controllers
{
	/// <summary>
	/// Comment Controller
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	[Produces(MediaTypeNames.Application.Json)]
	[Consumes(MediaTypeNames.Application.Json)]
	public class CommentController : ControllerBase
	{
		private readonly ICommentService _commentService;
		private readonly ILogger<CommentController> _logger;

		/// <summary>
		/// CommentController Constructor
		/// </summary>
		/// <param name="commentService">ICommentService</param>
		/// <param name="logger">ILogger</param>
		/// <exception cref="ArgumentNullException">ArgumentNullException</exception>
		public CommentController(ICommentService commentService, ILogger<CommentController> logger)
		{
			_commentService = commentService ?? throw new ArgumentNullException(nameof(commentService));
			_logger = logger;
		}

		/// <summary>
		/// Get All Comments
		/// </summary>
		/// <returns>IActionResult</returns>
		[HttpGet("/comments", Name = nameof(GetCommentsAsync))]
		[ProducesResponseType(typeof(IEnumerable<CommentDto>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetCommentsAsync()
		{
			try
			{
				var allComments = await _commentService.GetCommentsAsync();

				_logger.LogInformation("Returned all comments from database");

				return Ok(allComments);
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside GetCommentsAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}

		/// <summary>
		/// Comment By Id
		/// </summary>
		/// <param name="id">int</param>
		/// <returns>IActionResult</returns>
		[HttpGet("/comment/{id}", Name = nameof(GetCommentByIdAsync))]
		[ProducesResponseType(typeof(CommentDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> GetCommentByIdAsync([Required] long id)
		{
			try
			{
				var comment = await _commentService.GetCommentByIdAsync(id);

				_logger.LogInformation("Returned comment with Id: {Id} from database", id);

				return Ok(comment);
			}
			catch (CommentNotFoundException)
			{
				return NotFound();
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside CommentByIdAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}

		/// <summary>
		/// Create Comment Async
		/// </summary>
		/// <param name="comment">CommentForCreationDto</param>
		/// <returns>IActionResult</returns>
		[HttpPost("/comment", Name = nameof(CreateCommentAsync))]
		[ProducesResponseType(typeof(CommentDto), StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateCommentAsync([FromBody] NewCommentDto comment)
		{
			try
			{
				if (comment == null)
				{
					_logger.LogError("Comment object sent from client is null");
					return BadRequest("Comment object sent from client is null.");
				}

				if (!this.ModelState.IsValid)
				{
					_logger.LogError("Invalid comment object sent from client");
					return BadRequest(ModelState);
				}

				var createdComment = await _commentService.CreateCommentAsync(comment);

				return CreatedAtRoute(nameof(GetCommentByIdAsync), new { id = createdComment.Id }, createdComment);
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside CreateCommentAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}

		/// <summary>
		/// Update Comment Async
		/// </summary>
		/// <param name="id">int Comment Id</param>
		/// <param name="comment">CommentForUpdateDto</param>
		/// <returns>IActionResult</returns>
		[HttpPut("/comment/{id}", Name = nameof(UpdateCommentAsync))]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateCommentAsync([FromRoute] long id, [FromBody] CommentForUpdateDto comment)
		{
			try
			{
				if (comment == null)
				{
					_logger.LogError("Comment object sent from client is null");
					return BadRequest("Comment object sent from client is null.");
				}

				if (!ModelState.IsValid)
				{
					_logger.LogError("Invalid comment object sent from client");
					return BadRequest(ModelState);
				}

				await _commentService.UpdateCommentAsync(id, comment);

				return NoContent();
			}
			catch (CommentNotFoundException)
			{
				return NotFound();
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside UpdateCommentAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}

		/// <summary>
		/// Delete Comment Async
		/// </summary>
		/// <param name="comment">CommentForDeleteDto</param>
		/// <returns>IActionResult</returns>
		[HttpDelete("/comment", Name = nameof(DeleteCommentAsync))]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteCommentAsync([FromBody] CommentForDeleteDto comment)
		{
			try
			{
				if (comment == null)
				{
					_logger.LogError("Comment object sent from client is null");
					return BadRequest("Comment object sent from client is null.");
				}

				await _commentService.DeleteCommentAsync(comment);

				return NoContent();
			}
			catch (CommentNotFoundException)
			{
				return NotFound();
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside DeleteCommentAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}
	}
}