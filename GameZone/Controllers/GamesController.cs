namespace GameZone.Controllers
{
	[Authorize]
	public class GamesController : Controller
	{
		#region Fields
		private readonly ICategoriesService _categoriesService;
		private readonly IDevicesService _devicesService;
		private readonly IGamesService _gamesServices;
		#endregion

		#region Constructor
		public GamesController(ICategoriesService categoriesService, IDevicesService devicesService, IGamesService gamesServices)
		{
			this._categoriesService = categoriesService;
			this._devicesService = devicesService;
			this._gamesServices = gamesServices;
		}
		#endregion

		#region GetAll
		public async Task<IActionResult> Index()
		{
            var games =await _gamesServices.GetAll();
            return View(games);
		}
		#endregion

		#region Details
		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			var game =await _gamesServices.GetById(id);

			if (game is null)
				return NotFound();

			return View(game);
		}
		#endregion

		#region Create
		[HttpGet]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Create()
		{
			CreateGameFormViewModel viewModel = new()
			{
				Categories =await _categoriesService.GetCategories(),
				Devices =await _devicesService.GetDevices()
			};

			return View(viewModel);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(CreateGameFormViewModel model)
		{
			if (!ModelState.IsValid)
			{
				model.Categories =await _categoriesService.GetCategories();
				model.Devices =await _devicesService.GetDevices();

				return View(model);
			}
			await _gamesServices.Create(model);
			return RedirectToAction(nameof(Index));
		}
		#endregion

		#region Edit
		[HttpGet]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Edit(int id)
        {
            var game =await _gamesServices.GetById(id);

            if (game is null)
                return NotFound();

            EditGameFormViewModel viewModel = new()
            {
                Id = id,
                Name = game.Name,
                Description = game.Description,
                CategoryId = game.CategoryId,
                SelectedDevices = game.Devices.Select(d => d.DeviceId).ToList(),
                Categories =await _categoriesService.GetCategories(),
                Devices =await _devicesService.GetDevices(),
                CurrentCover = game.Cover
            };

            return View(viewModel);
        }

		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditGameFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories =await _categoriesService.GetCategories();
                model.Devices =await _devicesService.GetDevices();
                return View(model);
            }

            var game = await _gamesServices.Update(model);

            if (game is null)
                return BadRequest();

            return RedirectToAction(nameof(Index));
        }
		#endregion

		#region Delete
		[HttpDelete]
		[Authorize(Roles = "Admin")]
		public IActionResult Delete(int id)
        {
            var isDeleted = _gamesServices.Delete(id);

            return isDeleted ? Ok() : BadRequest();
        }
		#endregion
	}
}
