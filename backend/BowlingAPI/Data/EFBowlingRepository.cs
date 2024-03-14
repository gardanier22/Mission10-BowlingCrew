using Microsoft.EntityFrameworkCore;
//OG CODE I HAD

namespace BowlingAPI.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingLeagueContext;

        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _bowlingLeagueContext = temp;
        }

        //portion that queries the data to show what i want and also connect the teamnames to the data
        public IEnumerable<Bowler> Bowlers => _bowlingLeagueContext.Bowlers
            .Include(x => x.Team)
            .Where(x => x.Team.TeamName == "Marlins" || x.Team.TeamName == "Sharks").ToList();

        public IEnumerable<Team> Teams => _bowlingLeagueContext.Teams;

    }
}



    
