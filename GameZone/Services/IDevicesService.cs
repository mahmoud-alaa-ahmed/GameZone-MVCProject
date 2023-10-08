namespace GameZone.Services
{
	public interface IDevicesService
	{
        Task<IEnumerable<SelectListItem>> GetDevices();
	}
}
