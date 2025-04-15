using MediatR;
using StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.LandLordInformationHandlersRequest.Requests.Queries
{
    public class GetAllLandLordInformationRequest : IRequest<List<GetTheLandLordInformationDto>>
    {
    }
}