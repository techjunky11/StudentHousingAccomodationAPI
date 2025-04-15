using MediatR;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Queries
{
    public class GetAllUserRequest : IRequest<List<GetUserDto>>
    {
    }
}