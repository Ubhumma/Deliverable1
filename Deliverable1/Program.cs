/*
 Build Specifications

-Soda starts with 100 in stock and will need a restock at 40

-Chips starts with 40 in stock and will need a restock at 20

-Candy starts with 60 in stock and will need a restock at 40

-Each item should have a variable that holds its current stock value and a variable that holds the restock value.

 */
using System.Net.Http.Headers;

int sodaStock = 100;
const int sodaRestock = 40;
int chipStock = 40;
const int chipRestock = 20;
int candyStock = 60;
const int candyRestock = 40;

//SODAS
Console.WriteLine("How many sodas have been sold today? " + sodaStock + " in stock.");
int sodaSold = int.Parse(Console.ReadLine());
if ((sodaSold <= sodaStock) && (sodaSold >= 0))
{
    
    Console.WriteLine("There are " + (sodaStock - sodaSold) + " chips left.");
    sodaStock -= sodaSold;
} else {
    Console.WriteLine("Invalid Value. Stock Not Adjusted.");
}

// CHIPS
Console.WriteLine("How many chips have been sold today? " + chipStock + " in stock.");

int chipSold = int.Parse(Console.ReadLine());

if (( chipSold <= chipStock) && (chipSold >= 0 )){
    
    Console.WriteLine("There are " + (chipStock - chipSold) + " chips left.");
    chipStock -= chipSold;
} else {
    Console.WriteLine("Invalid Value. Stock Not Adjusted.");
}

//CANDIES
Console.WriteLine("How much candy has been sold today? " + candyStock + " in stock.");

int candySold = int.Parse(Console.ReadLine());

if ((candySold <= candyStock) && (candySold >= 0))
{
    
    Console.WriteLine("There are " + (candyStock - candySold) + " candies left.");
    candyStock -= candySold;
} else {
    Console.WriteLine("Invalid Value. Stock Not Adjusted.");
}

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


Console.WriteLine("Thank you; According to what you entered:");
if (sodaStock <= sodaRestock)
{
    Console.WriteLine("Soda needs to be restocked");
}

if (chipStock <= chipRestock)
{
    Console.WriteLine("Chips need to be restocked");
}

if (candyStock <= candyRestock)
{
    Console.WriteLine("Candy needs to be restocked");
}










/*
 -Each item has a stock variable and a restock variable (6 total variables)
-Each items stock is successfully displayed in the console
-Ask the user to input a number and use that number to adjust soda’s stock. Assume the user will type a valid number.
-Ask the user to input a number and use that number to adjust chip’s stock. Assume the user will type a valid number.
-Ask the user to input a number and use that number to adjust candy’s stock. Assume the user will type a valid number.
-If the user enters a number higher than the current item’s stock, don’t adjust the stock number.
-After each input, the remaining stock of the current item is displayed
-Each if statement associated with restocked checks if stock is less than or equal to restock
-All restock conditions run independently of each other.
-Items that need to be restocked display on the console.

 */