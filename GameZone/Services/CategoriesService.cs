namespace GameZone.Services
{
	public class CategoriesService : ICategoriesService
	{
		private readonly ApplicationDbContext _context;

		public CategoriesService(ApplicationDbContext context)
		{
			this._context = context;
		}
		public async Task<IEnumerable<SelectListItem>> GetCategories()
		{
			return await _context.Categories
				.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
				.OrderBy(c => c.Text)
				.AsNoTracking()
				.ToListAsync();
		}
		public async Task<bool> Create(BaseViewModel model)
		{
			var isCreated = false;
			Category? cat = await _context.Categories.FirstOrDefaultAsync(c => c.Name == model.Name);
			if (cat is null)
			{
				Category category = new Category()
				{
					Name = model.Name,
				};
				_context.Add(category);
				await _context.SaveChangesAsync();
				isCreated = true;
				return isCreated;
			}
			return isCreated;

		}
	}
}
