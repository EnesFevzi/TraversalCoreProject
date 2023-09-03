using AutoMapper;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.DtoLayer.Dtos.DestinationDto;
using TraversalProject.DtoLayer.Dtos.SubAutoDto;
using TraversalProject.DtoLayer.Dtos.TestimonialDto;
using TraversalProject.DtoLayer.Dtos.CommentDto;
using TraversalProject.DtoLayer.Dtos.RegisterDto;
using TraversalProject.DtoLayer.Dtos.UserDto;
using TraversalProject.DtoLayer.Dtos.ReservationDto;
using TraversalProject.DtoLayer.Dtos.GuideDto;
using TraversalProject.DtoLayer.Dtos.AnnouncementDto;
using TraversalProject.DtoLayer.Dtos.MessageDto;

namespace TraversalProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ListDestinationDto, Destination>().ReverseMap();
            CreateMap<AddDestinationDto, Destination>().ReverseMap();
            CreateMap<UpdateDestinationDto, Destination>().ReverseMap();


            CreateMap<ListSubAboutDto, SubAbout>().ReverseMap();


            CreateMap<ListTestimonialDto, Testimonial>().ReverseMap();


            CreateMap<ListCommentDto, Comment>().ReverseMap();


			CreateMap<CreateUserDto, AppUser>().ReverseMap();


            CreateMap<UserEditViewDto, AppUser>().ReverseMap();

            CreateMap<ListGuideDto, Guide>().ReverseMap();
            CreateMap<AddGuideDto, Guide>().ReverseMap();
            CreateMap<UpdateGuideDto, Guide>().ReverseMap();

            CreateMap<ListReservationDto, Reservation>().ReverseMap();
            CreateMap<AddReservationDto, Reservation>().ReverseMap();



            CreateMap<AddAnnouncementDto, Announcement>().ReverseMap();
            CreateMap<ListAnnouncementDto, Announcement>().ReverseMap();
            CreateMap<UpdateAnnouncementDto, Announcement>().ReverseMap();



            CreateMap<SendMessageDto, ContactUs>().ReverseMap();


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