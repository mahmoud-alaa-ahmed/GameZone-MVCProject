namespace GameZone.Controllers
{
	public class CategoryController : Controller
	{
		#region Fields
		private readonly ICategoriesService categoriesService;
		#endregion

		#region Constructor
		public CategoryController(ICategoriesService _categoriesService)
		{
			this.categoriesService = _categoriesService;
		}
		#endregion

		#region Create

		[HttpGet]
		public IActionResult Create()
		{
            BaseViewModel categoryVM = new BaseViewModel();
			return View(categoryVM);
		}
		[HttpPost]
		public async Task<IActionResult> Create(BaseViewModel categoryVM)
		{
			if(ModelState.IsValid)
			{
				var result= await categoriesService.Create(categoryVM);
				if(result)
				{
					categoryVM.IsCreated = true;
					return View(categoryVM);
				}
				else
				{
					ModelState.AddModelError("", $"Category name '{categoryVM.Name}' is already taken ");
				}
			}
			return View(categoryVM);
		}
		#endregion
	}
}
