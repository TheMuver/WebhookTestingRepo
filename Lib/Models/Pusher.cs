﻿using Newtonsoft.Json;

namespace Lib.Models
{
    public class Pusher
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}