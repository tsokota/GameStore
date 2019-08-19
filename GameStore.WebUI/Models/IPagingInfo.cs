namespace GameStore.WebUI.Models
{
    public interface IPagingInfo
    {
        int CurrentPage { get; set; }
        int ItemsPerPage { get; set; }
        int TotalItems { get; set; }
        int TotalPages { get; }
    }
}