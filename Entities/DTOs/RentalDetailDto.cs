﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int RentId { get; set; }
        public string CarName { get; set; }
        public DateTime RentDate { get; set; }
    }
}
