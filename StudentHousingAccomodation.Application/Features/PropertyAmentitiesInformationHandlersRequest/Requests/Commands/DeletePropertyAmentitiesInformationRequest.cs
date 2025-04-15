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
    public class DeletePropertyAmentitiesInformationRequest : IRequest<GeneralResponse>
    {
        public Guid PropertyAmentiesId { get; set; } //e.g. "12345678-1234-1234-1234-123456789012"
    }
}