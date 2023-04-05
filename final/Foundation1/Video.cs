public class Video{
        public string _title;
        public string _author;
        public int _length;
        Comment comment = new Comment("Andres Soruco", "This song is the best");
        public List<Comment> _comments = new List<Comment>();
    public Video(){
    }
    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;

    }

    public void DisplayInformation(){
        Console.WriteLine($"{_title} by {_author} of {_length} seconds length");
        int numberOfComment = 1;
        for (int i = 0; i < _comments.Count(); i++){
            Console.WriteLine($"Comment number {numberOfComment + i}");
            _comments[i].DisplayComments();
        }
    }
    public void DisplayVideoInformation(){
        Console.WriteLine($"{_title} by {_author} of {_length} seconds length");
        }
}