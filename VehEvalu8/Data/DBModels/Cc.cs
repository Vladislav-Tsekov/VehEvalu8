﻿namespace VehEvalu8.Data.DBModels;

public partial class Cc
{
    public int Id { get; set; }

    public int EngineSize { get; set; }

    public virtual ICollection<Motocross> Motocrosses { get; set; } = new List<Motocross>();

    public virtual ICollection<Enduro> Enduroes { get; set; } = new List<Enduro>();
}
