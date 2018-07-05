namespace Mediator
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            TestFirst();
            TestSecond();
        }

        /// <summary>
        /// The test second.
        /// </summary>
        private static void TestSecond()
        {
            Mediator mediator = new Mediator();
            FirstColleague firstColleague = new FirstColleague(mediator);
            LastColleague lastColleague = new LastColleague(mediator);
            mediator.FirstColleague = firstColleague;
            mediator.LastColleague = lastColleague;
            firstColleague.Send("How are you?");
            lastColleague.Send("Fine, thanks");

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test first.
        /// </summary>
        private static void TestFirst()
        {
            // Create chatroom
            Chatroom chatroom = new Chatroom();

            // Create participants and register them
            Participant george = new Beatle("George");
            Participant paul = new Beatle("Paul");
            Participant ringo = new Beatle("Ringo");
            Participant john = new Beatle("John");
            Participant yoko = new NonBeatle("Yoko");
            chatroom.Register(george);
            chatroom.Register(paul);
            chatroom.Register(ringo);
            chatroom.Register(john);
            chatroom.Register(yoko);

            // Chatting participants
            yoko.Send("John", "Hi John!");
            paul.Send("Ringo", "All you need is love");
            ringo.Send("George", "My sweet Lord");
            paul.Send("John", "Can't buy me love");
            john.Send("Yoko", "My sweet love");

            // Wait for user
            Console.ReadKey();
        }
    }
}