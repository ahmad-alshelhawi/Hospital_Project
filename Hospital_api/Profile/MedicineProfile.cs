using AutoMapper;
using Hospital.entities;
using Hospital.Models;

namespace Pos2.api.profile
{

    public class MedicineProfile : Profile
    {
        public MedicineProfile()
        {
            this.CreateMap<Medicine, MedicineAddMapper>().ReverseMap();
            this.CreateMap<Medicine, MedicineUpdateMapper>().ReverseMap();
            this.CreateMap<Medicine, MedicineMapper>().ReverseMap();
            this.CreateMap<Medicine, MedicineSearchMapper>().ReverseMap();
            this.CreateMap<Medicine, MedicineSearchMapperOut>().ReverseMap();



        }
    }
}
