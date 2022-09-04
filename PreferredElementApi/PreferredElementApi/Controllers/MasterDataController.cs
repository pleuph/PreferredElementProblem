using Microsoft.AspNetCore.Mvc;
using PreferredElementApi.Services;
using PreferredElementData.Models;

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
        public MasterData[] GetMasterDatas()
        {
            return preferredElementService.GetMasterDatas();
        }
    }
}