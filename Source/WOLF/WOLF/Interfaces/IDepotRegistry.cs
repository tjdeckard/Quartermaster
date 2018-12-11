﻿using System.Collections.Generic;

namespace WOLF
{
    public interface IDepotRegistry : IPersistenceAware
    {
        IDepot AddDepot(string body, string biome);
        IDepot GetDepot(string body, string biome);
        List<IDepot> GetDepots();
        bool HasDepot(string body, string biome);
    }
}