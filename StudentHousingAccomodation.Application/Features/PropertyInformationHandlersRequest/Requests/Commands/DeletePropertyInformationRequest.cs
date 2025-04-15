using MediatR;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.PropertyInformationHandlersRequest.Requests.Commands
{
    public class DeletePropertyInformationRequest : IRequest<GeneralResponse>
    {
        public Guid PropertyInformationId { get; set; }
    }
}