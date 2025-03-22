﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Domain.Enum;

public enum Position
{
    [Display(Name = "Trener personalny")]
    Trainer,
    [Display(Name = "Recepcjonista/ka")]

    Receptionist,
    [Display(Name = "Asystent/ka")]

    Assistance
}
