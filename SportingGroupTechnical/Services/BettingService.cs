using System;
using System.Collections.Generic;
using System.Linq;
using SportingGroupTechnical.Models;

namespace SportingGroupTechnical.Services
{
    /*
     * Betting Service
     * ---------------
     * A simple in-memory service for storing Bets, supporting get by ID, and add.
     */
    public class BettingService
    {
        private static readonly List<Bet> mBets = new List<Bet>();
        private static Int32 mNextId = 1;

        /*
         * Get
         * ---
         * Returns the Bet in the List with the given ID, or null if it doesn't exist.
         */
        public static Bet? Get(Int32 id)
        {
            Bet bet = mBets.FirstOrDefault(b => b.Id == id);

            // Here we will assign a 'random' result to the associated Fixture, then set the IsWinner and Winnings properties of the Bet.
            // Of course in the real world, this would happen as a result of a fixture completing.

            // Special case for Liverpool :)
            if (bet.Fixture!.HomeTeam == "Liverpool")
            {
                bet.Fixture.Result = Result.HOME;
            }
            else if (bet.Fixture!.AwayTeam == "Liverpool")
            {
                bet.Fixture.Result = Result.AWAY;
            }
            else // Random
            {
                Random random = new Random();
                bet.Fixture!.Result = (Result)random.Next(4);
            }

            bet.IsWinner = bet.Result == bet.Fixture.Result;
            bet.Winnings = (Boolean)bet.IsWinner ? bet.Stake * bet.Fixture.Odds[bet.Result] : 0;

            return bet;
        }

        /*
         * Add
         * ---
         * Adds the given Bet to the List with the next ID, which is then incremented.
         * Also retrieves the Fixture with the ID specified in the Bet and assigns it to the Fixture property.
         */
        public static Int32 Add(Bet bet)
        {
            bet.Id = mNextId++;

            bet.Fixture = FixtureService.Get(bet.FixtureId);
            if (bet.Fixture is null)
            {
                // TODO: error - fixture doesn't exist!
            }

            // TODO: validate stake and result values.

            mBets.Add(bet);

            return bet.Id;
        }
    }
}
