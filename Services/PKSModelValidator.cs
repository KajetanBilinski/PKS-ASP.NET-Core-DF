﻿using PKS.Models.DBModels;
using PKS.Models.DTO.Bus;
using PKS.Models.DTO.BusSchema;
using PKS.Models.DTO.BusType;

namespace PKS.Services
{
    public class PKSModelValidator : IPKSModelValidator
    {
        public string? ValidateBusAddDTO(BusAddDTO bus)
        {
            if (bus == null)
                return "Bus is null";
            else if (bus.Capacity <= 0)
                return "Bus capacity is equal or less than 0";
            else if (bus.Type.Year > DateTime.Now.Year)
                return "Year cannot be greater than current year";
            else if (bus.Type.Year < 1900)
                return "Year cannot be less than 1900";
            return null;
        }

        public string? ValidateBusSchemaAddDTO(BusSchemaAddDTO busSchema)
        {
            if (busSchema is null)
                return "BusSchema is null";
            else if (string.IsNullOrEmpty(busSchema.Filename))
                return "BusSchema filename is null or empty";
            return null;
        }

        public string? ValidateBusTypeAddDTO(BusTypeAddDTO busType)
        {
            if (busType is null)
                return "BusType is null";
            else if (string.IsNullOrWhiteSpace(busType.Made))
                return "Made is null or whitespace";
            else if (string.IsNullOrWhiteSpace(busType.Version))
                return "Version is null or whitespace";
            else if (string.IsNullOrWhiteSpace(busType.Engine))
                return "Engine is null or whitespace";
            else if (busType.Year > DateTime.Now.Year)
                return "Year cannot be greater than current year";
            else if (busType.Year < 1900)
                return "Year cannot be less than 1900";
            return null;
        }
    }
}
