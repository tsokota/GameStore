using GameStore.Domain.Abstract;
using GameStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.WebUI.Controllers
{
    public class GameController : Controller
    {
        private IGameRepository repository;
        private IPagingInfo paginatInfo;
        private IGamesListViewModel gamesList;

        public int pageSize = 4;


        public GameController(IGameRepository repo, IPagingInfo pagInfo, IGamesListViewModel gamlist)
        {
            repository = repo;
            paginatInfo = pagInfo;
            gamesList = gamlist;
            paginatInfo.ItemsPerPage = pageSize;
            paginatInfo.TotalItems = repository.Games.Count();
           gamesList.PagingInfo = paginatInfo as IPagingInfo;
        }

        public ViewResult List(  int page = 1)
        {
            paginatInfo.CurrentPage = page;
            gamesList.Games = repository.Games
                    .OrderBy(game => game.GameId)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize);

            return View(gamesList);
        }
    }
}