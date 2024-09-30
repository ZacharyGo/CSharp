namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string select = "EventsChained";
            switch (select)
            {
                case "DelegatesBasic":
                    DelegatesBasic delegatesBasic = new DelegatesBasic();
                    delegatesBasic.Execute();
                    break;
                case "DelegatesAnonymous":
                    DelegatesAnonymous delegatesAnonymous = new DelegatesAnonymous();
                    delegatesAnonymous.Execute();
                    break;
                case "DelegatesComposable":
                    DelegatesComposable delegatesComposable = new DelegatesComposable();
                    delegatesComposable.Execute();
                    break;
                case "DelegatesComposable2":
                    DelegatesComposable2 delegatesComposable2 = new DelegatesComposable2();
                    delegatesComposable2.Execute();
                    break;
                case "EventsBasic":
                    EventsBasic eventsBasic = new EventsBasic();
                    eventsBasic.Execute();
                    break;
                case "EventsChained":
                    EventsChained eventsChained = new EventsChained();
                    eventsChained.Execute();
                    break;
            }

        }
    }
}
