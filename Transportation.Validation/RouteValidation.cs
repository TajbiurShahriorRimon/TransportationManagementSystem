﻿using System.Data;
using FluentValidation;
using Transportation.Entity;

namespace Transportation.Validation
{
    public class RouteValidation : AbstractValidator<Route>
    {
        public RouteValidation()
        {
            RuleFor(r => r.DeptLocation)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Departure Location is required!")
                .MaximumLength(50).WithMessage("Maximum 50 characters for Departure Location!");
            
            RuleFor(dest => dest.Destination)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Destination is required!")
                .MaximumLength(50).WithMessage("Maximum 50 characters is valid for Destination!");

            RuleFor(busNo => busNo.BusNo)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Select a Bus Number");
        }
    }
}