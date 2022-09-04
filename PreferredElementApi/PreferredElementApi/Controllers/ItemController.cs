using Microsoft.AspNetCore.Mvc;
using PreferredElementApi.Models;
using PreferredElementApi.Services;

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
        public ItemDto[] GetItems()
        {
            return preferredElementService.GetItems();
        }

        [HttpGet("getbyid")]
        public ItemDto GetItemById(int itemId)
        {
            return preferredElementService.GetItemById(itemId);
        }

        [HttpGet("getpreferred")]
        public ItemDto[] GetPreferredItems([FromQuery] int[] brickDesignIds)
        {
            return preferredElementService.GetPreferredItems(brickDesignIds);
        }
    }
}