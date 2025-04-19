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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Application.Profiles
{
    public class MappingProfile : Profile
    {
        private readonly IRoleRepository roleRepository;

        public MappingProfile(IRoleRepository roleRepository)

        {
            this.roleRepository = roleRepository;
            CreateMap<User, CreateNewUserDto>().ReverseMap();
            CreateMap<CreateNewUserDto, User>().ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => changeRoleNameToRoleId(src.RoleName!)));

            CreateMap<User, GetUserDto>().ReverseMap();
            CreateMap<User, GetUserDto>().ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => changeRoleIdToRoleName(src.RoleId)));
            CreateMap<User, UpdateUserDto>().ReverseMap();
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

        private string changeRoleIdToRoleName(Guid RoleId)
        {
            var role = roleRepository.Get(RoleId);
            return role.Name!;
        }

        private async Task<Guid> changeRoleNameToRoleId(string RoleName)
        {
            var role = await roleRepository.GetRoleByName(RoleName);
            return role.Id;
        }
    }
}