namespace GameZone.Services
{
	public class DevicesService : IDevicesService
	{
		private readonly ApplicationDbContext _context;

		public DevicesService(ApplicationDbContext context)
		{
			this._context = context;
		}
		public async Task<IEnumerable<SelectListItem>> GetDevices()
		{
			return await _context.Devices
				.Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name })
				.OrderBy(d => d.Text)
				.AsNoTracking()
				.ToListAsync();
		}
	}
}
