namespace IR.Shared.Infrastructure.ErrorHandler
{
	public interface IErrorHandler
	{
		string GetMessage(ErrorMessages message);
	}
}
