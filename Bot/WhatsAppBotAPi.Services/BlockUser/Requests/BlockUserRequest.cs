﻿using System.Text.Json.Serialization;

namespace WhatsAppBotAPi.Services.BlockUser.Requests
{
    public class BlockUserRequest
    {
        [JsonPropertyName("messaging_product")]
        [JsonInclude]
        public string MessagingProduct { get; private set; } = "whatsapp";

        [JsonPropertyName("block_users")]
        public List<BlockUser> BlockUsers { get; set; }
    }

    public class BlockUser
    {
        [JsonPropertyName("user")]
        public string User { get; set; }
    }
}
