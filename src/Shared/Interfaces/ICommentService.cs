using System.Collections.Generic;
using System.Threading.Tasks;
using IR.Shared.Dtos;
using IR.Shared.Models;

namespace IR.Shared.Interfaces
{
	public interface ICommentService
	{
		Task<IEnumerable<CommentDto>> GetCommentsAsync();
		Task<CommentDto> GetCommentByIdAsync(long id);
		Task<CommentDto> CreateCommentAsync(NewCommentDto comment);
		Task<bool> UpdateCommentAsync(long id, CommentForUpdateDto comment);
		Task<bool> DeleteCommentAsync(CommentForDeleteDto comment);
		Task<bool> CommentExistsAsync(long id);
		Task<Comment> EnforceCommentExistenceAsync(long id);
	}
}