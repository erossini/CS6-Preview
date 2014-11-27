using System.Diagnostics.Debug;

namespace CSharp6Preview
{
    class StaticUsingStatement
    {
        public StaticUsingStatement()
        {
            // Where did this WriteLine method come from?
            // Take a look at the using statement at the top of the file!
            WriteLine("Some debug info");
        }
    }
}
