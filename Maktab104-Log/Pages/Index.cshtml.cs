using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Maktab104_Log.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("Application Started");
        }

        [HttpPost]
        public void OnPostClick()
        {

            try
            {
                // request 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

        }
    }
}
