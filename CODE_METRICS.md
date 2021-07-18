<!-- markdownlint-capture -->
<!-- markdownlint-disable -->

# Code Metrics

This file is dynamically maintained by a bot, *please do not* edit this by hand. It represents various [code metrics](https://aka.ms/dotnet/code-metrics), such as cyclomatic complexity, maintainability index, and so on.

<div id='ir-server'></div>

## IR.Server :heavy_check_mark:

The *IR.Server.csproj* project file contains:

- 2 namespaces.
- 5 named types.
- 667 total lines of source code.
- Approximately 234 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

<details>
<summary>
  <strong id="ir-server-controllers">
    IR.Server.Controllers :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Server.Controllers` namespace contains 3 named types.

- 3 named types.
- 564 total lines of source code.
- Approximately 204 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

<details>
<summary>
  <strong id="commentcontroller">
    CommentController :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentController` contains 8 members.
- 185 total lines of source code.
- Approximately 68 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [26](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/CommentController.cs#L26 "ICommentService CommentController._commentService") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | [27](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/CommentController.cs#L27 "ILogger<CommentController> CommentController._logger") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [35](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/CommentController.cs#L35 "CommentController.CommentController(ICommentService commentService, ILogger<CommentController> logger)") | 83 | 2 :heavy_check_mark: | 0 | 5 | 11 / 2 |
| Method | [101](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/CommentController.cs#L101 "Task<IActionResult> CommentController.CreateCommentAsync(NewCommentDto comment)") | 59 | 3 :heavy_check_mark: | 0 | 11 | 34 / 14 |
| Method | [177](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/CommentController.cs#L177 "Task<IActionResult> CommentController.DeleteCommentAsync(CommentForDeleteDto comment)") | 63 | 2 :heavy_check_mark: | 0 | 10 | 32 / 12 |
| Method | [72](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/CommentController.cs#L72 "Task<IActionResult> CommentController.GetCommentByIdAsync(long id)") | 65 | 1 :heavy_check_mark: | 0 | 10 | 28 / 10 |
| Method | [47](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/CommentController.cs#L47 "Task<IActionResult> CommentController.GetCommentsAsync()") | 67 | 1 :heavy_check_mark: | 0 | 9 | 22 / 8 |
| Method | [138](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/CommentController.cs#L138 "Task<IActionResult> CommentController.UpdateCommentAsync(long id, CommentForUpdateDto comment)") | 59 | 3 :heavy_check_mark: | 0 | 11 | 40 / 16 |

<a href="#ir-server-controllers">:top: back to IR.Server.Controllers</a>

</details>

<details>
<summary>
  <strong id="issuecontroller">
    IssueController :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueController` contains 8 members.
- 185 total lines of source code.
- Approximately 68 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [26](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/IssueController.cs#L26 "IIssueService IssueController._issueService") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | [27](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/IssueController.cs#L27 "ILogger<IssueController> IssueController._logger") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [35](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/IssueController.cs#L35 "IssueController.IssueController(IIssueService issueService, ILogger<IssueController> logger)") | 83 | 2 :heavy_check_mark: | 0 | 5 | 11 / 2 |
| Method | [101](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/IssueController.cs#L101 "Task<IActionResult> IssueController.CreateIssueAsync(NewIssueDto issue)") | 59 | 3 :heavy_check_mark: | 0 | 11 | 34 / 14 |
| Method | [177](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/IssueController.cs#L177 "Task<IActionResult> IssueController.DeleteIssueAsync(IssueForDeleteDto issue)") | 63 | 2 :heavy_check_mark: | 0 | 10 | 32 / 12 |
| Method | [72](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/IssueController.cs#L72 "Task<IActionResult> IssueController.GetIssueByIdAsync(long id)") | 65 | 1 :heavy_check_mark: | 0 | 10 | 28 / 10 |
| Method | [47](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/IssueController.cs#L47 "Task<IActionResult> IssueController.GetIssuesAsync()") | 67 | 1 :heavy_check_mark: | 0 | 9 | 22 / 8 |
| Method | [138](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/IssueController.cs#L138 "Task<IActionResult> IssueController.UpdateIssueAsync(long id, IssueForUpdateDto issue)") | 59 | 3 :heavy_check_mark: | 0 | 11 | 40 / 16 |

<a href="#ir-server-controllers">:top: back to IR.Server.Controllers</a>

</details>

<details>
<summary>
  <strong id="responsecontroller">
    ResponseController :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseController` contains 8 members.
- 185 total lines of source code.
- Approximately 68 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [27](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/ResponseController.cs#L27 "ILogger<ResponseController> ResponseController._logger") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | [26](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/ResponseController.cs#L26 "IResponseService ResponseController._responseService") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [35](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/ResponseController.cs#L35 "ResponseController.ResponseController(IResponseService responseService, ILogger<ResponseController> logger)") | 83 | 2 :heavy_check_mark: | 0 | 5 | 11 / 2 |
| Method | [101](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/ResponseController.cs#L101 "Task<IActionResult> ResponseController.CreateResponseAsync(NewResponseDto response)") | 59 | 3 :heavy_check_mark: | 0 | 11 | 34 / 14 |
| Method | [177](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/ResponseController.cs#L177 "Task<IActionResult> ResponseController.DeleteResponseAsync(ResponseForDeleteDto response)") | 63 | 2 :heavy_check_mark: | 0 | 10 | 32 / 12 |
| Method | [72](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/ResponseController.cs#L72 "Task<IActionResult> ResponseController.GetResponseByIdAsync(long id)") | 65 | 1 :heavy_check_mark: | 0 | 10 | 28 / 10 |
| Method | [47](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/ResponseController.cs#L47 "Task<IActionResult> ResponseController.GetResponsesAsync()") | 67 | 1 :heavy_check_mark: | 0 | 9 | 22 / 8 |
| Method | [138](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Controllers/ResponseController.cs#L138 "Task<IActionResult> ResponseController.UpdateResponseAsync(long id, ResponseForUpdateDto response)") | 59 | 3 :heavy_check_mark: | 0 | 11 | 40 / 16 |

<a href="#ir-server-controllers">:top: back to IR.Server.Controllers</a>

</details>

</details>

<details>
<summary>
  <strong id="ir-server">
    IR.Server :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Server` namespace contains 2 named types.

- 2 named types.
- 103 total lines of source code.
- Approximately 30 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="program">
    Program :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Program` contains 2 members.
- 15 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Program.cs#L15 "IHostBuilder Program.CreateHostBuilder(string[] args)") | 91 | 1 :heavy_check_mark: | 0 | 2 | 6 / 2 |
| Method | [10](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Program.cs#L10 "void Program.Main(string[] args)") | 97 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |

<a href="#ir-server">:top: back to IR.Server</a>

</details>

<details>
<summary>
  <strong id="startup">
    Startup :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Startup` contains 4 members.
- 82 total lines of source code.
- Approximately 27 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [28](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Startup.cs#L28 "Startup.Startup(IConfiguration configuration)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 1 |
| Property | [33](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Startup.cs#L33 "IConfiguration Startup.Configuration") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [82](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Startup.cs#L82 "void Startup.Configure(IApplicationBuilder app, IWebHostEnvironment env)") | 66 | 2 :heavy_check_mark: | 0 | 3 | 25 / 11 |
| Method | [36](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Server/Startup.cs#L36 "void Startup.ConfigureServices(IServiceCollection services)") | 58 | 1 :heavy_check_mark: | 0 | 9 | 45 / 15 |

<a href="#ir-server">:top: back to IR.Server</a>

</details>

</details>

<a href="#ir-server">:top: back to IR.Server</a>

<div id='ir-shared'></div>

## IR.Shared :radioactive:

The *IR.Shared.csproj* project file contains:

- 10 namespaces.
- 44 named types.
- 1,786 total lines of source code.
- Approximately 599 lines of executable code.
- The highest cyclomatic complexity is 11 :radioactive:.

<details>
<summary>
  <strong id="ir-shared-data">
    IR.Shared.Data :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Shared.Data` namespace contains 1 named types.

- 1 named types.
- 39 total lines of source code.
- Approximately 1 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="datacontext">
    DataContext :heavy_check_mark:
  </strong>
</summary>
<br>

- The `DataContext` contains 5 members.
- 36 total lines of source code.
- Approximately 1 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [11](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Data/DataContext.cs#L11 "DataContext.DataContext(DbContextOptions<DataContext> options)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 3 / 0 |
| Property | [17](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Data/DataContext.cs#L17 "DbSet<Comment> DataContext.Comments") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Property | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Data/DataContext.cs#L15 "DbSet<Issue> DataContext.Issues") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [19](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Data/DataContext.cs#L19 "void DataContext.OnModelCreating(ModelBuilder modelBuilder)") | 84 | 1 :heavy_check_mark: | 0 | 3 | 25 / 1 |
| Property | [16](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Data/DataContext.cs#L16 "DbSet<Response> DataContext.Responses") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 0 |

<a href="#ir-shared-data">:top: back to IR.Shared.Data</a>

</details>

</details>

<details>
<summary>
  <strong id="ir-shared-dtos">
    IR.Shared.Dtos :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Shared.Dtos` namespace contains 12 named types.

- 12 named types.
- 292 total lines of source code.
- Approximately 244 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="commentdto">
    CommentDto :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentDto` contains 8 members.
- 27 total lines of source code.
- Approximately 18 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L15 "string CommentDto.CommentDescription") | 100 | 2 :heavy_check_mark: | 0 | 3 | 3 / 4 |
| Property | [19](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L19 "string CommentDto.CommenterId") | 100 | 2 :heavy_check_mark: | 0 | 3 | 3 / 4 |
| Property | [23](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L23 "string CommentDto.CommenterName") | 100 | 2 :heavy_check_mark: | 0 | 3 | 3 / 4 |
| Property | [25](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L25 "DateTimeOffset CommentDto.DateAddedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Property | [27](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L27 "DateTimeOffset CommentDto.DateModifiedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Property | [11](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L11 "long CommentDto.Id") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | [29](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L29 "bool CommentDto.IsDeleted") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Property | [31](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L31 "long CommentDto.ResponseId") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#ir-shared-dtos">:top: back to IR.Shared.Dtos</a>

</details>

<details>
<summary>
  <strong id="commentfordeletedto">
    CommentForDeleteDto :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentForDeleteDto` contains 3 members.
- 6 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [39](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L39 "CommentForDeleteDto.CommentForDeleteDto(long Id, bool IsDeleted)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 6 / 0 |
| Property | [39](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L39 "long CommentForDeleteDto.Id") | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | [39](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L39 "bool CommentForDeleteDto.IsDeleted") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#ir-shared-dtos">:top: back to IR.Shared.Dtos</a>

</details>

<details>
<summary>
  <strong id="commentforupdatedto">
    CommentForUpdateDto :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentForUpdateDto` contains 6 members.
- 30 total lines of source code.
- Approximately 28 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [53](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L53 "string CommentForUpdateDto.CommentDescription") | 100 | 2 :heavy_check_mark: | 0 | 5 | 6 / 8 |
| Property | [59](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L59 "string CommentForUpdateDto.CommenterId") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [65](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L65 "string CommentForUpdateDto.CommenterName") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [67](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L67 "DateTimeOffset CommentForUpdateDto.DateModifiedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Property | [46](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L46 "long CommentForUpdateDto.Id") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | [69](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L69 "bool CommentForUpdateDto.IsDeleted") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |

<a href="#ir-shared-dtos">:top: back to IR.Shared.Dtos</a>

</details>

<details>
<summary>
  <strong id="issuedto">
    IssueDto :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueDto` contains 8 members.
- 21 total lines of source code.
- Approximately 18 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [17](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L17 "DateTimeOffset IssueDto.DateAddedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Property | [19](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L19 "DateTimeOffset IssueDto.DateModifiedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Property | [21](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L21 "DateTimeOffset IssueDto.DateResolvedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Property | [11](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L11 "long IssueDto.Id") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L15 "string IssueDto.InitiatorName") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 4 |
| Property | [23](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L23 "bool IssueDto.IsDeleted") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Property | [25](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L25 "bool IssueDto.IsResolved") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Property | [13](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L13 "string IssueDto.IssueDescription") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 4 |

<a href="#ir-shared-dtos">:top: back to IR.Shared.Dtos</a>

</details>

<details>
<summary>
  <strong id="issuefordeletedto">
    IssueForDeleteDto :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueForDeleteDto` contains 3 members.
- 4 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [31](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L31 "IssueForDeleteDto.IssueForDeleteDto(long Id, bool IsDeleted)") | 100 | 1 :heavy_check_mark: | 0 | 0 | 4 / 0 |
| Property | [31](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L31 "long IssueForDeleteDto.Id") | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | [31](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L31 "bool IssueForDeleteDto.IsDeleted") | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#ir-shared-dtos">:top: back to IR.Shared.Dtos</a>

</details>

<details>
<summary>
  <strong id="issueforupdatedto">
    IssueForUpdateDto :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueForUpdateDto` contains 7 members.
- 31 total lines of source code.
- Approximately 32 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [58](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L58 "DateTimeOffset IssueForUpdateDto.DateModifiedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Property | [60](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L60 "DateTimeOffset? IssueForUpdateDto.DateResolvedUtc") | 100 | 2 :heavy_check_mark: | 0 | 4 | 1 / 3 |
| Property | [38](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L38 "long IssueForUpdateDto.Id") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | [50](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L50 "string IssueForUpdateDto.InitiatorId") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [56](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L56 "string IssueForUpdateDto.InitiatorName") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [62](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L62 "bool IssueForUpdateDto.IsResolved") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 3 |
| Property | [44](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L44 "string IssueForUpdateDto.IssueDescription") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |

<a href="#ir-shared-dtos">:top: back to IR.Shared.Dtos</a>

</details>

<details>
<summary>
  <strong id="newcommentdto">
    NewCommentDto :heavy_check_mark:
  </strong>
</summary>
<br>

- The `NewCommentDto` contains 7 members.
- 32 total lines of source code.
- Approximately 32 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [82](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L82 "string NewCommentDto.CommentDescription") | 100 | 2 :heavy_check_mark: | 0 | 5 | 6 / 8 |
| Property | [88](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L88 "string NewCommentDto.CommenterId") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [94](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L94 "string NewCommentDto.CommenterName") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [96](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L96 "DateTimeOffset NewCommentDto.DateAddedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 3 |
| Property | [98](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L98 "DateTimeOffset NewCommentDto.DateModifiedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 3 |
| Property | [100](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L100 "bool NewCommentDto.IsDeleted") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Property | [102](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/CommentDtos.cs#L102 "long NewCommentDto.ResponseId") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#ir-shared-dtos">:top: back to IR.Shared.Dtos</a>

</details>

<details>
<summary>
  <strong id="newissuedto">
    NewIssueDto :heavy_check_mark:
  </strong>
</summary>
<br>

- The `NewIssueDto` contains 5 members.
- 24 total lines of source code.
- Approximately 30 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [85](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L85 "DateTimeOffset NewIssueDto.DateAddedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 3 |
| Property | [87](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L87 "DateTimeOffset NewIssueDto.DateModifiedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 3 |
| Property | [77](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L77 "string NewIssueDto.InitiatorId") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [83](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L83 "string NewIssueDto.InitiatorName") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [71](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/IssueDtos.cs#L71 "string NewIssueDto.IssueDescription") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |

<a href="#ir-shared-dtos">:top: back to IR.Shared.Dtos</a>

</details>

<details>
<summary>
  <strong id="newresponsedto">
    NewResponseDto :heavy_check_mark:
  </strong>
</summary>
<br>

- The `NewResponseDto` contains 7 members.
- 34 total lines of source code.
- Approximately 36 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [102](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L102 "DateTimeOffset NewResponseDto.DateAddedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 3 |
| Property | [104](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L104 "DateTimeOffset NewResponseDto.DateModifiedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 3 |
| Property | [106](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L106 "bool NewResponseDto.IsDeleted") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Property | [100](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L100 "long NewResponseDto.IssueId") | 100 | 2 :heavy_check_mark: | 0 | 3 | 3 / 4 |
| Property | [90](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L90 "string NewResponseDto.ResponderId") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [96](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L96 "string NewResponseDto.ResponderName") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [84](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L84 "string NewResponseDto.ResponseDescription") | 100 | 2 :heavy_check_mark: | 0 | 5 | 6 / 8 |

<a href="#ir-shared-dtos">:top: back to IR.Shared.Dtos</a>

</details>

<details>
<summary>
  <strong id="responsedto">
    ResponseDto :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseDto` contains 8 members.
- 29 total lines of source code.
- Approximately 22 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [25](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L25 "DateTimeOffset ResponseDto.DateAddedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Property | [27](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L27 "DateTimeOffset ResponseDto.DateModifiedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Property | [11](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L11 "long ResponseDto.Id") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | [29](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L29 "bool ResponseDto.IsDeleted") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Property | [33](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L33 "long ResponseDto.IssueId") | 100 | 2 :heavy_check_mark: | 0 | 3 | 3 / 4 |
| Property | [19](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L19 "string ResponseDto.ResponderId") | 100 | 2 :heavy_check_mark: | 0 | 3 | 3 / 4 |
| Property | [23](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L23 "string ResponseDto.ResponderName") | 100 | 2 :heavy_check_mark: | 0 | 3 | 3 / 4 |
| Property | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L15 "string ResponseDto.ResponseDescription") | 100 | 2 :heavy_check_mark: | 0 | 3 | 3 / 4 |

<a href="#ir-shared-dtos">:top: back to IR.Shared.Dtos</a>

</details>

<details>
<summary>
  <strong id="responsefordeletedto">
    ResponseForDeleteDto :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseForDeleteDto` contains 3 members.
- 6 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [41](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L41 "ResponseForDeleteDto.ResponseForDeleteDto(long Id, bool IsDeleted)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 6 / 0 |
| Property | [41](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L41 "long ResponseForDeleteDto.Id") | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | [41](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L41 "bool ResponseForDeleteDto.IsDeleted") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#ir-shared-dtos">:top: back to IR.Shared.Dtos</a>

</details>

<details>
<summary>
  <strong id="responseforupdatedto">
    ResponseForUpdateDto :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseForUpdateDto` contains 6 members.
- 30 total lines of source code.
- Approximately 28 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [69](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L69 "DateTimeOffset ResponseForUpdateDto.DateModifiedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Property | [48](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L48 "long ResponseForUpdateDto.Id") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | [71](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L71 "bool ResponseForUpdateDto.IsDeleted") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Property | [61](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L61 "string ResponseForUpdateDto.ResponderId") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [67](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L67 "string ResponseForUpdateDto.ResponderName") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [55](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Dtos/ResponseDtos.cs#L55 "string ResponseForUpdateDto.ResponseDescription") | 100 | 2 :heavy_check_mark: | 0 | 5 | 6 / 8 |

<a href="#ir-shared-dtos">:top: back to IR.Shared.Dtos</a>

</details>

</details>

<details>
<summary>
  <strong id="ir-shared-infrastructure-errorhandler">
    IR.Shared.Infrastructure.ErrorHandler :radioactive:
  </strong>
</summary>
<br>

The `IR.Shared.Infrastructure.ErrorHandler` namespace contains 3 named types.

- 3 named types.
- 63 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 11 :radioactive:.

<details>
<summary>
  <strong id="errorhandler">
    ErrorHandler :radioactive:
  </strong>
</summary>
<br>

- The `ErrorHandler` contains 1 members.
- 38 total lines of source code.
- Approximately 1 lines of executable code.
- The highest cyclomatic complexity is 11 :radioactive:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [9](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ErrorHandler/ErrorHandler.cs#L9 "string ErrorHandler.GetMessage(ErrorMessages message)") | 82 | 11 :radioactive: | 0 | 3 | 34 / 1 |

<a href="#ir-shared-infrastructure-errorhandler">:top: back to IR.Shared.Infrastructure.ErrorHandler</a>

</details>

<details>
<summary>
  <strong id="errormessages">
    ErrorMessages :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ErrorMessages` contains 9 members.
- 12 total lines of source code.
- Approximately 2 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [9](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ErrorHandler/ErrorMessagesEnum.cs#L9 "ErrorMessages.AuthCannotCreate") | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | [10](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ErrorHandler/ErrorMessagesEnum.cs#L10 "ErrorMessages.AuthCannotDelete") | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | [13](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ErrorHandler/ErrorMessagesEnum.cs#L13 "ErrorMessages.AuthCannotRetrieveToken") | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | [11](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ErrorHandler/ErrorMessagesEnum.cs#L11 "ErrorMessages.AuthCannotUpdate") | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | [12](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ErrorHandler/ErrorMessagesEnum.cs#L12 "ErrorMessages.AuthNotValidInformation") | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | [7](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ErrorHandler/ErrorMessagesEnum.cs#L7 "ErrorMessages.AuthUserDoesNotExists") | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | [8](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ErrorHandler/ErrorMessagesEnum.cs#L8 "ErrorMessages.AuthWrongCredentials") | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | [5](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ErrorHandler/ErrorMessagesEnum.cs#L5 "ErrorMessages.EntityNull") | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | [6](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ErrorHandler/ErrorMessagesEnum.cs#L6 "ErrorMessages.ModelValidation") | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#ir-shared-infrastructure-errorhandler">:top: back to IR.Shared.Infrastructure.ErrorHandler</a>

</details>

<details>
<summary>
  <strong id="ierrorhandler">
    IErrorHandler :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IErrorHandler` contains 1 members.
- 4 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [5](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ErrorHandler/IErrorHandler.cs#L5 "string IErrorHandler.GetMessage(ErrorMessages message)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#ir-shared-infrastructure-errorhandler">:top: back to IR.Shared.Infrastructure.ErrorHandler</a>

</details>

</details>

<details>
<summary>
  <strong id="ir-shared-infrastructure">
    IR.Shared.Infrastructure :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Shared.Infrastructure` namespace contains 13 named types.

- 13 named types.
- 191 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="commentnotcreatedexception">
    CommentNotCreatedException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentNotCreatedException` contains 2 members.
- 12 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [9](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/CommentExceptions.cs#L9 "CommentNotCreatedException.CommentNotCreatedException(BaseEntity comment)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [14](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/CommentExceptions.cs#L14 "CommentNotCreatedException.CommentNotCreatedException(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

<details>
<summary>
  <strong id="commentnotdeletedexception">
    CommentNotDeletedException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentNotDeletedException` contains 2 members.
- 13 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [23](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/CommentExceptions.cs#L23 "CommentNotDeletedException.CommentNotDeletedException(BaseEntity comment)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [28](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/CommentExceptions.cs#L28 "CommentNotDeletedException.CommentNotDeletedException(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

<details>
<summary>
  <strong id="commentnotfoundexception">
    CommentNotFoundException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentNotFoundException` contains 2 members.
- 13 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [37](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/CommentExceptions.cs#L37 "CommentNotFoundException.CommentNotFoundException(BaseEntity comment)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [42](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/CommentExceptions.cs#L42 "CommentNotFoundException.CommentNotFoundException(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

<details>
<summary>
  <strong id="commentnotupdatedexception">
    CommentNotUpdatedException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentNotUpdatedException` contains 2 members.
- 13 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [51](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/CommentExceptions.cs#L51 "CommentNotUpdatedException.CommentNotUpdatedException(BaseEntity comment)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [56](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/CommentExceptions.cs#L56 "CommentNotUpdatedException.CommentNotUpdatedException(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

<details>
<summary>
  <strong id="irserverexception">
    IRServerException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IRServerException` contains 3 members.
- 16 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [11](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/IRServerException.cs#L11 "IRServerException.IRServerException(string message)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 3 / 0 |
| Method | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/IRServerException.cs#L15 "IRServerException.IRServerException(string message, Exception innerException)") | 98 | 1 :heavy_check_mark: | 0 | 2 | 3 / 0 |
| Method | [19](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/IRServerException.cs#L19 "IRServerException.IRServerException(SerializationInfo info, StreamingContext context)") | 98 | 1 :heavy_check_mark: | 0 | 3 | 3 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

<details>
<summary>
  <strong id="issuenotcreatedexception">
    IssueNotCreatedException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueNotCreatedException` contains 2 members.
- 13 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [10](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/IssueExceptions.cs#L10 "IssueNotCreatedException.IssueNotCreatedException(BaseEntity issue)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/IssueExceptions.cs#L15 "IssueNotCreatedException.IssueNotCreatedException(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

<details>
<summary>
  <strong id="issuenotdeletedexception">
    IssueNotDeletedException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueNotDeletedException` contains 2 members.
- 13 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [24](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/IssueExceptions.cs#L24 "IssueNotDeletedException.IssueNotDeletedException(BaseEntity issue)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [29](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/IssueExceptions.cs#L29 "IssueNotDeletedException.IssueNotDeletedException(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

<details>
<summary>
  <strong id="issuenotfoundexception">
    IssueNotFoundException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueNotFoundException` contains 2 members.
- 13 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [38](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/IssueExceptions.cs#L38 "IssueNotFoundException.IssueNotFoundException(BaseEntity issue)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [43](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/IssueExceptions.cs#L43 "IssueNotFoundException.IssueNotFoundException(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

<details>
<summary>
  <strong id="issuenotupdatedexception">
    IssueNotUpdatedException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueNotUpdatedException` contains 2 members.
- 13 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [52](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/IssueExceptions.cs#L52 "IssueNotUpdatedException.IssueNotUpdatedException(BaseEntity issue)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [57](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/IssueExceptions.cs#L57 "IssueNotUpdatedException.IssueNotUpdatedException(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

<details>
<summary>
  <strong id="responsenotcreatedexception">
    ResponseNotCreatedException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseNotCreatedException` contains 2 members.
- 12 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [9](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ResponseExceptions.cs#L9 "ResponseNotCreatedException.ResponseNotCreatedException(BaseEntity response)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [14](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ResponseExceptions.cs#L14 "ResponseNotCreatedException.ResponseNotCreatedException(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

<details>
<summary>
  <strong id="responsenotdeletedexception">
    ResponseNotDeletedException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseNotDeletedException` contains 2 members.
- 13 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [23](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ResponseExceptions.cs#L23 "ResponseNotDeletedException.ResponseNotDeletedException(BaseEntity response)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [28](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ResponseExceptions.cs#L28 "ResponseNotDeletedException.ResponseNotDeletedException(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

<details>
<summary>
  <strong id="responsenotfoundexception">
    ResponseNotFoundException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseNotFoundException` contains 2 members.
- 13 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [37](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ResponseExceptions.cs#L37 "ResponseNotFoundException.ResponseNotFoundException(BaseEntity response)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [42](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ResponseExceptions.cs#L42 "ResponseNotFoundException.ResponseNotFoundException(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

<details>
<summary>
  <strong id="responsenotupdatedexception">
    ResponseNotUpdatedException :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseNotUpdatedException` contains 2 members.
- 13 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [51](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ResponseExceptions.cs#L51 "ResponseNotUpdatedException.ResponseNotUpdatedException(BaseEntity response)") | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [56](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Infrastructure/ResponseExceptions.cs#L56 "ResponseNotUpdatedException.ResponseNotUpdatedException(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |

<a href="#ir-shared-infrastructure">:top: back to IR.Shared.Infrastructure</a>

</details>

</details>

<details>
<summary>
  <strong id="ir-shared-interfaces">
    IR.Shared.Interfaces :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Shared.Interfaces` namespace contains 4 named types.

- 4 named types.
- 50 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="icommentservice">
    ICommentService :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ICommentService` contains 7 members.
- 10 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [16](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/ICommentService.cs#L16 "Task<bool> ICommentService.CommentExistsAsync(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [13](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/ICommentService.cs#L13 "Task<CommentDto> ICommentService.CreateCommentAsync(NewCommentDto comment)") | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Method | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/ICommentService.cs#L15 "Task<bool> ICommentService.DeleteCommentAsync(CommentForDeleteDto comment)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [17](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/ICommentService.cs#L17 "Task<Comment> ICommentService.EnforceCommentExistenceAsync(long id)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [12](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/ICommentService.cs#L12 "Task<CommentDto> ICommentService.GetCommentByIdAsync(long id)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [11](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/ICommentService.cs#L11 "Task<IEnumerable<CommentDto>> ICommentService.GetCommentsAsync()") | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Method | [14](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/ICommentService.cs#L14 "Task<bool> ICommentService.UpdateCommentAsync(long id, CommentForUpdateDto comment)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |

<a href="#ir-shared-interfaces">:top: back to IR.Shared.Interfaces</a>

</details>

<details>
<summary>
  <strong id="iissueservice">
    IIssueService :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IIssueService` contains 7 members.
- 10 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [13](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IIssueService.cs#L13 "Task<IssueDto> IIssueService.CreateIssueAsync(NewIssueDto issue)") | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Method | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IIssueService.cs#L15 "Task<bool> IIssueService.DeleteIssueAsync(IssueForDeleteDto issue)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [17](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IIssueService.cs#L17 "Task<Issue> IIssueService.EnforceIssueExistenceAsync(long id)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [12](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IIssueService.cs#L12 "Task<IssueDto> IIssueService.GetIssueByIdAsync(long id)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [11](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IIssueService.cs#L11 "Task<IEnumerable<IssueDto>> IIssueService.GetIssuesAsync()") | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Method | [16](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IIssueService.cs#L16 "Task<bool> IIssueService.IssueExistsAsync(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [14](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IIssueService.cs#L14 "Task<bool> IIssueService.UpdateIssueAsync(long id, IssueForUpdateDto issue)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |

<a href="#ir-shared-interfaces">:top: back to IR.Shared.Interfaces</a>

</details>

<details>
<summary>
  <strong id="irepository">
    IRepository :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IRepository` contains 5 members.
- 8 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [10](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IRepository.cs#L10 "Task IRepository.CreateAsync<T>(T entity)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [12](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IRepository.cs#L12 "Task IRepository.DeleteAsync<T>(T entity)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [8](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IRepository.cs#L8 "Task<IEnumerable<T>> IRepository.SelectAllAsync<T>()") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [9](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IRepository.cs#L9 "Task<T> IRepository.SelectByIdAsync<T>(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [11](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IRepository.cs#L11 "Task IRepository.UpdateAsync<T>(T entity)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#ir-shared-interfaces">:top: back to IR.Shared.Interfaces</a>

</details>

<details>
<summary>
  <strong id="iresponseservice">
    IResponseService :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IResponseService` contains 7 members.
- 10 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [13](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IResponseService.cs#L13 "Task<ResponseDto> IResponseService.CreateResponseAsync(NewResponseDto response)") | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Method | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IResponseService.cs#L15 "Task<bool> IResponseService.DeleteResponseAsync(ResponseForDeleteDto response)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [17](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IResponseService.cs#L17 "Task<Response> IResponseService.EnforceResponseExistenceAsync(long id)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [12](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IResponseService.cs#L12 "Task<ResponseDto> IResponseService.GetResponseByIdAsync(long id)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [11](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IResponseService.cs#L11 "Task<IEnumerable<ResponseDto>> IResponseService.GetResponsesAsync()") | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Method | [16](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IResponseService.cs#L16 "Task<bool> IResponseService.ResponseExistsAsync(long id)") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [14](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Interfaces/IResponseService.cs#L14 "Task<bool> IResponseService.UpdateResponseAsync(long id, ResponseForUpdateDto response)") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |

<a href="#ir-shared-interfaces">:top: back to IR.Shared.Interfaces</a>

</details>

</details>

<details>
<summary>
  <strong id="ir-shared-mapping">
    IR.Shared.Mapping :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Shared.Mapping` namespace contains 1 named types.

- 1 named types.
- 41 total lines of source code.
- Approximately 21 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="mappingprofile">
    MappingProfile :heavy_check_mark:
  </strong>
</summary>
<br>

- The `MappingProfile` contains 1 members.
- 38 total lines of source code.
- Approximately 21 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [18](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Mapping/MappingProfile.cs#L18 "MappingProfile.MappingProfile()") | 71 | 1 :heavy_check_mark: | 0 | 1 | 32 / 21 |

<a href="#ir-shared-mapping">:top: back to IR.Shared.Mapping</a>

</details>

</details>

<details>
<summary>
  <strong id="ir-shared-migrations">
    IR.Shared.Migrations :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Shared.Migrations` namespace contains 2 named types.

- 2 named types.
- 528 total lines of source code.
- Approximately 124 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="datacontextmodelsnapshot">
    DataContextModelSnapshot :heavy_check_mark:
  </strong>
</summary>
<br>

- The `DataContextModelSnapshot` contains 1 members.
- 202 total lines of source code.
- Approximately 49 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Migrations/DataContextModelSnapshot.cs#L15 "void DataContextModelSnapshot.BuildModel(ModelBuilder modelBuilder)") | 40 | 1 :heavy_check_mark: | 0 | 5 | 198 / 47 |

<a href="#ir-shared-migrations">:top: back to IR.Shared.Migrations</a>

</details>

<details>
<summary>
  <strong id="initialmigration">
    initialMigration :heavy_check_mark:
  </strong>
</summary>
<br>

- The `initialMigration` contains 3 members.
- 317 total lines of source code.
- Approximately 75 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [17](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Migrations/20210709220443_initialMigration.Designer.cs#L17 "void initialMigration.BuildTargetModel(ModelBuilder modelBuilder)") | 40 | 1 :heavy_check_mark: | 0 | 5 | 198 / 47 |
| Method | [109](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Migrations/20210709220443_initialMigration.cs#L109 "void initialMigration.Down(MigrationBuilder migrationBuilder)") | 82 | 1 :heavy_check_mark: | 0 | 2 | 11 / 3 |
| Method | [9](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Migrations/20210709220443_initialMigration.cs#L9 "void initialMigration.Up(MigrationBuilder migrationBuilder)") | 47 | 1 :heavy_check_mark: | 0 | 5 | 99 / 21 |

<a href="#ir-shared-migrations">:top: back to IR.Shared.Migrations</a>

</details>

</details>

<details>
<summary>
  <strong id="ir-shared-models">
    IR.Shared.Models :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Shared.Models` namespace contains 4 named types.

- 4 named types.
- 98 total lines of source code.
- Approximately 86 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="baseentity">
    BaseEntity :heavy_check_mark:
  </strong>
</summary>
<br>

- The `BaseEntity` contains 4 members.
- 12 total lines of source code.
- Approximately 10 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [13](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/BaseEntity.cs#L13 "DateTimeOffset BaseEntity.DateAddedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 3 |
| Property | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/BaseEntity.cs#L15 "DateTimeOffset BaseEntity.DateModifiedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 3 |
| Property | [11](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/BaseEntity.cs#L11 "long BaseEntity.Id") | 100 | 2 :heavy_check_mark: | 0 | 3 | 3 / 2 |
| Property | [17](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/BaseEntity.cs#L17 "bool BaseEntity.IsDeleted") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |

<a href="#ir-shared-models">:top: back to IR.Shared.Models</a>

</details>

<details>
<summary>
  <strong id="comment">
    Comment :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Comment` contains 4 members.
- 22 total lines of source code.
- Approximately 24 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [11](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Comment.cs#L11 "string Comment.CommentDescription") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [17](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Comment.cs#L17 "string Comment.CommenterId") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [23](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Comment.cs#L23 "string Comment.CommenterName") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [25](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Comment.cs#L25 "long Comment.ResponseId") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#ir-shared-models">:top: back to IR.Shared.Models</a>

</details>

<details>
<summary>
  <strong id="issue">
    Issue :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Issue` contains 6 members.
- 28 total lines of source code.
- Approximately 28 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [27](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Issue.cs#L27 "DateTimeOffset Issue.DateResolvedUtc") | 100 | 2 :heavy_check_mark: | 0 | 3 | 2 / 2 |
| Property | [18](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Issue.cs#L18 "string Issue.InitiatorId") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [24](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Issue.cs#L24 "string Issue.InitiatorName") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [30](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Issue.cs#L30 "bool Issue.IsResolved") | 100 | 2 :heavy_check_mark: | 0 | 2 | 2 / 2 |
| Property | [12](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Issue.cs#L12 "string Issue.IssueDescription") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [32](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Issue.cs#L32 "Response Issue.Response") | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#ir-shared-models">:top: back to IR.Shared.Models</a>

</details>

<details>
<summary>
  <strong id="response">
    Response :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Response` contains 5 members.
- 24 total lines of source code.
- Approximately 24 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [28](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Response.cs#L28 "List<Comment> Response.Comments") | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Property | [26](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Response.cs#L26 "int Response.IssueId") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | [18](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Response.cs#L18 "string Response.ResponderId") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [24](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Response.cs#L24 "string Response.ResponderName") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |
| Property | [12](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Models/Response.cs#L12 "string Response.ResponseDescription") | 100 | 2 :heavy_check_mark: | 0 | 5 | 5 / 8 |

<a href="#ir-shared-models">:top: back to IR.Shared.Models</a>

</details>

</details>

<details>
<summary>
  <strong id="ir-shared-repositories">
    IR.Shared.Repositories :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Shared.Repositories` namespace contains 1 named types.

- 1 named types.
- 40 total lines of source code.
- Approximately 9 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="repositorytdbcontext">
    Repository&lt;TDbContext&gt; :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Repository<TDbContext>` contains 7 members.
- 37 total lines of source code.
- Approximately 9 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [12](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Repositories/Repository.cs#L12 "TDbContext Repository<TDbContext>._dbContext") | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | [14](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Repositories/Repository.cs#L14 "Repository<TDbContext>.Repository(TDbContext context)") | 96 | 1 :heavy_check_mark: | 0 | 0 | 4 / 1 |
| Method | [19](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Repositories/Repository.cs#L19 "Task Repository<TDbContext>.CreateAsync<T>(T entity)") | 88 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Method | [25](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Repositories/Repository.cs#L25 "Task Repository<TDbContext>.DeleteAsync<T>(T entity)") | 88 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Method | [31](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Repositories/Repository.cs#L31 "Task<IEnumerable<T>> Repository<TDbContext>.SelectAllAsync<T>()") | 100 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | [36](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Repositories/Repository.cs#L36 "Task<T> Repository<TDbContext>.SelectByIdAsync<T>(long id)") | 95 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Method | [41](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Repositories/Repository.cs#L41 "Task Repository<TDbContext>.UpdateAsync<T>(T entity)") | 88 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |

<a href="#ir-shared-repositories">:top: back to IR.Shared.Repositories</a>

</details>

</details>

<details>
<summary>
  <strong id="ir-shared-services">
    IR.Shared.Services :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Shared.Services` namespace contains 3 named types.

- 3 named types.
- 444 total lines of source code.
- Approximately 111 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

<details>
<summary>
  <strong id="commentservice">
    CommentService :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentService` contains 11 members.
- 144 total lines of source code.
- Approximately 37 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [20](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/CommentService.cs#L20 "ILogger<CommentService> CommentService._logger") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | [19](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/CommentService.cs#L19 "IMapper CommentService._mapper") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | [18](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/CommentService.cs#L18 "IRepository CommentService._repository") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [28](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/CommentService.cs#L28 "CommentService.CommentService(IRepository repository, IMapper mapper, ILogger<CommentService> logger)") | 77 | 3 :heavy_check_mark: | 0 | 6 | 12 / 3 |
| Method | [135](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/CommentService.cs#L135 "Task<bool> CommentService.CommentExistsAsync(long id)") | 83 | 1 :heavy_check_mark: | 0 | 4 | 10 / 2 |
| Method | [63](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/CommentService.cs#L63 "Task<CommentDto> CommentService.CreateCommentAsync(NewCommentDto comment)") | 70 | 1 :heavy_check_mark: | 0 | 11 | 21 / 6 |
| Method | [110](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/CommentService.cs#L110 "Task<bool> CommentService.DeleteCommentAsync(CommentForDeleteDto comment)") | 67 | 1 :heavy_check_mark: | 0 | 10 | 24 / 8 |
| Method | [147](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/CommentService.cs#L147 "Task<Comment> CommentService.EnforceCommentExistenceAsync(long id)") | 71 | 2 :heavy_check_mark: | 0 | 8 | 18 / 5 |
| Method | [51](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/CommentService.cs#L51 "Task<CommentDto> CommentService.GetCommentByIdAsync(long id)") | 78 | 1 :heavy_check_mark: | 0 | 6 | 11 / 3 |
| Method | [39](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/CommentService.cs#L39 "Task<IEnumerable<CommentDto>> CommentService.GetCommentsAsync()") | 79 | 1 :heavy_check_mark: | 0 | 7 | 10 / 3 |
| Method | [86](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/CommentService.cs#L86 "Task<bool> CommentService.UpdateCommentAsync(long id, CommentForUpdateDto comment)") | 68 | 1 :heavy_check_mark: | 0 | 11 | 24 / 7 |

<a href="#ir-shared-services">:top: back to IR.Shared.Services</a>

</details>

<details>
<summary>
  <strong id="issueservice">
    IssueService :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueService` contains 11 members.
- 147 total lines of source code.
- Approximately 37 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [23](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/IssueService.cs#L23 "ILogger<IssueService> IssueService._logger") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | [22](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/IssueService.cs#L22 "IMapper IssueService._mapper") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | [21](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/IssueService.cs#L21 "IRepository IssueService._repository") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [31](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/IssueService.cs#L31 "IssueService.IssueService(IRepository repository, IMapper mapper, ILogger<IssueService> logger)") | 77 | 3 :heavy_check_mark: | 0 | 6 | 12 / 3 |
| Method | [66](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/IssueService.cs#L66 "Task<IssueDto> IssueService.CreateIssueAsync(NewIssueDto issue)") | 70 | 1 :heavy_check_mark: | 0 | 11 | 21 / 6 |
| Method | [113](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/IssueService.cs#L113 "Task<bool> IssueService.DeleteIssueAsync(IssueForDeleteDto issue)") | 67 | 1 :heavy_check_mark: | 0 | 10 | 24 / 8 |
| Method | [150](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/IssueService.cs#L150 "Task<Issue> IssueService.EnforceIssueExistenceAsync(long id)") | 71 | 2 :heavy_check_mark: | 0 | 8 | 18 / 5 |
| Method | [54](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/IssueService.cs#L54 "Task<IssueDto> IssueService.GetIssueByIdAsync(long id)") | 78 | 1 :heavy_check_mark: | 0 | 6 | 11 / 3 |
| Method | [42](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/IssueService.cs#L42 "Task<IEnumerable<IssueDto>> IssueService.GetIssuesAsync()") | 79 | 1 :heavy_check_mark: | 0 | 7 | 10 / 3 |
| Method | [138](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/IssueService.cs#L138 "Task<bool> IssueService.IssueExistsAsync(long id)") | 83 | 1 :heavy_check_mark: | 0 | 4 | 10 / 2 |
| Method | [89](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/IssueService.cs#L89 "Task<bool> IssueService.UpdateIssueAsync(long id, IssueForUpdateDto issue)") | 68 | 1 :heavy_check_mark: | 0 | 11 | 24 / 7 |

<a href="#ir-shared-services">:top: back to IR.Shared.Services</a>

</details>

<details>
<summary>
  <strong id="responseservice">
    ResponseService :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseService` contains 11 members.
- 144 total lines of source code.
- Approximately 37 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [20](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/ResponseService.cs#L20 "ILogger<ResponseService> ResponseService._logger") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | [19](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/ResponseService.cs#L19 "IMapper ResponseService._mapper") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | [18](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/ResponseService.cs#L18 "IRepository ResponseService._repository") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [28](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/ResponseService.cs#L28 "ResponseService.ResponseService(IRepository repository, IMapper mapper, ILogger<ResponseService> logger)") | 77 | 3 :heavy_check_mark: | 0 | 6 | 12 / 3 |
| Method | [63](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/ResponseService.cs#L63 "Task<ResponseDto> ResponseService.CreateResponseAsync(NewResponseDto response)") | 70 | 1 :heavy_check_mark: | 0 | 11 | 21 / 6 |
| Method | [110](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/ResponseService.cs#L110 "Task<bool> ResponseService.DeleteResponseAsync(ResponseForDeleteDto response)") | 67 | 1 :heavy_check_mark: | 0 | 10 | 24 / 8 |
| Method | [147](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/ResponseService.cs#L147 "Task<Response> ResponseService.EnforceResponseExistenceAsync(long id)") | 71 | 2 :heavy_check_mark: | 0 | 8 | 18 / 5 |
| Method | [51](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/ResponseService.cs#L51 "Task<ResponseDto> ResponseService.GetResponseByIdAsync(long id)") | 78 | 1 :heavy_check_mark: | 0 | 6 | 11 / 3 |
| Method | [39](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/ResponseService.cs#L39 "Task<IEnumerable<ResponseDto>> ResponseService.GetResponsesAsync()") | 79 | 1 :heavy_check_mark: | 0 | 7 | 10 / 3 |
| Method | [135](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/ResponseService.cs#L135 "Task<bool> ResponseService.ResponseExistsAsync(long id)") | 83 | 1 :heavy_check_mark: | 0 | 4 | 10 / 2 |
| Method | [86](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Shared/Services/ResponseService.cs#L86 "Task<bool> ResponseService.UpdateResponseAsync(long id, ResponseForUpdateDto response)") | 68 | 1 :heavy_check_mark: | 0 | 11 | 24 / 7 |

<a href="#ir-shared-services">:top: back to IR.Shared.Services</a>

</details>

</details>

<a href="#ir-shared">:top: back to IR.Shared</a>

<div id='ir-server-unit-tests'></div>

## IR.Server.Unit.Tests :heavy_check_mark:

The *IR.Server.Unit.Tests.csproj* project file contains:

- 1 namespaces.
- 18 named types.
- 1,560 total lines of source code.
- Approximately 558 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="ir-server-unit-tests-controllers">
    IR.Server.Unit.Tests.Controllers :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Server.Unit.Tests.Controllers` namespace contains 18 named types.

- 18 named types.
- 1,560 total lines of source code.
- Approximately 558 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="commentcontrollerunittests">
    CommentControllerUnitTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentControllerUnitTests` contains 4 members.
- 517 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [29](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L29 "CommentControllerUnitTests.CommentControllerUnitTests()") | 80 | 1 :heavy_check_mark: | 0 | 5 | 8 / 3 |
| Property | [25](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L25 "Mock<ICommentService> CommentControllerUnitTests.CommentServiceMock") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Property | [23](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L23 "CommentController CommentControllerUnitTests.ControllerUnderTest") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [27](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L27 "Mock<ILogger<CommentController>> CommentControllerUnitTests.LoggerMock") | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 0 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="commentcontrollerunittests-createcommentasync">
    CommentControllerUnitTests.CreateCommentAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentControllerUnitTests.CreateCommentAsync` contains 4 members.
- 107 total lines of source code.
- Approximately 46 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [188](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L188 "Task CreateCommentAsync.CreateCommentAsync_Should_Return_CreatedAtActionResult_With_The_created_Comment_Test()") | 63 | 1 :heavy_check_mark: | 0 | 8 | 25 / 10 |
| Method | [265](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L265 "Task CreateCommentAsync.CreateCommentAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 10 | 27 / 12 |
| Method | [238](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L238 "Task CreateCommentAsync.CreateCommentAsync_With_Invalid_Data_Should_Return_Model_Errors_TestAsync(string commentText, string initiatorId, string initiatorName, string expectedLog, string expectedValidationError, string expectedValidationField)") | 54 | 1 :heavy_check_mark: | 0 | 9 | 32 / 19 |
| Method | [214](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L214 "Task CreateCommentAsync.CreateCommentAsync_With_Null_CommentForCreationDto_Should_Return_BadRequest_Test()") | 72 | 1 :heavy_check_mark: | 0 | 6 | 17 / 5 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="issuecontrollerunittests-createissueasync">
    IssueControllerUnitTests.CreateIssueAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueControllerUnitTests.CreateIssueAsync` contains 4 members.
- 107 total lines of source code.
- Approximately 46 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [192](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L192 "Task CreateIssueAsync.CreateIssueAsync_Should_Return_CreatedAtActionResult_With_The_created_Issue_Test()") | 63 | 1 :heavy_check_mark: | 0 | 8 | 25 / 10 |
| Method | [269](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L269 "Task CreateIssueAsync.CreateIssueAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 10 | 27 / 12 |
| Method | [242](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L242 "Task CreateIssueAsync.CreateIssueAsync_With_Invalid_Data_Should_Return_Model_Errors_TestAsync(string issueDescription, string initiatorId, string initiatorName, string expectedLog, string expectedValidationError, string expectedValidationField)") | 54 | 1 :heavy_check_mark: | 0 | 9 | 32 / 19 |
| Method | [218](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L218 "Task CreateIssueAsync.CreateIssueAsync_With_Null_IssueForCreationDto_Should_Return_BadRequest_Test()") | 72 | 1 :heavy_check_mark: | 0 | 6 | 17 / 5 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="responsecontrollerunittests-createresponseasync">
    ResponseControllerUnitTests.CreateResponseAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseControllerUnitTests.CreateResponseAsync` contains 4 members.
- 107 total lines of source code.
- Approximately 46 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [192](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L192 "Task CreateResponseAsync.CreateResponseAsync_Should_Return_CreatedAtActionResult_With_The_created_Response_Test()") | 63 | 1 :heavy_check_mark: | 0 | 8 | 25 / 10 |
| Method | [269](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L269 "Task CreateResponseAsync.CreateResponseAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 10 | 27 / 12 |
| Method | [242](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L242 "Task CreateResponseAsync.CreateResponseAsync_With_Invalid_Data_Should_Return_Model_Errors_TestAsync(string responseText, string initiatorId, string initiatorName, string expectedLog, string expectedValidationError, string expectedValidationField)") | 54 | 1 :heavy_check_mark: | 0 | 9 | 32 / 19 |
| Method | [218](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L218 "Task CreateResponseAsync.CreateResponseAsync_With_Null_ResponseForCreationDto_Should_Return_BadRequest_Test()") | 72 | 1 :heavy_check_mark: | 0 | 6 | 17 / 5 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="commentcontrollerunittests-deletecommentasync">
    CommentControllerUnitTests.DeleteCommentAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentControllerUnitTests.DeleteCommentAsync` contains 4 members.
- 92 total lines of source code.
- Approximately 28 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [486](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L486 "Task DeleteCommentAsync.DeleteCommentAsync_Should_return_NotFoundResult_when_CommentNotFoundException_is_thrown_Test()") | 70 | 1 :heavy_check_mark: | 0 | 9 | 21 / 6 |
| Method | [508](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L508 "Task DeleteCommentAsync.DeleteCommentAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 10 | 29 / 12 |
| Method | [468](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L468 "Task DeleteCommentAsync.DeleteCommentAsync_With_Null_CommentForCreationDto_Should_Return_BadRequest_Test()") | 72 | 1 :heavy_check_mark: | 0 | 6 | 17 / 5 |
| Method | [448](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L448 "Task DeleteCommentAsync.DeleteCommentAsync_With_Valid_Id_Should_return_NoContentResult_on_successful_delete_Test()") | 73 | 1 :heavy_check_mark: | 0 | 7 | 19 / 5 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="issuecontrollerunittests-deleteissueasync">
    IssueControllerUnitTests.DeleteIssueAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueControllerUnitTests.DeleteIssueAsync` contains 4 members.
- 92 total lines of source code.
- Approximately 28 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [490](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L490 "Task DeleteIssueAsync.DeleteIssueAsync_Should_return_NotFoundResult_when_IssueNotFoundException_is_thrown_Test()") | 70 | 1 :heavy_check_mark: | 0 | 9 | 21 / 6 |
| Method | [512](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L512 "Task DeleteIssueAsync.DeleteIssueAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 10 | 29 / 12 |
| Method | [472](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L472 "Task DeleteIssueAsync.DeleteIssueAsync_With_Null_IssueForCreationDto_Should_Return_BadRequest_Test()") | 72 | 1 :heavy_check_mark: | 0 | 6 | 17 / 5 |
| Method | [452](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L452 "Task DeleteIssueAsync.DeleteIssueAsync_With_Valid_Id_Should_return_NoContentResult_on_successful_delete_Test()") | 73 | 1 :heavy_check_mark: | 0 | 7 | 19 / 5 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="responsecontrollerunittests-deleteresponseasync">
    ResponseControllerUnitTests.DeleteResponseAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseControllerUnitTests.DeleteResponseAsync` contains 4 members.
- 92 total lines of source code.
- Approximately 28 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [490](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L490 "Task DeleteResponseAsync.DeleteResponseAsync_Should_return_NotFoundResult_when_ResponseNotFoundException_is_thrown_Test()") | 70 | 1 :heavy_check_mark: | 0 | 9 | 21 / 6 |
| Method | [512](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L512 "Task DeleteResponseAsync.DeleteResponseAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 10 | 29 / 12 |
| Method | [472](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L472 "Task DeleteResponseAsync.DeleteResponseAsync_With_Null_ResponseForCreationDto_Should_Return_BadRequest_Test()") | 72 | 1 :heavy_check_mark: | 0 | 6 | 17 / 5 |
| Method | [452](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L452 "Task DeleteResponseAsync.DeleteResponseAsync_With_Valid_Id_Should_return_NoContentResult_on_successful_delete_Test()") | 73 | 1 :heavy_check_mark: | 0 | 7 | 19 / 5 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="commentcontrollerunittests-getcommentbyidasync">
    CommentControllerUnitTests.GetCommentByIdAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentControllerUnitTests.GetCommentByIdAsync` contains 3 members.
- 79 total lines of source code.
- Approximately 27 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [108](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L108 "Task GetCommentByIdAsync.GetCommentByIdAsync_With_A_Valid_Id_Should_Return_OkObjectResult_with_a_Comment_Test()") | 63 | 1 :heavy_check_mark: | 0 | 9 | 28 / 10 |
| Method | [157](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L157 "Task GetCommentByIdAsync.GetCommentByIdAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 9 | 27 / 12 |
| Method | [137](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L137 "Task GetCommentByIdAsync.GetCommentByIdAsync_With_An_InValid_Id_Should_Return_NotFoundResult_when_CommentNotFoundException_is_thrown_Test()") | 73 | 1 :heavy_check_mark: | 0 | 8 | 19 / 5 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="commentcontrollerunittests-getcommentsasync">
    CommentControllerUnitTests.GetCommentsAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentControllerUnitTests.GetCommentsAsync` contains 2 members.
- 66 total lines of source code.
- Approximately 23 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [41](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L41 "Task GetCommentsAsync.GetCommentsAsync_Should_Return_All_Comments_TestAsync()") | 60 | 1 :heavy_check_mark: | 0 | 11 | 33 / 11 |
| Method | [75](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L75 "Task GetCommentsAsync.GetCommentsAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 9 | 29 / 12 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="issuecontrollerunittests-getissuebyidasync">
    IssueControllerUnitTests.GetIssueByIdAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueControllerUnitTests.GetIssueByIdAsync` contains 3 members.
- 79 total lines of source code.
- Approximately 27 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [112](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L112 "Task GetIssueByIdAsync.GetIssueByIdAsync_With_A_Valid_Id_Should_Return_OkObjectResult_with_a_Issue_Test()") | 62 | 1 :heavy_check_mark: | 0 | 9 | 28 / 10 |
| Method | [161](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L161 "Task GetIssueByIdAsync.GetIssueByIdAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 9 | 27 / 12 |
| Method | [141](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L141 "Task GetIssueByIdAsync.GetIssueByIdAsync_With_An_InValid_Id_Should_Return_NotFoundResult_when_IssueNotFoundException_is_thrown_Test()") | 73 | 1 :heavy_check_mark: | 0 | 8 | 19 / 5 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="issuecontrollerunittests-getissuesasync">
    IssueControllerUnitTests.GetIssuesAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueControllerUnitTests.GetIssuesAsync` contains 2 members.
- 66 total lines of source code.
- Approximately 23 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [45](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L45 "Task GetIssuesAsync.GetIssuesAsync_Should_Return_All_Issues_TestAsync()") | 60 | 1 :heavy_check_mark: | 0 | 10 | 33 / 11 |
| Method | [79](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L79 "Task GetIssuesAsync.GetIssuesAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 9 | 29 / 12 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="responsecontrollerunittests-getresponsebyidasync">
    ResponseControllerUnitTests.GetResponseByIdAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseControllerUnitTests.GetResponseByIdAsync` contains 3 members.
- 79 total lines of source code.
- Approximately 27 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [112](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L112 "Task GetResponseByIdAsync.GetResponseByIdAsync_With_A_Valid_Id_Should_Return_OkObjectResult_with_a_Response_Test()") | 63 | 1 :heavy_check_mark: | 0 | 10 | 28 / 10 |
| Method | [161](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L161 "Task GetResponseByIdAsync.GetResponseByIdAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 9 | 27 / 12 |
| Method | [141](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L141 "Task GetResponseByIdAsync.GetResponseByIdAsync_With_An_InValid_Id_Should_Return_NotFoundResult_when_ResponseNotFoundException_is_thrown_Test()") | 73 | 1 :heavy_check_mark: | 0 | 8 | 19 / 5 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="responsecontrollerunittests-getresponsesasync">
    ResponseControllerUnitTests.GetResponsesAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseControllerUnitTests.GetResponsesAsync` contains 2 members.
- 66 total lines of source code.
- Approximately 23 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [45](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L45 "Task GetResponsesAsync.GetResponsesAsync_Should_Return_All_Responses_TestAsync()") | 60 | 1 :heavy_check_mark: | 0 | 11 | 33 / 11 |
| Method | [79](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L79 "Task GetResponsesAsync.GetResponsesAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 9 | 29 / 12 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="issuecontrollerunittests">
    IssueControllerUnitTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueControllerUnitTests` contains 4 members.
- 517 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [33](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L33 "IssueControllerUnitTests.IssueControllerUnitTests()") | 80 | 1 :heavy_check_mark: | 0 | 5 | 8 / 3 |
| Property | [27](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L27 "IssueController IssueControllerUnitTests.ControllerUnderTest") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [29](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L29 "Mock<IIssueService> IssueControllerUnitTests.IssueServiceMock") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Property | [31](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L31 "Mock<ILogger<IssueController>> IssueControllerUnitTests.LoggerMock") | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 0 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="responsecontrollerunittests">
    ResponseControllerUnitTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseControllerUnitTests` contains 4 members.
- 517 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [33](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L33 "ResponseControllerUnitTests.ResponseControllerUnitTests()") | 80 | 1 :heavy_check_mark: | 0 | 5 | 8 / 3 |
| Property | [27](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L27 "ResponseController ResponseControllerUnitTests.ControllerUnderTest") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [31](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L31 "Mock<ILogger<ResponseController>> ResponseControllerUnitTests.LoggerMock") | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Property | [29](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L29 "Mock<IResponseService> ResponseControllerUnitTests.ResponseServiceMock") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="commentcontrollerunittests-updatecommentasync">
    CommentControllerUnitTests.UpdateCommentAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentControllerUnitTests.UpdateCommentAsync` contains 6 members.
- 151 total lines of source code.
- Approximately 59 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [389](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L389 "Task UpdateCommentAsync.CreateCommentAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 10 | 27 / 12 |
| Method | [362](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L362 "Task UpdateCommentAsync.CreateCommentAsync_With_Invalid_Data_Should_Return_Model_Errors_TestAsync(string commentText, string commenterId, string commenterName, string expectedLog, string expectedValidationError, string expectedValidationField)") | 54 | 1 :heavy_check_mark: | 0 | 9 | 32 / 19 |
| Method | [296](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L296 "Task UpdateCommentAsync.UpdateCommentAsync_Should_return_NoContentResult_Test()") | 71 | 1 :heavy_check_mark: | 0 | 7 | 19 / 5 |
| Method | [334](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L334 "Task UpdateCommentAsync.UpdateCommentAsync_Should_return_NotFoundResult_when_CommentNotFoundException_is_thrown()") | 69 | 1 :heavy_check_mark: | 0 | 9 | 21 / 6 |
| Method | [417](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L417 "Task UpdateCommentAsync.UpdateCommentAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 60 | 1 :heavy_check_mark: | 0 | 10 | 27 / 12 |
| Method | [316](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/CommentControllerUnitTests.cs#L316 "Task UpdateCommentAsync.UpdateCommentAsync_With_Null_CommentForCreationDto_Should_Return_BadRequest_Test()") | 72 | 1 :heavy_check_mark: | 0 | 6 | 17 / 5 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="issuecontrollerunittests-updateissueasync">
    IssueControllerUnitTests.UpdateIssueAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueControllerUnitTests.UpdateIssueAsync` contains 6 members.
- 151 total lines of source code.
- Approximately 59 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [393](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L393 "Task UpdateIssueAsync.CreateIssueAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 10 | 27 / 12 |
| Method | [366](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L366 "Task UpdateIssueAsync.CreateIssueAsync_With_Invalid_Data_Should_Return_Model_Errors_TestAsync(string issueDescription, string initiatorId, string initiatorName, string expectedLog, string expectedValidationError, string expectedValidationField)") | 54 | 1 :heavy_check_mark: | 0 | 9 | 32 / 19 |
| Method | [300](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L300 "Task UpdateIssueAsync.UpdateIssueAsync_Should_return_NoContentResult_Test()") | 70 | 1 :heavy_check_mark: | 0 | 7 | 19 / 5 |
| Method | [338](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L338 "Task UpdateIssueAsync.UpdateIssueAsync_Should_return_NotFoundResult_when_IssueNotFoundException_is_thrown()") | 68 | 1 :heavy_check_mark: | 0 | 9 | 21 / 6 |
| Method | [421](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L421 "Task UpdateIssueAsync.UpdateIssueAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 60 | 1 :heavy_check_mark: | 0 | 10 | 27 / 12 |
| Method | [320](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/IssueControllerUnitTests.cs#L320 "Task UpdateIssueAsync.UpdateIssueAsync_With_Null_IssueForCreationDto_Should_Return_BadRequest_Test()") | 72 | 1 :heavy_check_mark: | 0 | 6 | 17 / 5 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

<details>
<summary>
  <strong id="responsecontrollerunittests-updateresponseasync">
    ResponseControllerUnitTests.UpdateResponseAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseControllerUnitTests.UpdateResponseAsync` contains 6 members.
- 151 total lines of source code.
- Approximately 59 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [393](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L393 "Task UpdateResponseAsync.CreateResponseAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 61 | 1 :heavy_check_mark: | 0 | 10 | 27 / 12 |
| Method | [366](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L366 "Task UpdateResponseAsync.CreateResponseAsync_With_Invalid_Data_Should_Return_Model_Errors_TestAsync(string responseText, string responseerId, string responseerName, string expectedLog, string expectedValidationError, string expectedValidationField)") | 54 | 1 :heavy_check_mark: | 0 | 9 | 32 / 19 |
| Method | [300](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L300 "Task UpdateResponseAsync.UpdateResponseAsync_Should_return_NoContentResult_Test()") | 71 | 1 :heavy_check_mark: | 0 | 7 | 19 / 5 |
| Method | [338](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L338 "Task UpdateResponseAsync.UpdateResponseAsync_Should_return_NotFoundResult_when_ResponseNotFoundException_is_thrown()") | 69 | 1 :heavy_check_mark: | 0 | 9 | 21 / 6 |
| Method | [421](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L421 "Task UpdateResponseAsync.UpdateResponseAsync_With_An_Exception_Should_Return_StatusCode_500_Test()") | 60 | 1 :heavy_check_mark: | 0 | 10 | 27 / 12 |
| Method | [320](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Server.Unit.Tests/Controllers/ResponseControllerUnitTests.cs#L320 "Task UpdateResponseAsync.UpdateResponseAsync_With_Null_ResponseForCreationDto_Should_Return_BadRequest_Test()") | 72 | 1 :heavy_check_mark: | 0 | 6 | 17 / 5 |

<a href="#ir-server-unit-tests-controllers">:top: back to IR.Server.Unit.Tests.Controllers</a>

</details>

</details>

<a href="#ir-server-unit-tests">:top: back to IR.Server.Unit.Tests</a>

<div id='ir-shared-unit-tests'></div>

## IR.Shared.Unit.Tests :heavy_check_mark:

The *IR.Shared.Unit.Tests.csproj* project file contains:

- 2 namespaces.
- 30 named types.
- 1,528 total lines of source code.
- Approximately 483 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="ir-shared-unit-tests-repositories">
    IR.Shared.Unit.Tests.Repositories :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Shared.Unit.Tests.Repositories` namespace contains 6 named types.

- 6 named types.
- 226 total lines of source code.
- Approximately 66 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="repositoryunittests-createasync">
    RepositoryUnitTests.CreateAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `RepositoryUnitTests.CreateAsync` contains 1 members.
- 32 total lines of source code.
- Approximately 10 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [132](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Repositories/RepositoryUnitTests.cs#L132 "Task CreateAsync.CreateAsync_Should_Set_the_Id_to_next_available_TestAsync()") | 64 | 1 :heavy_check_mark: | 0 | 8 | 29 / 10 |

<a href="#ir-shared-unit-tests-repositories">:top: back to IR.Shared.Unit.Tests.Repositories</a>

</details>

<details>
<summary>
  <strong id="repositoryunittests-deleteasync">
    RepositoryUnitTests.DeleteAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `RepositoryUnitTests.DeleteAsync` contains 1 members.
- 37 total lines of source code.
- Approximately 11 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [207](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Repositories/RepositoryUnitTests.cs#L207 "Task DeleteAsync.DeleteAsync_Should_Set_the_Entity_State_as_Deleted_Test()") | 62 | 1 :heavy_check_mark: | 0 | 8 | 34 / 11 |

<a href="#ir-shared-unit-tests-repositories">:top: back to IR.Shared.Unit.Tests.Repositories</a>

</details>

<details>
<summary>
  <strong id="repositoryunittests">
    RepositoryUnitTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `RepositoryUnitTests` contains 3 members.
- 223 total lines of source code.
- Approximately 1 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [25](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Repositories/RepositoryUnitTests.cs#L25 "RepositoryUnitTests.RepositoryUnitTests()") | 88 | 1 :heavy_check_mark: | 0 | 3 | 9 / 1 |
| Property | [23](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Repositories/RepositoryUnitTests.cs#L23 "List<Issue> RepositoryUnitTests.IssueList") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Property | [21](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Repositories/RepositoryUnitTests.cs#L21 "IRepository RepositoryUnitTests.RepositoryUnderTest") | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#ir-shared-unit-tests-repositories">:top: back to IR.Shared.Unit.Tests.Repositories</a>

</details>

<details>
<summary>
  <strong id="repositoryunittests-selectallasync">
    RepositoryUnitTests.SelectAllAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `RepositoryUnitTests.SelectAllAsync` contains 1 members.
- 33 total lines of source code.
- Approximately 12 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [38](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Repositories/RepositoryUnitTests.cs#L38 "Task SelectAllAsync.SelectAllAsync_Should_return_all_issues_TestAsync()") | 61 | 1 :heavy_check_mark: | 0 | 8 | 30 / 12 |

<a href="#ir-shared-unit-tests-repositories">:top: back to IR.Shared.Unit.Tests.Repositories</a>

</details>

<details>
<summary>
  <strong id="repositoryunittests-selectbyidasync">
    RepositoryUnitTests.SelectByIdAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `RepositoryUnitTests.SelectByIdAsync` contains 2 members.
- 59 total lines of source code.
- Approximately 18 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [101](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Repositories/RepositoryUnitTests.cs#L101 "Task SelectByIdAsync.SelectByIdAsync_Should_return_null_if_the_issue_does_not_exist_TestAsync()") | 65 | 1 :heavy_check_mark: | 0 | 8 | 27 / 9 |
| Method | [72](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Repositories/RepositoryUnitTests.cs#L72 "Task SelectByIdAsync.SelectByIdAsync_Should_return_the_expected_Issue_TestAsync()") | 65 | 1 :heavy_check_mark: | 0 | 8 | 28 / 9 |

<a href="#ir-shared-unit-tests-repositories">:top: back to IR.Shared.Unit.Tests.Repositories</a>

</details>

<details>
<summary>
  <strong id="repositoryunittests-updateasync">
    RepositoryUnitTests.UpdateAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `RepositoryUnitTests.UpdateAsync` contains 1 members.
- 41 total lines of source code.
- Approximately 14 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [165](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Repositories/RepositoryUnitTests.cs#L165 "Task UpdateAsync.UpdateAsync_Should_Set_the_Entity_State_as_Modified_Test()") | 59 | 1 :heavy_check_mark: | 0 | 8 | 38 / 14 |

<a href="#ir-shared-unit-tests-repositories">:top: back to IR.Shared.Unit.Tests.Repositories</a>

</details>

</details>

<details>
<summary>
  <strong id="ir-shared-unit-tests-services">
    IR.Shared.Unit.Tests.Services :heavy_check_mark:
  </strong>
</summary>
<br>

The `IR.Shared.Unit.Tests.Services` namespace contains 24 named types.

- 24 named types.
- 1,302 total lines of source code.
- Approximately 417 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="commentserviceunittests-commentexitsasync">
    CommentServiceUnitTests.CommentExitsAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentServiceUnitTests.CommentExitsAsync` contains 2 members.
- 42 total lines of source code.
- Approximately 10 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [177](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L177 "Task CommentExitsAsync.CommentExistsAsync_Should_Return_False_If_The_Comment_Does_Not_Exist_Test()") | 74 | 1 :heavy_check_mark: | 0 | 7 | 19 / 5 |
| Method | [157](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L157 "Task CommentExitsAsync.CommentExistsAsync_Should_Return_True_If_The_Comment_Exists_Test()") | 74 | 1 :heavy_check_mark: | 0 | 7 | 19 / 5 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="commentserviceunittests">
    CommentServiceUnitTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentServiceUnitTests` contains 7 members.
- 431 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [32](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L32 "CommentServiceUnitTests.CommentServiceUnitTests()") | 67 | 1 :heavy_check_mark: | 0 | 9 | 53 / 6 |
| Property | [29](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L29 "CommentDto[] CommentServiceUnitTests.CommentDtos") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [27](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L27 "Comment[] CommentServiceUnitTests.Comments") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [30](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L30 "CommentForDeleteDto CommentServiceUnitTests.CommentToDeleteDto") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [28](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L28 "Mock<ILogger<CommentService>> CommentServiceUnitTests.LoggerMock") | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Property | [26](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L26 "Mock<IRepository> CommentServiceUnitTests.RepositoryMock") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Property | [25](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L25 "ICommentService CommentServiceUnitTests.ServiceUnderTest") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="commentserviceunittests-createcommentasync">
    CommentServiceUnitTests.CreateCommentAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentServiceUnitTests.CreateCommentAsync` contains 2 members.
- 51 total lines of source code.
- Approximately 22 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [273](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L273 "Task CreateCommentAsync.CreateCommentAsync_Should_create_and_return_the_specified_Comment_Test()") | 65 | 1 :heavy_check_mark: | 0 | 8 | 22 / 10 |
| Method | [247](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L247 "Task CreateCommentAsync.CreateCommentAsync_Where_Create_Fails_Should__return_a_CommentNotCreatedException_Test()") | 61 | 1 :heavy_check_mark: | 0 | 11 | 25 / 12 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="issueserviceunittests-createissueasync">
    IssueServiceUnitTests.CreateIssueAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueServiceUnitTests.CreateIssueAsync` contains 2 members.
- 51 total lines of source code.
- Approximately 22 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [273](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L273 "Task CreateIssueAsync.CreateIssueAsync_Should_create_and_return_the_specified_Issue_Test()") | 65 | 1 :heavy_check_mark: | 0 | 8 | 22 / 10 |
| Method | [247](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L247 "Task CreateIssueAsync.CreateIssueAsync_Where_Create_Fails_Should__return_a_IssueNotCreatedException_Test()") | 61 | 1 :heavy_check_mark: | 0 | 11 | 25 / 12 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="responseserviceunittests-createresponseasync">
    ResponseServiceUnitTests.CreateResponseAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseServiceUnitTests.CreateResponseAsync` contains 2 members.
- 51 total lines of source code.
- Approximately 22 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [273](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L273 "Task CreateResponseAsync.CreateResponseAsync_Should_create_and_return_the_specified_Response_Test()") | 65 | 1 :heavy_check_mark: | 0 | 8 | 22 / 10 |
| Method | [247](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L247 "Task CreateResponseAsync.CreateResponseAsync_Where_Create_Fails_Should__return_a_ResponseNotCreatedException_Test()") | 61 | 1 :heavy_check_mark: | 0 | 11 | 25 / 12 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="commentserviceunittests-deletecommentasync">
    CommentServiceUnitTests.DeleteCommentAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentServiceUnitTests.DeleteCommentAsync` contains 3 members.
- 73 total lines of source code.
- Approximately 30 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [429](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L429 "Task DeleteCommentAsync.DeleteCommentAsync_Should_Update_and_return_the_specified_Comment_Test()") | 62 | 1 :heavy_check_mark: | 0 | 8 | 24 / 12 |
| Method | [402](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L402 "Task DeleteCommentAsync.DeleteCommentAsync_Where_Delete_Fails_Should__return_a_CommentNotCreatedException_Test()") | 62 | 1 :heavy_check_mark: | 0 | 11 | 26 / 12 |
| Method | [383](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L383 "Task DeleteCommentAsync.DeleteCommentAsync_With_A_NonExisting_Comment_Should_Return_CommentNotFoundException_Test()") | 72 | 1 :heavy_check_mark: | 0 | 8 | 18 / 6 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="issueserviceunittests-deleteissueasync">
    IssueServiceUnitTests.DeleteIssueAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueServiceUnitTests.DeleteIssueAsync` contains 3 members.
- 73 total lines of source code.
- Approximately 30 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [429](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L429 "Task DeleteIssueAsync.DeleteIssueAsync_Should_Update_and_return_the_specified_Issue_Test()") | 62 | 1 :heavy_check_mark: | 0 | 8 | 24 / 12 |
| Method | [402](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L402 "Task DeleteIssueAsync.DeleteIssueAsync_Where_Delete_Fails_Should__return_a_IssueNotCreatedException_Test()") | 62 | 1 :heavy_check_mark: | 0 | 11 | 26 / 12 |
| Method | [383](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L383 "Task DeleteIssueAsync.DeleteIssueAsync_With_A_NonExisting_Issue_Should_Return_IssueNotFoundException_Test()") | 72 | 1 :heavy_check_mark: | 0 | 8 | 18 / 6 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="responseserviceunittests-deleteresponseasync">
    ResponseServiceUnitTests.DeleteResponseAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseServiceUnitTests.DeleteResponseAsync` contains 3 members.
- 73 total lines of source code.
- Approximately 30 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [429](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L429 "Task DeleteResponseAsync.DeleteResponseAsync_Should_Update_and_return_the_specified_Response_Test()") | 62 | 1 :heavy_check_mark: | 0 | 8 | 24 / 12 |
| Method | [402](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L402 "Task DeleteResponseAsync.DeleteResponseAsync_Where_Delete_Fails_Should__return_a_ResponseNotCreatedException_Test()") | 62 | 1 :heavy_check_mark: | 0 | 11 | 26 / 12 |
| Method | [383](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L383 "Task DeleteResponseAsync.DeleteResponseAsync_With_A_NonExisting_Response_Should_Return_ResponseNotFoundException_Test()") | 72 | 1 :heavy_check_mark: | 0 | 8 | 18 / 6 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="commentserviceunittests-enforcecommentexistenceasync">
    CommentServiceUnitTests.EnforceCommentExistenceAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentServiceUnitTests.EnforceCommentExistenceAsync` contains 2 members.
- 46 total lines of source code.
- Approximately 14 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [200](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L200 "Task EnforceCommentExistenceAsync.EnforceUserExistenceAsync_Should_Return_User_If_The_User_Exists_Test()") | 68 | 1 :heavy_check_mark: | 0 | 7 | 21 / 7 |
| Method | [222](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L222 "Task EnforceCommentExistenceAsync.EnforceUserExistenceAsync_Should_Return_UserNotFoundException_If_The_User_Does_Not_Exist_Test()") | 70 | 1 :heavy_check_mark: | 0 | 7 | 21 / 7 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="issueserviceunittests-enforceissueexistenceasync">
    IssueServiceUnitTests.EnforceIssueExistenceAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueServiceUnitTests.EnforceIssueExistenceAsync` contains 2 members.
- 46 total lines of source code.
- Approximately 14 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [200](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L200 "Task EnforceIssueExistenceAsync.EnforceUserExistenceAsync_Should_Return_User_If_The_User_Exists_Test()") | 68 | 1 :heavy_check_mark: | 0 | 7 | 21 / 7 |
| Method | [222](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L222 "Task EnforceIssueExistenceAsync.EnforceUserExistenceAsync_Should_Return_UserNotFoundException_If_The_User_Does_Not_Exist_Test()") | 70 | 1 :heavy_check_mark: | 0 | 7 | 21 / 7 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="responseserviceunittests-enforceresponseexistenceasync">
    ResponseServiceUnitTests.EnforceResponseExistenceAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseServiceUnitTests.EnforceResponseExistenceAsync` contains 2 members.
- 46 total lines of source code.
- Approximately 14 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [200](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L200 "Task EnforceResponseExistenceAsync.EnforceUserExistenceAsync_Should_Return_User_If_The_User_Exists_Test()") | 68 | 1 :heavy_check_mark: | 0 | 7 | 21 / 7 |
| Method | [222](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L222 "Task EnforceResponseExistenceAsync.EnforceUserExistenceAsync_Should_Return_UserNotFoundException_If_The_User_Does_Not_Exist_Test()") | 70 | 1 :heavy_check_mark: | 0 | 7 | 21 / 7 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="commentserviceunittests-getallcommentsasync">
    CommentServiceUnitTests.GetAllCommentsAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentServiceUnitTests.GetAllCommentsAsync` contains 1 members.
- 25 total lines of source code.
- Approximately 9 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [89](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L89 "Task GetAllCommentsAsync.GetAllCommentsAsync_Should_Return_All_Comments_Test()") | 64 | 1 :heavy_check_mark: | 0 | 7 | 22 / 9 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="issueserviceunittests-getallissuesasync">
    IssueServiceUnitTests.GetAllIssuesAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueServiceUnitTests.GetAllIssuesAsync` contains 1 members.
- 25 total lines of source code.
- Approximately 9 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [89](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L89 "Task GetAllIssuesAsync.GetAllIssuesAsync_Should_Return_All_Issues_Test()") | 64 | 1 :heavy_check_mark: | 0 | 7 | 22 / 9 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="responseserviceunittests-getallresponsesasync">
    ResponseServiceUnitTests.GetAllResponsesAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseServiceUnitTests.GetAllResponsesAsync` contains 1 members.
- 25 total lines of source code.
- Approximately 9 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [89](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L89 "Task GetAllResponsesAsync.GetAllResponsesAsync_Should_Return_All_Responses_Test()") | 64 | 1 :heavy_check_mark: | 0 | 7 | 22 / 9 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="commentserviceunittests-getcommentbyidasync">
    CommentServiceUnitTests.GetCommentByIdAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentServiceUnitTests.GetCommentByIdAsync` contains 2 members.
- 41 total lines of source code.
- Approximately 13 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [138](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L138 "Task GetCommentByIdAsync.GetCommentByIdAsync_With_Invalid_Id_Should_Return_Null_If_The_Comment_Does_Not_Exist_Test()") | 75 | 1 :heavy_check_mark: | 0 | 7 | 15 / 5 |
| Method | [115](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L115 "Task GetCommentByIdAsync.GetCommentByIdAsync_With_Valid_Id_Should_Return_The_Expected_Comment_Test()") | 67 | 1 :heavy_check_mark: | 0 | 7 | 22 / 8 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="issueserviceunittests-getissuebyidasync">
    IssueServiceUnitTests.GetIssueByIdAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueServiceUnitTests.GetIssueByIdAsync` contains 2 members.
- 41 total lines of source code.
- Approximately 13 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [138](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L138 "Task GetIssueByIdAsync.GetIssueByIdAsync_With_Invalid_Id_Should_Return_Null_If_The_Issue_Does_Not_Exist_Test()") | 75 | 1 :heavy_check_mark: | 0 | 7 | 15 / 5 |
| Method | [115](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L115 "Task GetIssueByIdAsync.GetIssueByIdAsync_With_Valid_Id_Should_Return_The_Expected_Issue_Test()") | 67 | 1 :heavy_check_mark: | 0 | 7 | 22 / 8 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="responseserviceunittests-getresponsebyidasync">
    ResponseServiceUnitTests.GetResponseByIdAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseServiceUnitTests.GetResponseByIdAsync` contains 2 members.
- 41 total lines of source code.
- Approximately 13 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [138](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L138 "Task GetResponseByIdAsync.GetResponseByIdAsync_With_Invalid_Id_Should_Return_Null_If_The_Response_Does_Not_Exist_Test()") | 75 | 1 :heavy_check_mark: | 0 | 7 | 15 / 5 |
| Method | [115](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L115 "Task GetResponseByIdAsync.GetResponseByIdAsync_With_Valid_Id_Should_Return_The_Expected_Response_Test()") | 67 | 1 :heavy_check_mark: | 0 | 7 | 22 / 8 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="issueserviceunittests-issueexitsasync">
    IssueServiceUnitTests.IssueExitsAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueServiceUnitTests.IssueExitsAsync` contains 2 members.
- 42 total lines of source code.
- Approximately 10 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [177](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L177 "Task IssueExitsAsync.IssueExistsAsync_Should_Return_False_If_The_Issue_Does_Not_Exist_Test()") | 74 | 1 :heavy_check_mark: | 0 | 7 | 19 / 5 |
| Method | [157](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L157 "Task IssueExitsAsync.IssueExistsAsync_Should_Return_True_If_The_Issue_Exists_Test()") | 74 | 1 :heavy_check_mark: | 0 | 7 | 19 / 5 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="issueserviceunittests">
    IssueServiceUnitTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueServiceUnitTests` contains 7 members.
- 431 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [32](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L32 "IssueServiceUnitTests.IssueServiceUnitTests()") | 67 | 1 :heavy_check_mark: | 0 | 9 | 53 / 6 |
| Property | [29](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L29 "IssueDto[] IssueServiceUnitTests.IssueDtos") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [27](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L27 "Issue[] IssueServiceUnitTests.Issues") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [30](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L30 "IssueForDeleteDto IssueServiceUnitTests.IssueToDeleteDto") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [28](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L28 "Mock<ILogger<IssueService>> IssueServiceUnitTests.LoggerMock") | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Property | [26](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L26 "Mock<IRepository> IssueServiceUnitTests.RepositoryMock") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Property | [25](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L25 "IIssueService IssueServiceUnitTests.ServiceUnderTest") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="responseserviceunittests-responseexitsasync">
    ResponseServiceUnitTests.ResponseExitsAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseServiceUnitTests.ResponseExitsAsync` contains 2 members.
- 42 total lines of source code.
- Approximately 10 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [177](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L177 "Task ResponseExitsAsync.ResponseExistsAsync_Should_Return_False_If_The_Response_Does_Not_Exist_Test()") | 74 | 1 :heavy_check_mark: | 0 | 7 | 19 / 5 |
| Method | [157](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L157 "Task ResponseExitsAsync.ResponseExistsAsync_Should_Return_True_If_The_Response_Exists_Test()") | 74 | 1 :heavy_check_mark: | 0 | 7 | 19 / 5 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="responseserviceunittests">
    ResponseServiceUnitTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseServiceUnitTests` contains 7 members.
- 431 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [32](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L32 "ResponseServiceUnitTests.ResponseServiceUnitTests()") | 67 | 1 :heavy_check_mark: | 0 | 9 | 53 / 6 |
| Property | [28](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L28 "Mock<ILogger<ResponseService>> ResponseServiceUnitTests.LoggerMock") | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Property | [26](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L26 "Mock<IRepository> ResponseServiceUnitTests.RepositoryMock") | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Property | [29](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L29 "ResponseDto[] ResponseServiceUnitTests.ResponseDtos") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [27](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L27 "Response[] ResponseServiceUnitTests.Responses") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [30](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L30 "ResponseForDeleteDto ResponseServiceUnitTests.ResponseToDeleteDto") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [25](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L25 "IResponseService ResponseServiceUnitTests.ServiceUnderTest") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="commentserviceunittests-updatecommentasync">
    CommentServiceUnitTests.UpdateCommentAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CommentServiceUnitTests.UpdateCommentAsync` contains 3 members.
- 83 total lines of source code.
- Approximately 35 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [350](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L350 "Task UpdateCommentAsync.UpdateCommentAsync_Should_Update_and_return_the_specified_Comment_Test()") | 60 | 1 :heavy_check_mark: | 0 | 9 | 29 / 14 |
| Method | [320](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L320 "Task UpdateCommentAsync.UpdateCommentAsync_Where_Repositroy_Fails_Should__return_a_CommentNotUpdatedException_Test()") | 59 | 1 :heavy_check_mark: | 0 | 12 | 29 / 14 |
| Method | [299](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/CommentServiceUnitTests.cs#L299 "Task UpdateCommentAsync.UpdateCommentAsync_With_A_NonExisting_Comment_Should_Return_CommentNotFoundException_Test()") | 69 | 1 :heavy_check_mark: | 0 | 8 | 20 / 7 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="issueserviceunittests-updateissueasync">
    IssueServiceUnitTests.UpdateIssueAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IssueServiceUnitTests.UpdateIssueAsync` contains 3 members.
- 83 total lines of source code.
- Approximately 35 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [350](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L350 "Task UpdateIssueAsync.UpdateIssueAsync_Should_Update_and_return_the_specified_Issue_Test()") | 60 | 1 :heavy_check_mark: | 0 | 9 | 29 / 14 |
| Method | [320](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L320 "Task UpdateIssueAsync.UpdateIssueAsync_Where_Repositroy_Fails_Should__return_a_IssueNotUpdatedException_Test()") | 59 | 1 :heavy_check_mark: | 0 | 12 | 29 / 14 |
| Method | [299](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/IssueServiceUnitTests.cs#L299 "Task UpdateIssueAsync.UpdateIssueAsync_With_A_NonExisting_Issue_Should_Return_IssueNotFoundException_Test()") | 69 | 1 :heavy_check_mark: | 0 | 8 | 20 / 7 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

<details>
<summary>
  <strong id="responseserviceunittests-updateresponseasync">
    ResponseServiceUnitTests.UpdateResponseAsync :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ResponseServiceUnitTests.UpdateResponseAsync` contains 3 members.
- 83 total lines of source code.
- Approximately 35 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [350](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L350 "Task UpdateResponseAsync.UpdateResponseAsync_Should_Update_and_return_the_specified_Response_Test()") | 60 | 1 :heavy_check_mark: | 0 | 9 | 29 / 14 |
| Method | [320](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L320 "Task UpdateResponseAsync.UpdateResponseAsync_Where_Repositroy_Fails_Should__return_a_ResponseNotUpdatedException_Test()") | 59 | 1 :heavy_check_mark: | 0 | 12 | 29 / 14 |
| Method | [299](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/IR.Shared.Unit.Tests/Services/ResponseServiceUnitTests.cs#L299 "Task UpdateResponseAsync.UpdateResponseAsync_With_A_NonExisting_Response_Should_Return_ResponseNotFoundException_Test()") | 69 | 1 :heavy_check_mark: | 0 | 8 | 20 / 7 |

<a href="#ir-shared-unit-tests-services">:top: back to IR.Shared.Unit.Tests.Services</a>

</details>

</details>

<a href="#ir-shared-unit-tests">:top: back to IR.Shared.Unit.Tests</a>

<div id='testhelpers'></div>

## TestHelpers :heavy_check_mark:

The *TestHelpers.csproj* project file contains:

- 1 namespaces.
- 5 named types.
- 243 total lines of source code.
- Approximately 80 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="testhelpers">
    TestHelpers :heavy_check_mark:
  </strong>
</summary>
<br>

The `TestHelpers` namespace contains 5 named types.

- 5 named types.
- 243 total lines of source code.
- Approximately 80 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="automappersingleton">
    AutoMapperSingleton :heavy_check_mark:
  </strong>
</summary>
<br>

- The `AutoMapperSingleton` contains 2 members.
- 17 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [8](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/AutoMapperSingleton.cs#L8 "IMapper AutoMapperSingleton._mapper") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [10](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/AutoMapperSingleton.cs#L10 "IMapper AutoMapperSingleton.Mapper") | 71 | 2 :heavy_check_mark: | 0 | 4 | 13 / 6 |

<a href="#testhelpers">:top: back to TestHelpers</a>

</details>

<details>
<summary>
  <strong id="loggerutils">
    LoggerUtils :heavy_check_mark:
  </strong>
</summary>
<br>

- The `LoggerUtils` contains 3 members.
- 26 total lines of source code.
- Approximately 7 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [9](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/LoggerUtils.cs#L9 "Mock<ILogger<T>> LoggerUtils.LoggerMock<T>()") | 100 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Method | [14](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/LoggerUtils.cs#L14 "void LoggerUtils.VerifyLog<T>(Mock<ILogger<T>> loggerMock, LogLevel level, string message, string failMessage = null)") | 82 | 1 :heavy_check_mark: | 0 | 4 | 5 / 2 |
| Method | [20](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/LoggerUtils.cs#L20 "void LoggerUtils.VerifyLog<T>(Mock<ILogger<T>> loggerMock, LogLevel level, string message, Times times, string failMessage = null)") | 75 | 1 :heavy_check_mark: | 0 | 8 | 12 / 4 |

<a href="#testhelpers">:top: back to TestHelpers</a>

</details>

<details>
<summary>
  <strong id="mockdbsetfactory">
    MockDbSetFactory :heavy_check_mark:
  </strong>
</summary>
<br>

- The `MockDbSetFactory` contains 1 members.
- 17 total lines of source code.
- Approximately 12 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [15](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/mock.cs#L15 "Mock<DbSet<T>> MockDbSetFactory.Create<T>(IEnumerable<T> data)") | 64 | 1 :heavy_check_mark: | 0 | 4 | 12 / 12 |

<a href="#testhelpers">:top: back to TestHelpers</a>

</details>

<details>
<summary>
  <strong id="mockhelpers">
    MockHelpers :heavy_check_mark:
  </strong>
</summary>
<br>

- The `MockHelpers` contains 6 members.
- 127 total lines of source code.
- Approximately 40 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [28](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/MockHelpers.cs#L28 "Mock<DbSet<T>> MockHelpers.CreateDbSetMock<T>(IEnumerable<T> elements)") | 65 | 1 :heavy_check_mark: | 0 | 4 | 18 / 11 |
| Method | [64](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/MockHelpers.cs#L64 "Task<DataContext> MockHelpers.CreateMockedDataContext(DbContextOptions<DataContext> options)") | 61 | 2 :heavy_check_mark: | 0 | 7 | 37 / 14 |
| Method | [46](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/MockHelpers.cs#L46 "List<Issue> MockHelpers.Issues(int countOfIssues)") | 72 | 2 :heavy_check_mark: | 0 | 3 | 17 / 5 |
| Method | [132](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/MockHelpers.cs#L132 "void MockHelpers.MockModelState<TModel, TController>(TModel model, TController controller)") | 73 | 2 :heavy_check_mark: | 0 | 5 | 17 / 5 |
| Method | [102](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/MockHelpers.cs#L102 "Task MockHelpers.SeedData(DbContextOptions<DataContext> options)") | 80 | 1 :heavy_check_mark: | 0 | 6 | 13 / 3 |
| Method | [116](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/MockHelpers.cs#L116 "DbContextOptions<DataContext> MockHelpers.SetDbContextOptions(string dbName)") | 88 | 1 :heavy_check_mark: | 0 | 4 | 13 / 2 |

<a href="#testhelpers">:top: back to TestHelpers</a>

</details>

<details>
<summary>
  <strong id="mockhttpclientbunithelpers">
    MockHttpClientBunitHelpers :heavy_check_mark:
  </strong>
</summary>
<br>

- The `MockHttpClientBunitHelpers` contains 3 members.
- 40 total lines of source code.
- Approximately 15 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [16](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/MockHttpClientBunitHelpers.cs#L16 "MockHttpMessageHandler MockHttpClientBunitHelpers.AddMockHttpClient(TestServiceProvider services)") | 75 | 1 :heavy_check_mark: | 0 | 4 | 8 / 5 |
| Method | [25](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/MockHttpClientBunitHelpers.cs#L25 "MockedRequest MockHttpClientBunitHelpers.RespondJson<T>(MockedRequest request, T content)") | 75 | 1 :heavy_check_mark: | 0 | 5 | 13 / 5 |
| Method | [39](https://github.com/mpaulosky/IRApplication/blob/feature-update-documents/src/Tests/TestHelpers/MockHttpClientBunitHelpers.cs#L39 "MockedRequest MockHttpClientBunitHelpers.RespondJson<T>(MockedRequest request, Func<T> contentProvider)") | 75 | 1 :heavy_check_mark: | 0 | 6 | 13 / 5 |

<a href="#testhelpers">:top: back to TestHelpers</a>

</details>

</details>

<a href="#testhelpers">:top: back to TestHelpers</a>

## Metric definitions

  - **Maintainability index**: Measures ease of code maintenance. Higher values are better.
  - **Cyclomatic complexity**: Measures the number of branches. Lower values are better.
  - **Depth of inheritance**: Measures length of object inheritance hierarchy. Lower values are better.
  - **Class coupling**: Measures the number of classes that are referenced. Lower values are better.
  - **Lines of source code**: Exact number of lines of source code. Lower values are better.
  - **Lines of executable code**: Approximates the lines of executable code. Lower values are better.

*This file is maintained by a bot.*

<!-- markdownlint-restore -->
