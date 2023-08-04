// Define a sample array
string[] names = new string[]
{
    "nakibul","rezwana","mahira","humaira","arham"
};
//the index operator provides access to the array
Console.WriteLine(names[0]);

// ^1 is the last item of the array --- end operator 
Console.WriteLine(names[^1] );

//range operator betten
var nameRangeBetween = names[1..4];
Console.WriteLine($"{string.Join(",", nameRangeBetween)}");

var nameRangeFromToLast = names[1..];
Console.WriteLine($"{string.Join(",", nameRangeFromToLast)}");

var nameRangeToLast = names[..5];
Console.WriteLine($"{string.Join(",", nameRangeToLast)}");

var nameRange = names[..];
Console.WriteLine($"{string.Join(",", nameRange)}");

//index in variable
var indexVariable = ^1;
Console.WriteLine(names[indexVariable]);

//range in variable
Range range = 1..3;
Console.WriteLine($"{string.Join(",", names[range])}");


//other example
var array = new int[] { 1, 2, 3, 4, 5 };
var slice1 = array[2..^3];    // array[new Range(2, new Index(3, fromEnd: true))]
Console.WriteLine($"{string.Join(",", slice1)}");

var slice2 = array[..^3];     // array[Range.EndAt(new Index(3, fromEnd: true))]
Console.WriteLine($"{string.Join(",", slice2)}");
