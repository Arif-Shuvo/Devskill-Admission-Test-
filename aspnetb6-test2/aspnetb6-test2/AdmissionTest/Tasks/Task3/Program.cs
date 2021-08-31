using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var alert = new Alert();
            // Attach a method with alert, to be called by alert when it is raised
            alert.Raise("Fire in the room");
        }
    }
}
