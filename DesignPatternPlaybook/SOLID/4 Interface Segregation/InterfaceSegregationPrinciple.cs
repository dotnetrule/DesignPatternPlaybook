//Violation
//In programming, the interface segregation principle states that no client should be forced to depend on methods it does not use.
//Put more simply: Do not add additional functionality to an existing interface by adding new methods.
//Instead, create a new interface and let your class implement multiple interfaces if needed.
interface IPost
{
    void CreatePost();
}

interface IPostNew
{
    void CreatePost();
    void ReadPost();
}


//Solved
//If any class might need both the CreatePost() method and the ReadPost() method, it will implement both interfaces.
interface IPostCreate
{
    void CreatePost();
}

interface IPostRead
{
    void ReadPost();
}
