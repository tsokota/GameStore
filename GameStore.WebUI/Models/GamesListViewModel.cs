using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.WebUI.Models
{
    public class GamesListViewModel : IGamesListViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public IPagingInfo PagingInfo { get; set; }
    }
}