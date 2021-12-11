﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Xeptions;

namespace CoronaTracker.Core.Models.Processings.Countries.Exceptions
{
    public class CountryProcessingDependencyException : Xeption
    {
        public CountryProcessingDependencyException(Xeption innerException)
            : base(message: "Country dependency error occurred, please contact support.", innerException)
        { }
    }
}
