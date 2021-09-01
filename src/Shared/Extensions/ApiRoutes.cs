namespace IR.Shared.Extensions
{
	public static class ApiRoutes
	{
		private static readonly string _baseUrl = "https://localhost:44368/";

		public static class Comments
		{
			private static readonly string _controllerUrl = string.Concat(_baseUrl, "comments");

			public static readonly string GetCommentsAsync = _controllerUrl;

			public static readonly string GetCommentByIdAsync = string.Concat(_controllerUrl, "/{id}");

			public static readonly string CreateCommentAsync = _controllerUrl;

			public static readonly string UpdateCommentAsync = string.Concat(_controllerUrl, "/{id}");

			public static readonly string DeleteCommentAsync = _controllerUrl;
		}
		public static class Issues
		{
			private static readonly string _controllerUrl = string.Concat(_baseUrl, "issues");

			public static readonly string GetIssuesAsync = _controllerUrl;

			public static readonly string GetIssueByIdAsync = string.Concat(_controllerUrl, "/{id}");

			public static readonly string CreateIssueAsync = _controllerUrl;

			public static readonly string UpdateIssueAsync = string.Concat(_controllerUrl, "/{id}");

			public static readonly string DeleteIssueAsync = _controllerUrl;
		}
		public static class Responses
		{
			private static readonly string _controllerUrl = string.Concat(_baseUrl, "responses");

			public static readonly string GetResponsesAsync = _controllerUrl;

			public static readonly string GetResponseByIdAsync = string.Concat(_controllerUrl, "/{id}");

			public static readonly string CreateResponseAsync = _controllerUrl;

			public static readonly string UpdateResponseAsync = string.Concat(_controllerUrl, "/{id}");

			public static readonly string DeleteResponseAsync = _controllerUrl;
		}

	}
}
