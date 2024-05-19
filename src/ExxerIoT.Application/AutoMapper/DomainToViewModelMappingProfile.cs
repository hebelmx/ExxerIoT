using AutoMapper;
using ExxerIoT.Application.ViewModels;
using ExxerIoT.Domain.Models;

namespace ExxerIoT.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}
