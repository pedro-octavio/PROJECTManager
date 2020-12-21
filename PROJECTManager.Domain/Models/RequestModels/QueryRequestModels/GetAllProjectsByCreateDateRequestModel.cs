using MediatR;
using PROJECTManager.Domain.Models.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;

namespace PROJECTManager.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetAllProjectsByCreateDateRequestModel : IRequest<IEnumerable<GetAllProjectsByCreateDateResponseModel>>
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
