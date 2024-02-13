using Microsoft.AspNetCore.Mvc;

namespace Emmcnorb.Controllers
{
    public class AffinityHarmonyAnalyzerController : Controller
    {
        private readonly ILogger<AffinityHarmonyAnalyzerController> _logger;

        public AffinityHarmonyAnalyzerController(ILogger<AffinityHarmonyAnalyzerController> logger)
        {
            _logger = logger;
        }
        public IActionResult AffinityHarmonyAnalyzer()
        {
            return View();
        }
    }
}
