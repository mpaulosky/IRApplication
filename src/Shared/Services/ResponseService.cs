using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using AutoMapper;

using IR.Shared.Dtos;
using IR.Shared.Infrastructure;
using IR.Shared.Interfaces;
using IR.Shared.Models;

using Microsoft.Extensions.Logging;

namespace IR.Shared.Services
{
	public class ResponseService : IResponseService
	{
		private readonly IRepository _repository;
		private readonly IMapper _mapper;
		private readonly ILogger<ResponseService> _logger;

		/// <summary>
		/// Response Service Constructor
		/// </summary>
		/// <param name="repository"></param>
		/// <param name="mapper"></param>
		/// <param name="logger"></param>
		public ResponseService(IRepository repository, IMapper mapper, ILogger<ResponseService> logger)
		{
			_repository = repository ?? throw new ArgumentNullException(nameof(repository));
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
			_logger = logger;
		}

		/// <summary>
		/// Get all the Responses
		/// </summary>
		/// <returns>A Task of IEnumerable ResponseDto's</returns>
		public async Task<IEnumerable<ResponseDto>> GetResponsesAsync()
		{
			var results = await _repository.SelectAllAsync<Response>();
			var items = _mapper.Map<IEnumerable<ResponseDto>>(results);
			return items;
		}

		/// <summary>
		/// Get an Response with the passed in id
		/// </summary>
		/// <param name="id">int Response Id</param>
		/// <returns>A single ResponseDto</returns>
		public async Task<ResponseDto> GetResponseByIdAsync(long id)
		{
			await EnforceResponseExistenceAsync(id);
			var response = await _repository.SelectByIdAsync<Response>(id);
			return _mapper.Map<ResponseDto>(response);
		}

		/// <summary>
		/// Creates a new Response
		/// </summary>
		/// <param name="response">A NewResponseDto</param>
		/// <returns>A Task of ResponseDto</returns>
		public async Task<ResponseDto> CreateResponseAsync(NewResponseDto response)
		{
			try
			{
				var responseEntity = _mapper.Map<Response>(response);

				await _repository.CreateAsync(responseEntity);

				return _mapper.Map<Response, ResponseDto>(responseEntity);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Creating new Response Failed!");
				throw new ResponseNotCreatedException(_mapper.Map<Response>(response));
			}
		}

		/// <summary>
		/// Updates an Response
		/// </summary>
		/// <param name="id">long Response Id</param>
		/// <param name="response">An ResponseForUpdateDto</param>
		/// <returns>A Task of Boolean</returns>
		public async Task<bool> UpdateResponseAsync(long id, ResponseForUpdateDto response)
		{
			var responseEntity = await EnforceResponseExistenceAsync(id);

			try
			{
				_mapper.Map(response, responseEntity);

				await _repository.UpdateAsync(responseEntity);

				return true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Updating Response: {Id} Failed!", response.Id);
				throw new ResponseNotUpdatedException(responseEntity);
			}
		}

		/// <summary>
		/// Deletes an Response
		/// </summary>
		/// <param name="response">An ResponseForDeleteDto</param>
		/// <returns>A Task of Boolean</returns>
		public async Task<bool> DeleteResponseAsync(ResponseForDeleteDto response)
		{
			var responseEntity = await EnforceResponseExistenceAsync(response.Id);

			try
			{
				responseEntity.IsDeleted = true;
				responseEntity.DateModifiedUtc = DateTimeOffset.Now;

				await _repository.UpdateAsync(responseEntity);

				return true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Delete Response: {Id} Failed!", responseEntity.Id);
				throw new ResponseNotDeletedException(responseEntity);
			}
		}

		/// <summary>
		/// Checks that an response exist
		/// </summary>
		/// <param name="id">An Response Id</param>
		/// <returns>A Task of Boolean</returns>
		public async Task<bool> ResponseExistsAsync(long id)
		{
			var response = await _repository.SelectByIdAsync<Response>(id);
			return response != null;
		}

		/// <summary>
		/// Checks if an response exsists
		/// </summary>
		/// <param name="id">An Response Id</param>
		/// <returns>A Task of Response</returns>
		/// <exception cref="ResponseNotFoundException">If the Response does not exist throws a ResponseNotFoundException</exception>
		public async Task<Response> EnforceResponseExistenceAsync(long id)
		{
			var response = await _repository.SelectByIdAsync<Response>(id);

			if (response == null)
			{
				_logger.LogError("Response with id: {Id}, hasn't been found in data", id);
				throw new ResponseNotFoundException(new Response { Id = id });
			}

			return response;
		}
	}
}