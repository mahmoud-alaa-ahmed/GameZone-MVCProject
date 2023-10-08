namespace GameZone.Services
{
	public interface ICategoriesService
	{
		Task<IEnumerable<SelectListItem>> GetCategories();
		Task<bool> Create(BaseViewModel model);
	}
}
