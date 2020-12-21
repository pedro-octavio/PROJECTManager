using MediatR;
using Newtonsoft.Json;
using PROJECTManager.Domain.Models.ResponseModels.CommandResponseModels;
using System;

namespace PROJECTManager.Domain.Models.RequestModels.CommandRequestModels
{
    public class AddProjectRequestModel : IRequest<AddProjectResponseModel>
    {
        [JsonConstructor]
        public AddProjectRequestModel(string name, string description)
        {
            Id = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10);
            Name = name;
            Description = description;
            CreateDate = DateTime.Now;
        }

        public string Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; private set; }
    }
}
