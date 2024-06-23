
namespace TokyoStock.Core.Entities.Filters
{
    public class Filter
    {
        public string? TextToSearch { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
