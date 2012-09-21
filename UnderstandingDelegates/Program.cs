using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jon = new Person("Jon");
            Person derek = new Person("Derek");

            StringParser jonVoice = new StringParser(jon.Say);
            StringParser derekVoice = new StringParser(derek.Say);
            StringParser backgroundMessage = new StringParser(BackgroundMessage.Show);

            jonVoice("Hello, Derek! How are you?");
            derekVoice.Invoke("I am fine, Jon. Thanks for asking.");
            backgroundMessage("and happiness was in the air");
        }
    }

    public delegate void StringParser(string message);
}
