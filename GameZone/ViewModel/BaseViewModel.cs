namespace GameZone.ViewModel
{
	public class BaseViewModel
	{
		[MinLength(3, ErrorMessage = "The minimum length of Name is 3")]
		[MaxLength(10)]
		public string Name { get; set; } = string.Empty;
		public bool IsCreated { get; set; } = false;
	}
}
