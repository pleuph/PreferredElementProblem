using Microsoft.AspNetCore.Mvc;
using PreferredElementApi.Models;
using PreferredElementApi.Services;

namespace PreferredElementApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MasterDataController : ControllerBase
    {
        private readonly ILogger<MasterDataController> logger;
        private readonly IPreferredElementService preferredElementService;

        public MasterDataController(ILogger<MasterDataController> logger, IPreferredElementService preferredElementService)
        {
            this.logger = logger;
            this.preferredElementService = preferredElementService;
        }

        [HttpGet]
        public MasterDataDto[] GetMasterDatas()
        {
            return preferredElementService.GetMasterDatas();
        }

        [HttpGet("getbyitemid")]
        public MasterDataDto GetMasterDataByItemId(int itemId)
        {
            return preferredElementService.GetMasterDataByItemId(itemId);
        }
    }
}