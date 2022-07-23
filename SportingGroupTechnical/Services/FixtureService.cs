using System;
using System.Collections.Generic;
using System.Linq;
using SportingGroupTechnical.Models;

namespace SportingGroupTechnical.Services
{
    /*
     * Fixture Service
     * ---------------
     * A simple in-memory service for storing Fixtures, supporting get all, get by ID, and add.
     */
    public static class FixtureService
    {
        private static readonly List<Fixture> mFixtures = new List<Fixture>();
        private static Int32 mNextId = 1;

        /*
         * Get All
         * -------
         * Returns the List of Fixtures.
         */
        public static List<Fixture> GetAll() => mFixtures;

        /*
         * Get
         * ---
         * Returns the Fixture in the List with the given ID, or null if it doesn't exist.
         */
        public static Fixture? Get(Int32 id) => mFixtures.FirstOrDefault(f => f.Id == id);

        /*
         * Add
         * ---
         * Adds the given Fixture to the List with the next ID, which is then incremented.
         * Returns the ID of the Fixture.
         */
        public static Int32 Add(Fixture fixture)
        {
            fixture.Id = mNextId++;
            mFixtures.Add(fixture);
            return fixture.Id;
        }
    }
}
