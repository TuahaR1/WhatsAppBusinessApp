using WhatsAppBotAPi.Services.Response;
using WhatsAppBotAPi.Services.SendMessageTemplate;

namespace WhatsAppBotAPi.Services.Interfaces
{
    public interface IWhatsAppBussinesManager
    {
        Task<WhatsAppResponse> SendFirstTemplateMessageAsync(SendWhatsAppPizzaPayload payload);

    }
}
