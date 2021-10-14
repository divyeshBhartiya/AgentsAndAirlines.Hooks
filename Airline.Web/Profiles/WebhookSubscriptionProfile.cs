using AutoMapper;
using Airline.Web.Dtos;
using Airline.Web.Models;

namespace Airline.Web.Profiles
{
    public class WebhookSubscriptionProfile : Profile
    {
        public WebhookSubscriptionProfile()
        {
            //Source -> Target
            CreateMap<WebhookSubscriptionCreateDto, WebhookSubscription>();
            CreateMap<WebhookSubscription, WebhookSubscriptionReadDto>();
        }
    }
}