using AutoMapper;
using MyBlazorApp.Application.Interfaces.Chat;
using MyBlazorApp.Application.Models.Chat;
using MyBlazorApp.Infrastructure.Models.Identity;

namespace MyBlazorApp.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}