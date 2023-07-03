﻿using PKS.Models.DBModels;
using PKS.Models.DTO.Bus;
using PKS.Models.DTO.BusSchema;
using PKS.Models.DTO.BusType;

namespace PKS.Services
{
    public interface IPKSModelValidator
    {
        public string? ValidateBusAddDTO(BusAddDTO bus);
        public string? ValidateBusSchemaAddDTO(BusSchemaAddDTO busSchema);
        public string? ValidateBusTypeAddDTO(BusTypeAddDTO busType);
    }
}