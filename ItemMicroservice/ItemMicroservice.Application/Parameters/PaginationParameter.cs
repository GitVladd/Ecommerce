
namespace ItemMicroservice.Application.Parameters
{
    public class PaginationParameter
    {
        private int _pageNumber = 1;
        public int PageNumber {
            get { return _pageNumber; } 
            set { 
                if (value < 0) throw new ArgumentOutOfRangeException("PageNumber must be greater than 0");
                _pageNumber = value;
            }
        }

        private int _pageSize = int.MaxValue;

        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("PageSize must be greater than 0");
                _pageNumber = value;
            }
        }
    }
}
