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
	/// Response Controller
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	[Produces(MediaTypeNames.Application.Json)]
	[Consumes(MediaTypeNames.Application.Json)]
	public class ResponsesController : ControllerBase
	{
		private readonly IResponseService _responseService;
		private readonly ILogger<ResponsesController> _logger;

		/// <summary>
		/// ResponseController Constructor
		/// </summary>
		/// <param name="responseService">IResponseService</param>
		/// <param name="logger">ILogger</param>
		/// <exception cref="ArgumentNullException">ArgumentNullException</exception>
		public ResponsesController(IResponseService responseService, ILogger<ResponsesController> logger)
		{
			_responseService = responseService ?? throw new ArgumentNullException(nameof(responseService));
			_logger = logger;
		}

		/// <summary>
		/// Get All Responses
		/// </summary>
		/// <returns>IActionResult</returns>
		[HttpGet("/responses", Name = nameof(GetResponsesAsync))]
		[ProducesResponseType(typeof(IEnumerable<ResponseDto>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetResponsesAsync()
		{
			try
			{
				var allResponses = await _responseService.GetResponsesAsync();

				_logger.LogInformation("Returned all responses from database");

				return Ok(allResponses);
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside GetResponsesAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}

		/// <summary>
		/// Response By Id
		/// </summary>
		/// <param name="id">int</param>
		/// <returns>IActionResult</returns>
		[HttpGet("/responses/{id}", Name = nameof(GetResponseByIdAsync))]
		[ProducesResponseType(typeof(ResponseDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> GetResponseByIdAsync([Required] long id)
		{
			try
			{
				var response = await _responseService.GetResponseByIdAsync(id);

				_logger.LogInformation("Returned response with Id: {Id} from database", id);

				return Ok(response);
			}
			catch (ResponseNotFoundException)
			{
				return NotFound();
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside ResponseByIdAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}

		/// <summary>
		/// Create Response Async
		/// </summary>
		/// <param name="response">NewResponseDto</param>
		/// <returns>IActionResult</returns>
		[HttpPost("/responses", Name = nameof(CreateResponseAsync))]
		[ProducesResponseType(typeof(ResponseDto), StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateResponseAsync([FromBody] NewResponseDto response)
		{
			try
			{
				if (response == null)
				{
					_logger.LogError("Response object sent from client is null");
					return BadRequest("Response object sent from client is null.");
				}

				if (!this.ModelState.IsValid)
				{
					_logger.LogError("Invalid response object sent from client");
					return BadRequest(ModelState);
				}

				var createdResponse = await _responseService.CreateResponseAsync(response);

				return CreatedAtRoute(nameof(GetResponseByIdAsync), new { id = createdResponse.Id }, createdResponse);
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside CreateResponseAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}

		/// <summary>
		/// Update Response Async
		/// </summary>
		/// <param name="id">int Response Id</param>
		/// <param name="response">ResponseForUpdateDto</param>
		/// <returns>IActionResult</returns>
		[HttpPut("/responses/{id}", Name = nameof(UpdateResponseAsync))]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateResponseAsync([FromRoute] long id, [FromBody] ResponseForUpdateDto response)
		{
			try
			{
				if (response == null)
				{
					_logger.LogError("Response object sent from client is null");
					return BadRequest("Response object sent from client is null.");
				}

				if (!ModelState.IsValid)
				{
					_logger.LogError("Invalid response object sent from client");
					return BadRequest(ModelState);
				}

				await _responseService.UpdateResponseAsync(id, response);

				return NoContent();
			}
			catch (ResponseNotFoundException)
			{
				return NotFound();
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside UpdateResponseAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}

		/// <summary>
		/// Delete Response Async
		/// </summary>
		/// <param name="response">ResponseForDeleteDto</param>
		/// <returns>IActionResult</returns>
		[HttpPut("/responses", Name = nameof(DeleteResponseAsync))]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteResponseAsync([FromBody] ResponseForDeleteDto response)
		{
			try
			{
				if (response == null)
				{
					_logger.LogError("Response object sent from client is null");
					return BadRequest("Response object sent from client is null.");
				}

				await _responseService.DeleteResponseAsync(response);

				return NoContent();
			}
			catch (ResponseNotFoundException)
			{
				return NotFound();
			}
			catch (Exception ex)
			{
				_logger.LogError("Something went wrong inside DeleteResponseAsync action: {Message}", ex.Message);
				return StatusCode(500, "Internal server error");
			}
		}
	}
}