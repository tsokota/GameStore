using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Domain.Abstract
{
    public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
    }
}
