namespace GameZone.Services
{
	public interface IGamesService
	{
		Task<IEnumerable<Game>> GetAll();
        Task<Game?> GetById(int id);
        Task Create(CreateGameFormViewModel model);
        Task<Game?> Update(EditGameFormViewModel model);
        IEnumerable<Game> search(IEnumerable<Game> games,string searchText);
        bool Delete(int id);
    }
}
