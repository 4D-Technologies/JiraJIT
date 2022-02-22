namespace JiraJit;

public class JiraController : Controller
{
    [HttpPost("IssueChange")]
    public async Task<ActionResult> IssueChange()
    {
        await Task.CompletedTask;
        return Ok();
    }
}