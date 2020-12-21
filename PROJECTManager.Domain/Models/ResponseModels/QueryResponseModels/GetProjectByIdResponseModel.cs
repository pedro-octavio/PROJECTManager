using System;

namespace PROJECTManager.Domain.Models.ResponseModels.QueryResponseModels
{
    public class GetProjectByIdResponseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
