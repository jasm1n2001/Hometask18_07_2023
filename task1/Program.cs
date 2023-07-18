var post1 = new Post()
{
    Title = "Post 1",
    Description = "This is test post",
    DateTime = new DateTime(2023,07,18),

    
};
  
  post1.Comment("this is superb post");

  post1.Like();
  System.Console.WriteLine("NUmber of likes {post1.LikeCount}");

  foreach (var comment in post1.Comments)
  {
    System.Console.WriteLine("comment : "+ comment);
  }