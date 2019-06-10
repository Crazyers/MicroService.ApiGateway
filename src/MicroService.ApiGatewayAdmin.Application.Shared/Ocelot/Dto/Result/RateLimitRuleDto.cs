﻿using System.Collections.Generic;

namespace MicroService.ApiGateway.Ocelot.Dto
{
    public class RateLimitRuleDto
    {
        public List<string> ClientWhitelist { get; set; }

        public bool EnableRateLimiting { get; set; }

        public string Period { get; set; }

        public double? PeriodTimespan { get; set; }

        public long? Limit { get; set; }
        public RateLimitRuleDto()
        {
            ClientWhitelist = new List<string>();
        }
    }
}