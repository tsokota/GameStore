using System.Collections.Generic;
using GameStore.Domain.Entities;

namespace GameStore.WebUI.Models
{
    public interface IGamesListViewModel
    {
        IEnumerable<Game> Games { get; set; }
        IPagingInfo PagingInfo { get; set; }
    }
}