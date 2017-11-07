using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowPost
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("C# Classes", "Demonstrate encapsulation in C#");

            post.VoteUp();
            post.VoteUp();
            post.VoteUp();

            post.VoteDown();

            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.Vote);
            Console.WriteLine(post.CreatedDateTime);

        }
    }
}
