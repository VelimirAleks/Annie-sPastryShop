namespace AnniesPastryShop.Core.Models.Gallery
{
    public class PaginationViewModel
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((double)TotalItems / ItemsPerPage);

        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;

        public PaginationViewModel(int totalItems, int itemsPerPage, int currentPage)
        {
            TotalItems = totalItems;
            ItemsPerPage = itemsPerPage;
            CurrentPage = currentPage;
        }

        public IEnumerable<int> GetPageNumbers(int maxPagesToShow)
        {
            int startPage = Math.Max(1, CurrentPage - maxPagesToShow / 2);
            int endPage = Math.Min(TotalPages, startPage + maxPagesToShow - 1);

            return Enumerable.Range(startPage, endPage - startPage + 1);
        }
    }
}
