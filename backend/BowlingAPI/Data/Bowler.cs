﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BowlingAPI.Data;

public partial class Bowler
{
    public int BowlerID { get; set; }

    public string? BowlerLastName { get; set; }

    public string? BowlerFirstName { get; set; }

    public string? BowlerMiddleInit { get; set; }

    public string? BowlerAddress { get; set; }

    public string? BowlerCity { get; set; }

    public string? BowlerState { get; set; }

    public string? BowlerZip { get; set; }

    public string? BowlerPhoneNumber { get; set; }

    [ForeignKey("Team")]
    public int? TeamID { get; set; }

    //public virtual ICollection<BowlerScore> BowlerScores { get; set; } = new List<BowlerScore>();

    public Team? Team { get; set; }


}
