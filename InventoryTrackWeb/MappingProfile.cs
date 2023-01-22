using AutoMapper;
using InventoryTrackWeb.Models;
using InventoryTrackWeb.Models.ViewModels;

namespace InventoryTrackWeb
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductViewModels, Product>();

            CreateMap<Product, ProductViewModels>();
        }
    }
}
