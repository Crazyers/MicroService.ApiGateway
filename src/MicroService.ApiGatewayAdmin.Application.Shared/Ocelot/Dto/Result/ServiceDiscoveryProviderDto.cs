﻿using System;

namespace MicroService.ApiGateway.Ocelot.Dto
{
    [Serializable]
    public class ServiceDiscoveryProviderDto
    {
        public string Host { get; set; }
        public int? Port { get; set; }
        public string Type { get; set; }
        public string Token { get; set; }
        public string ConfigurationKey { get; set; }
        public int? PollingInterval { get; set; }
        public string Namespace { get; set; }
    }
}