using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ChessCodeMarathon.Models
{
    public class MatchItem
    {

        public int Player1Id { get; set; }
        [Required, NotNull]
        public int Player2Id { get; set; }
        [Required, NotNull]

        public string Date { get; set; }
        public string MatchLevel { get; set; }
        [Required, NotNull]
        public int WinnerId { get; set; }




    }

    public class Player
    {

        public int PlayerId { get; set; }
        [Required, NotNull]
        public string FirstName { get; set; }
        [Required, NotNull]
        public string LastName { get; set; }
        [Required, NotNull]
        public string Country { get; set; }
        [Required, NotNull]
        public int CurrentWorldRanking { get; set; }
        [Required, NotNull]
        public int TotalMatchesPlayed { get; set; } = 0;



    }

    public class PlayerPerformanceView
    {

        public int PlayerId { get; set; }
        public string FullName { get; set; }
        public decimal WinPercentage { get; set; }
        public Int64 TotalWon { get; set; }
        public int TotalMatchesPlayed { get; set; }

    }




}
