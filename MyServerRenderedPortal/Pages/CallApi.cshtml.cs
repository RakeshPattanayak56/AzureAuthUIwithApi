using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Web;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace MyServerRenderedPortal.Pages;

[AuthorizeForScopes(Scopes = new string[] { "api://efeaa6c0-9091-41e9-a63a-ae5afd7e598a/questcore-api-users" })]
public class CallApiModel : PageModel
{
    private readonly ApiService _apiService;

    public JArray DataFromApi { get; set; }
    public CallApiModel(ApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task OnGetAsync()
    {
        DataFromApi = await _apiService.GetApiDataAsync();
    }
}