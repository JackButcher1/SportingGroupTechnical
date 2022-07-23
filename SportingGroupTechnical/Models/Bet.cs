using System;

namespace SportingGroupTechnical.Models
{
    /*
     * Bet
     * ---
     * Defines an object which represents a bet on a fixture.
     */
    public class Bet
    {
        public Int32 Id { get; set; }           // Unique bet ID.
        public Int32 FixtureId { get; set; }    // ID of the fixture that this bet was placed on.
        public Result Result { get; set; }      // The result required for this bet to win.
        public Decimal Stake { get; set; }      // Amount staked.
        public Fixture? Fixture { get; set; }   // The associated fixture object, retrieved server-side from the given ID.
        public Boolean? IsWinner { get; set; }  // Did the bet win?
        public Decimal? Winnings { get; set; }  // Bet winnings (including stake).
    }
}
