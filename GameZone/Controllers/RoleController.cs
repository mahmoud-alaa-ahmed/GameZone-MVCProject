namespace GameZone.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RoleController : Controller
    {
		#region Fields
		private readonly RoleManager<IdentityRole> roleManager;
		#endregion

		#region Constructor
		public RoleController(RoleManager<IdentityRole> _roleManager)
        {
            roleManager = _roleManager;
        }
		#endregion

		#region Create
		[HttpGet]
        public IActionResult Create()
        {
			BaseViewModel roleVM= new BaseViewModel();
			return View(roleVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BaseViewModel roleVM)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole();
                identityRole.Name = roleVM.Name;
                IdentityResult result= await roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
					roleVM.IsCreated = true;
					return View(roleVM);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
			return View(roleVM);
        }
		#endregion

	}
}
