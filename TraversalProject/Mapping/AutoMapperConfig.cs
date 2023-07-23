using AutoMapper;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.DtoLayer.Dtos.DestinationDto;
using TraversalProject.DtoLayer.Dtos.SubAutoDto;
using TraversalProject.DtoLayer.Dtos.TestimonialDto;

namespace TraversalProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ListDestinationDto, Destination>().ReverseMap();
            CreateMap<Destination, ListDestinationDto>().ReverseMap();

            CreateMap<ListSubAboutDto, SubAbout>().ReverseMap();
            CreateMap<SubAbout, ListSubAboutDto>().ReverseMap();

            CreateMap<ListTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<Testimonial, ListTestimonialDto>().ReverseMap();


            //CreateMap<UpdateServiceDto, Service>().ReverseMap();
            //CreateMap<CreateServiceDto, Service>().ReverseMap();


            //CreateMap<ResultAboutDto, About>().ReverseMap();
            //CreateMap<UpdateAboutDto, About>().ReverseMap();

            //CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            //CreateMap<ResultStaffDto, Staff>().ReverseMap();

            //CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();


            //CreateMap<CreateBookingDto, Booking>().ReverseMap();

            //CreateMap<ApprovedReservationDto, Booking>().ReverseMap();


            //CreateMap<CreateGuestDto, Guest>().ReverseMap();
            //CreateMap<UpdateGuestDto, Guest>().ReverseMap();

            //CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            //CreateMap<LoginUserDto, AppUser>().ReverseMap();
        }
    }
}