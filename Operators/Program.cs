// See https://aka.ms/new-console-template for more information

using static System.Console;

Write("Enter your age: ");
var userAge = Convert.ToInt32(ReadLine());

// Length of years on Jupiter (in Earth years)
const double jupiterYears = 11.86;


// Age on Jupiter
var jupiterAge  = userAge / jupiterYears;

// Time to Jupiter
const double journeyToJupiter = 6.142466;

// New Age on Earth
var newEarthAge = userAge + journeyToJupiter;

// New Age on Jupiter
var newJupiterAge = newEarthAge / jupiterYears;

// Log calculations to console
WriteLine($"Age on Earth: {userAge} years");
WriteLine($"Age on Jupiter: {jupiterAge} years");
WriteLine("After journey to Jupiter!");
WriteLine($"Age on Earth: {newEarthAge} years");
WriteLine($"Age on Jupiter: {newJupiterAge} years");