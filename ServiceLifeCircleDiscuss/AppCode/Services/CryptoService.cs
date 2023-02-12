using System;

namespace ServiceLifeCircleDiscuss.AppCode.Services
{
    public class CryptoService
    {
        public string InstanceId { get; set; }

        public CryptoService()
        {
            this.InstanceId = Guid.NewGuid().ToString();
        }
    }
}
