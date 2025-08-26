Console.Clear();
Console.WriteLine("Hello, World!");

string aFriend = "Traci";
Console.WriteLine(aFriend);

aFriend = "Larry";
Console.WriteLine(aFriend);
Console.WriteLine("Hello " + aFriend);
Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Mike";
string secondFriend = "Bryant";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

string greeting = "       Hello World!     ";
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));