using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyAmentitiesInformationDtos;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.PropertyAmentitiesInformationHandlersRequest.Requests.Commands
{
    public class CreatePropertyAmentitiesInformationRequest : IRequest<GeneralResponse>
    {
        public List<CreateNewPropertyAmentitiesInformationDto>? AmentitiesInformationDto { get; set; } //e.g. "Sports", "Music", "Art", etc
    }
}