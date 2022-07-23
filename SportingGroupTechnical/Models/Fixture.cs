﻿using System;
using System.Collections.Generic;

namespace SportingGroupTechnical.Models
{
    /*
     * Fixture
     * -------
     * Defines an object representing a generic sporting fixture (with 2 sides - home & away).
     */
    public class Fixture
    {
        public Int32 Id { get; set; }                           // Unique fixture ID.
        public DateTime Start { get; set; }                     // Start date & time.
        public Result Result { get; set; }                      // Fixture result. Updated when the fixture is either completed or cancelled.
        public Dictionary<Result, Decimal> Odds { get; set; }   // Dictionary defining decimal odds for each result.
    }
}
