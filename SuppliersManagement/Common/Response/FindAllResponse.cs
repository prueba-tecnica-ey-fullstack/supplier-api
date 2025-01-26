namespace SuppliersManagement.Common.Response
{
    public class FindAllResponse<T>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int FirstPage { get; set; }
        public int LastPage { get; set; }
        public IEnumerable<T> Data { get; set; } = [];
    }
}
