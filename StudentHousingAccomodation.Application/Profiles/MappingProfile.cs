using AutoMapper;
using StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos;
using StudentHousingAccomodation.Domain.Dtos.PropertyAmentitiesInformationDtos;
using StudentHousingAccomodation.Domain.Dtos.PropertyImageDtos;
using StudentHousingAccomodation.Domain.Dtos.PropertyInformationDtos;
using StudentHousingAccomodation.Domain.Dtos.PropertyRatingDtos;
using StudentHousingAccomodation.Domain.Dtos.RoomInformationDto;
using StudentHousingAccomodation.Domain.Dtos.StudentInformationDtos;
using StudentHousingAccomodation.Domain.Dtos.StudentInterestsDtos;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateNewUserDto, User>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();
            CreateMap<User, GetUserDto>().ReverseMap();
            CreateMap<PropertyImage, CreateNewPropertyImageDto>().ReverseMap();
            CreateMap<PropertyImage, GetThePropertyImageDto>().ReverseMap();
            CreateMap<LandLordInformation, CreateNewLandLordInformationDto>().ReverseMap();
            CreateMap<LandLordInformation, GetTheLandLordInformationDto>().ReverseMap();
            CreateMap<LandLordInformation, UpdateTheLandLordInformationDto>().ReverseMap();
            CreateMap<PropertyAmentiesInformation, CreateNewPropertyAmentitiesInformationDto>().ReverseMap();
            CreateMap<PropertyAmentiesInformation, GetThePropertyAmentitiesInformationDto>().ReverseMap();

            CreateMap<PropertyInformation, CreateNewPropertyInformationDto>().ReverseMap();
            CreateMap<PropertyInformation, GetThePropertyInformationDto>().ReverseMap();
            CreateMap<PropertyInformation, UpdateThePropertyInformationDto>().ReverseMap();
            CreateMap<PropertyRating, CreateNewPropertyRatingDto>().ReverseMap();
            CreateMap<PropertyRating, GetThePropertyRatingDto>().ReverseMap();
            CreateMap<RoomInformation, CreateNewRoomInformationDto>().ReverseMap();
            CreateMap<RoomInformation, GetTheRoomInformationDto>().ReverseMap();
            CreateMap<RoomInformation, UpdateTheRoomInformationDto>().ReverseMap();

            CreateMap<StudentInformation, CreateNewStudentInformationDto>().ReverseMap();
            CreateMap<StudentInformation, GetTheStudentInformationDto>().ReverseMap();
            CreateMap<StudentInformation, UpdateTheStudentInformationDto>().ReverseMap();
            CreateMap<StudentInterests, GetTheStudentInterestsDto>().ReverseMap();

            CreateMap<StudentInterests, CreateNewStudentInterestsDto>().ReverseMap();
        }
    }
}