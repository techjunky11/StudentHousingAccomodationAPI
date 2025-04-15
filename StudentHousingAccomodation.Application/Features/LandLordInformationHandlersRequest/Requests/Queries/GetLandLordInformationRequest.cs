using MediatR;
using StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.LandLordInformationHandlersRequest.Requests.Queries
{
    public class GetLandLordInformationRequest : IRequest<GetTheLandLordInformationDto>
    {
        public Guid LandLordId { get; set; } //e.g. "12345678-1234-1234-1234-123456789012"
    }
}