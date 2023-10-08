namespace GameZone.Controllers
{
    
    public class HomeController : Controller
    {
		#region Fields
		private readonly IGamesService _gamesService;
		private readonly ICategoriesService _categoriesService;
		#endregion

		#region Constructor
		public HomeController(IGamesService gamesService, ICategoriesService categoriesService)
        {
            _gamesService = gamesService;
			_categoriesService = categoriesService;
		}
		#endregion

		#region Index
		[HttpGet]
        public async Task<IActionResult> Index()
        {
			IEnumerable<SelectListItem> categories =await _categoriesService.GetCategories();
			ViewBag.categories = categories;
			IEnumerable<Game> games =await _gamesService.GetAll();
            return View(games);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string searchStr)
        {
            IEnumerable<SelectListItem> categories =await _categoriesService.GetCategories();
            ViewBag.categories = categories;
			IEnumerable<Game> games =await _gamesService.GetAll();

            if (!string.IsNullOrEmpty(searchStr))
            {
                var searchResult = _gamesService.search(games, searchStr);
                return View(searchResult);
            }
            return View(games);
        }
		#endregion

	}
}