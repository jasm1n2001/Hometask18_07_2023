public class Post
{
    public string Title;
    public string Description;
    public DateTime DateTime;
    public int LikeCount = 0;
    public List<string> Comments;

    public void Like()
    {
        LikeCount++;
    }

    public void Publish()
    {
        Console.WriteLine("Your post is publishing ... 40");
        Console.WriteLine("Your post is publishing ... 50");
        Console.WriteLine("Your post is publishing ... 60");
        Console.WriteLine("Your post is publishing ... 100");
        System.Console.WriteLine("Your post has been published");


    }

    public void Comment(string text)
    {
        if(Comments == null) Comments = new List<string>();

        Comments.Add(text);
    }
}