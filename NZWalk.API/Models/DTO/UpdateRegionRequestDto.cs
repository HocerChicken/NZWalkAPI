﻿namespace NZWalk.API.Models.DTO
{
    public class UpdateRegionRequestDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        // ? is null value
        public string? RegionImageUrl { get; set; }
    }
}
