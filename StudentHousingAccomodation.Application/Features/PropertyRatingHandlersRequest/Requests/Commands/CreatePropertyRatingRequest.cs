using MediatR;
using StudentHousingAccomodation.Domain.Dtos.PropertyRatingDtos;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Application.Features.PropertyRatingHandlersRequest.Requests.Commands
{
    public class CreatePropertyRatingRequest : IRequest<GeneralResponse>
    {
        public CreateNewPropertyRatingDto? NewPropertyRatingDto { get; set; }
    }
}