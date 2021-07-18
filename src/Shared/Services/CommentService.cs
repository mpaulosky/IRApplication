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
	public class CommentService : ICommentService
	{
		private readonly IRepository _repository;
		private readonly IMapper _mapper;
		private readonly ILogger<CommentService> _logger;

		/// <summary>
		/// Comment Service Constructor
		/// </summary>
		/// <param name="repository"></param>
		/// <param name="mapper"></param>
		/// <param name="logger"></param>
		public CommentService(IRepository repository, IMapper mapper, ILogger<CommentService> logger)
		{
			_repository = repository ?? throw new ArgumentNullException(nameof(repository));
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
			_logger = logger;
		}

		/// <summary>
		/// Get all the Comments
		/// </summary>
		/// <returns>A Task of IEnumerable CommentDto's</returns>
		public async Task<IEnumerable<CommentDto>> GetCommentsAsync()
		{
			var results = await _repository.SelectAllAsync<Comment>();
			var items = _mapper.Map<IEnumerable<CommentDto>>(results);
			return items;
		}

		/// <summary>
		/// Get an Comment with the passed in id
		/// </summary>
		/// <param name="id">int Comment Id</param>
		/// <returns>A single CommentDto</returns>
		public async Task<CommentDto> GetCommentByIdAsync(long id)
		{
			await EnforceCommentExistenceAsync(id);
			var comment = await _repository.SelectByIdAsync<Comment>(id);
			return _mapper.Map<CommentDto>(comment);
		}

		/// <summary>
		/// Creates a new Comment
		/// </summary>
		/// <param name="comment">A NewCommentDto</param>
		/// <returns>A Task of CommentDto</returns>
		public async Task<CommentDto> CreateCommentAsync(NewCommentDto comment)
		{
			try
			{
				var commentEntity = _mapper.Map<Comment>(comment);

				await _repository.CreateAsync(commentEntity);

				return _mapper.Map<Comment, CommentDto>(commentEntity);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Creating new Comment Failed!");
				throw new CommentNotCreatedException(_mapper.Map<Comment>(comment));
			}
		}

		/// <summary>
		/// Updates an Comment
		/// </summary>
		/// <param name="id">long Comment Id</param>
		/// <param name="comment">An CommentForUpdateDto</param>
		/// <returns>A Task of Boolean</returns>
		public async Task<bool> UpdateCommentAsync(long id, CommentForUpdateDto comment)
		{
			var commentEntity = await EnforceCommentExistenceAsync(id);

			try
			{
				_mapper.Map(comment, commentEntity);

				await _repository.UpdateAsync(commentEntity);

				return true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Updating Comment: {Id} Failed!", comment.Id);
				throw new CommentNotUpdatedException(commentEntity);
			}
		}

		/// <summary>
		/// Deletes an Comment
		/// </summary>
		/// <param name="comment">An CommentForDeleteDto</param>
		/// <returns>A Task of Boolean</returns>
		public async Task<bool> DeleteCommentAsync(CommentForDeleteDto comment)
		{
			var commentEntity = await EnforceCommentExistenceAsync(comment.Id);

			try
			{
				commentEntity.IsDeleted = true;
				commentEntity.DateModifiedUtc = DateTimeOffset.Now;

				await _repository.UpdateAsync(commentEntity);

				return true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Delete Comment: {Id} Failed!", commentEntity.Id);
				throw new CommentNotDeletedException(commentEntity);
			}
		}

		/// <summary>
		/// Checks that an comment exist
		/// </summary>
		/// <param name="id">An Comment Id</param>
		/// <returns>A Task of Boolean</returns>
		public async Task<bool> CommentExistsAsync(long id)
		{
			var comment = await _repository.SelectByIdAsync<Comment>(id);
			return comment != null;
		}

		/// <summary>
		/// Checks if an comment exsists
		/// </summary>
		/// <param name="id">An Comment Id</param>
		/// <returns>A Task of Comment</returns>
		/// <exception cref="CommentNotFoundException">If the Comment does not exist throws a CommentNotFoundException</exception>
		public async Task<Comment> EnforceCommentExistenceAsync(long id)
		{
			var comment = await _repository.SelectByIdAsync<Comment>(id);

			if (comment == null)
			{
				_logger.LogError("Comment with id: {Id}, hasn't been found in data", id);
				throw new CommentNotFoundException(new Comment { Id = id });
			}

			return comment;
		}
	}
}