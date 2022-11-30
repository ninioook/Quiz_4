// 1. Დაწერეთ პროგრამა რომელიც მასივში დაითვლის თითოეული  ელემენტი რამდენჯერ გვხვდება.

List<int> number = new List<int> { 1, 3, 5, 6, 2, 3, 5, 1, 6, 7, 8, 8, 7, 3, 1, 5, 2 };

var frequency = number.GroupBy(x => x);
foreach (var x in frequency)
{
    Console.WriteLine($"{x.Key} : {x.Count()} times");
}

//2. Დაწერეთ პროგრამა რომელიც დაითვლის სტრინგში თითოეული სიმბოლო რამდენჯერ გვხვდება.

var str = Console.ReadLine();
var freq = str.GroupBy(x => x);
foreach (var x in freq)
{
    Console.WriteLine($"{x.Key} : {x.Count()} times");
}

//3.Დაწერეთ პროგრამა რომელიც სტრინგში (წინადადებაში იპოვნის uppercase-იან სიტყვბს და დაბეჭდავს მათ)

var strng = Console.ReadLine();
var upper = FilterWords(strng);
foreach (var s in upper)
{
    Console.WriteLine(s);
}


static IEnumerable<string> FilterWords(string s)
{
    var upper = s.Split(' ')
                .Where(x => String.Equals(x, x.ToUpper(),
                            StringComparison.Ordinal));

    return upper;

}

//4.Დაწერეთ პროგრამა რომელიც დააბრუნებს მასივში x-დან y შუალედში ელემენტებს.

var numb = new List<int> { 1, 3, 4, 12, 23, 52, 42, 34, 24, 17 };
var numbrs = numb.Where(n => n > 1 && n < 30);

// 5 Დაწერეთ პროგრამა რომელიც დაბეჭდავს სტრინგში ყველაზე განმეორებად სიმბოლოს.

var strn = Console.ReadLine();
var mostFrequentCharacter = strn.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;

Console.WriteLine(mostFrequentCharacter);