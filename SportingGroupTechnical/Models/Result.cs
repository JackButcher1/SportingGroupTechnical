using System.Text.Json.Serialization;

namespace SportingGroupTechnical.Models
{
    /*
     * Result
     * ------
     * Defines the result of a fixture.
     * The JsonConverter attribute allows us to send/receive HTTP requests/replies with the Result property written as a String.
     */
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Result
    {
        UNDECIDED,
        HOME,
        AWAY,
        DRAW,
        CANCELLED
    }
}
