        
 // Liskov Substitution Principle
// To recognize bad code 'smells';
//TIPS:
//Tell, Don't Ask'
    //Don't interrogate object for their internals.
    //Tell the object what to do, dont ask and retrieve.


// Remember IS-SUBSTITUTABLE-FOR instead of a IS-A relationship



//The problem in inheritence

//  Rectangle   > 
//  Square  :   Rectangle
// Problem now occurs because expectation and calculation are not always clear.

//Violation
//In programming, the Liskov substitution principle states that if S is a subtype of T, then objects of type T may be replaced (or substituted) with objects of type S.
//This can be formulated mathematically as
// # Let ϕ(x) be a property provable about objects x of type T.
// # Then ϕ(y) should be true for objects y of type S, where S is a subtype of T.
//More generally it states that objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.
// Observe how the call of CreatePost() in the case of a subtype MentionPost won’t do what it is supposed to do; notify the user and override existing mention.
// Since the CreatePost() method is not overridden in MentionPost the CreatePost() call will simply be delegated upwards in the class hierarchy and call CreatePost() from its parent class
class Post
{
    void CreatePost(Database db, string postMessage)
    {
        db.Add(postMessage);
    }
}

class TagPost : Post
{
    override void CreatePost(Database db, string postMessage)
    {
        db.AddAsTag(postMessage);
    }
}

class MentionPost : Post
{
    void CreateMentionPost(Database db, string postMessage)
    {
        string user = postMessage.parseUser();

        db.NotifyUser(user);
        db.OverrideExistingMention(user, postMessage);
        base.CreatePost(db, postMessage);
    }
}

class PostHandler
{
    private database = new Database();

    void HandleNewPosts() {
        List<string> newPosts = database.getUnhandledPostsMessages();

        foreach (string postMessage in newPosts)
        {
            Post post;

            if (postMessage.StartsWith("#"))
            {
                post = new TagPost();
            }
            else if (postMessage.StartsWith("@"))
            {
                post = new MentionPost();
            }
            else {
                post = new Post();
            }

            post.CreatePost(database, postMessage);
        }
    }
}




//Solved
// By refactoring the MentionPost class such that we override the CreatePost() method rather than calling it on its base class, we no longer violate the Liskov substitution principle.
// This is but one simple example of how to correct a violation of this principle, however, this situation can manifest in a broad variety of ways, and is not always easy to identify.

class MentionPost : Post
{
    override void CreatePost(Database db, string postMessage)
    {
        string user = postMessage.parseUser();

        NotifyUser(user);
        OverrideExistingMention(user, postMessage)
        base.CreatePost(db, postMessage);
    }

    private void NotifyUser(string user)
    {
        db.NotifyUser(user);
    }

    private void OverrideExistingMention(string user, string postMessage)
    {
        db.OverrideExistingMention(_user, postMessage);
    }
}

