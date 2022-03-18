﻿namespace Data.Model;

public class Card 
{
    public int Id { get; set; }   
    public string CardName { get; set; }
    public string Description { get; set; }
    public int Cost { get; set; }
    public bool IsBasic { get; set; }
    public int? Count { get; set; }

    //navigation
    public CardType Type { get; set; }
    public int TypeId { get; set; }

    public GameVersion GameVersion { get; set; }
    public int VersionId { get; set; }

    public Hero Hero { get; set; }
    public int? HeroId { get; set; }

}