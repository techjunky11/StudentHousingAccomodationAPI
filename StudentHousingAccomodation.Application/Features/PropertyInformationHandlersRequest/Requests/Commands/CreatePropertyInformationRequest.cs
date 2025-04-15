using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyInformationDtos;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.PropertyInformationHandlersRequest.Requests.Commands
{
    public class CreatePropertyInformationRequest : IRequest<GeneralResponse>
    {
        public CreateNewPropertyInformationDto? PropertyInformation { get; set; }
    }
}