using MediatR;
using StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.LandLordInformationHandlersRequest.Requests.Commands
{
    public class UpdateLandLordInformationRequest : IRequest<GeneralResponse>
    {
        public Guid LandLordInformationId { get; set; } = Guid.Empty;
        public UpdateTheLandLordInformationDto? updateTheLandLordInformation { get; set; }
    }
}