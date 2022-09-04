using Microsoft.AspNetCore.Mvc;
using PreferredElementApi.Services;
using PreferredElementData.Models;

namespace PreferredElementApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ILogger<MasterDataController> logger;
        private readonly IPreferredElementService preferredElementService;

        public ItemController(ILogger<MasterDataController> logger, IPreferredElementService preferredElementService)
        {
            this.logger = logger;
            this.preferredElementService = preferredElementService;
        }

        [HttpGet]
        public Item[] GetItems()
        {
            return preferredElementService.GetItems();
        }
    }
}