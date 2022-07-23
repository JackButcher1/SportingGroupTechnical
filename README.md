# SportingGroupTechnical

This project is a small Web API, written with ASP.NET Core 3.1, implementing 2 web services - FixtureService and BettingService. Via HTTP requests a user can create fixtures, read back either a list of fixtures or a specific fixture, place a bet on a specific fixture, and read back the result of that bet. The application caches all data locally in-memory.

The following endpoints are implemented:
 - POST /fixture
 - GET /fixture
 - GET /fixture/{id}
 - POST /bet
 - GET /bet/{id}

# Test examples

If the application is run via the Release .exe, the port should be automatically assigned to 5000. Therefore the URI is defined http://localhost:5000/{endpoint}.

Some test HTTP POST request JSON bodies are included in the following files:
 - POST_fixture1.json
 - POST_fixture2.json
 - POST_fixture3.json
 - POST_bet1.json
 - POST_bet2.json
