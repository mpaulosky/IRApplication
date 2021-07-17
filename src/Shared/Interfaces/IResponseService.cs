using System.Collections.Generic;
using System.Threading.Tasks;

using IR.Shared.Dtos;
using IR.Shared.Models;

namespace IR.Shared.Interfaces
{
	public interface IResponseService
	{
		Task<IEnumerable<ResponseDto>> GetResponsesAsync();
		Task<ResponseDto> GetResponseByIdAsync(long id);
		Task<ResponseDto> CreateResponseAsync(NewResponseDto response);
		Task<bool> UpdateResponseAsync(long id, ResponseForUpdateDto response);
		Task<bool> DeleteResponseAsync(ResponseForDeleteDto response);
		Task<bool> ResponseExistsAsync(long id);
		Task<Response> EnforceResponseExistenceAsync(long id);
	}
}