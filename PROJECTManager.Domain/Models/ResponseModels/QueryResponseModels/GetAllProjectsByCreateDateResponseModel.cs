using System;

namespace PROJECTManager.Domain.Models.ResponseModels.QueryResponseModels
{
    public class GetAllProjectsByCreateDateResponseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
