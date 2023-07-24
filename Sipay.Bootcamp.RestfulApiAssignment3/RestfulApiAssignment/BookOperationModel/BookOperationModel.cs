namespace RestfulApiAssignment.BookOperationModel
{
    public class BookOperationModel
    {
        public class UpdateBookInputModel
        {
            public string Title { get; set; }
            public string Author { get; set; }
        }

        public class BookOutputModel
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
        }
    }
}
