﻿using PKS.Models.DBModels;
using PKS.Models.DTO.Bus;
using PKS.Models.DTO.BusSchema;
using PKS.Models.DTO.BusType;
using PKS.Models.DTO.Discount;

namespace PKS.Services
{
    public interface IPKSModelValidator
    {
        public string? ValidateBusAddDTO(BusAddDTO bus);
        public string? ValidateBusSchemaAddDTO(BusSchemaAddDTO busSchema);
        public string? ValidateBusTypeAddDTO(BusTypeAddDTO busType);
        public string? ValidateDiscountAddDTO(DiscountAddDTO discount);
    }
}