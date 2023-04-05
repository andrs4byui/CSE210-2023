public class Comment{
        public string _personName;
        public string _commentText;
    public Comment(){
        _personName = "";
        _commentText = "";
    }
    public Comment(string personName, string commentText){
        _personName = personName;
        _commentText = commentText;
    }
    public void DisplayComments(){
        Console.WriteLine($"{_personName} commented:");
        Console.WriteLine($"{_commentText}");
    }
}