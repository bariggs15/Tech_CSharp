# C# Projects

## Projects 

* [Car-Insurance](#car-insurance) 
* [Twenty-One-Card-Game](#twenty-one-card-game)
* [Daily-Reports](#daily-reports)


### Car Insurance
This project involves combining databases utilizing SQL Server Management Studios with Visual Studios to create a web application with a list of if statements that returned a car insurance quote. This was written with MVC framework and below is an example of some of the CSHTML code involved in this project:

    @model IEnumerable<CarInsurance.Models.Insuree>

    @{
        ViewBag.Title = "Index";
    }

    <h2>Index</h2>

    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.FirstName)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.LastName)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.EmailAddress)
            </th>

            <th>
                @Html.DisplayNameFor(model => model.Quote)
            </th>
            <th></th>
        </tr>

    @foreach (var item in Model) {
        <tr>
            <td>
                @Html.DisplayFor(modelItem => item.FirstName)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.LastName)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.EmailAddress)
            </td>

            <td>
                @Html.DisplayFor(modelItem => item.Quote)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", new { id=item.Id }) |
                @Html.ActionLink("Details", "Details", new { id=item.Id }) |
                @Html.ActionLink("Delete", "Delete", new { id=item.Id })
            </td>
        </tr>
    }

    </table>



### Twenty One Card Game
This console application involved combining many techniques including loops, enums, inheritance, lambda statement, operators, overloading methods, iterations, etc. to play the game of twenty one. This is a snippet of code that is just one of the classes involved:

    namespace Casino.TwentyOne
    {
        public class TwentyOneGame : Game, IWalkAway
        {
            public TwentyOneDealer Dealer { get; set; }

            public override void Play()
            {
                Dealer = new TwentyOneDealer();
                foreach (Player player in Players)
                {
                    player.Hand = new List<Card>();
                    player.Stay = false;
                }
                Dealer.Hand = new List<Card>();
                Dealer.Stay = false;
                Dealer.Deck = new Deck();
                Dealer.Deck.Shuffle();


### Daily Reports
This console app take in various responses from the user and converts variables to give daily feedback of progress in the program. Is is a basic example of code that interacts with the user:

     static void Main()
          {
              Console.WriteLine("The Tech Academy (Press Enter to continue)");
              Console.ReadLine();
              Console.WriteLine("Student Daily Report");
              Console.ReadLine();

              //ask for name
              Console.WriteLine("What is your name?");
              String name = Console.ReadLine();
              Console.WriteLine("Hello " + name);
              Console.ReadLine();

              //what course are you on
              Console.WriteLine("What course are you on?");
              String course = Console.ReadLine();
              Console.WriteLine(course + " is a good course");
              Console.ReadLine();

              //what page number are you on
              Console.WriteLine("What page number are you on?");
              String pageNumber = Console.ReadLine();
              int page = Convert.ToInt32(pageNumber);
              Console.WriteLine(page + " is a good start!");
              Console.ReadLine();


