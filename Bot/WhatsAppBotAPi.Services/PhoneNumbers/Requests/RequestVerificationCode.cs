﻿using System.Text.Json.Serialization;

namespace WhatsAppBotAPi.Services.PhoneNumbers.Requests
{
    public class RequestVerificationCode
    {
        [JsonPropertyName("code_method")]
        public string CodeMethod { get; set; }

        [JsonPropertyName("locale")]
        public string Locale { get; set; }
    }
}
