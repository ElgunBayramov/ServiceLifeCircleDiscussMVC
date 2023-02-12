using Microsoft.AspNetCore.Mvc;
using ServiceLifeCircleDiscuss.AppCode.Services;

namespace ServiceLifeCircleDiscuss.AppCode.ViewComponents
{
    public class DemoViewComponent : ViewComponent
    {
        private readonly CryptoService cryptoService;

        public DemoViewComponent(CryptoService cryptoService)
        {
            this.cryptoService = cryptoService;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.DemoInstanceId = cryptoService.InstanceId; 
            return View();
        }
    }
}
