﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.Experience
{
    public class DeleteExperienceRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
