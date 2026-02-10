
// #region problem 1

//     /*1 - */

// System.Console.WriteLine("Problem 1:");
// double d = 9.99;
// int x = (int)d;
// Console.WriteLine(x);

// // result = 9  
// // because the decimal part is truncated when converting from double to int, leaving only the whole number part.
// #endregion

// #region problem 2
//     /*2 - */


// System.Console.WriteLine("Problem 2:");
// int n = 5;
// double d2 = n / 2.0;
// Console.WriteLine(d2);

// // result = 2.5


// #endregion



// #region problem 3
// /*3 - */

// System.Console.WriteLine("Problem 3:");
// while(true)
// {
//     Console.WriteLine("Enter your age: ");
// if(int.TryParse(Console.ReadLine(),out int age))
// {

//     Console.WriteLine($" Your Age is : {age}" );
//     break;
// }
// else
// {
//     Console.WriteLine("Invalid input. Please enter a valid integer.");
// }

// }

// #endregion


// #region problem 4

// /*4 - */

// System.Console.WriteLine("Problem 4:");
// string s = "12a";
// int y = int.Parse(s);
// Console.WriteLine(y);

// // this code will throw exception because there is a non-numeric character 
    
// #endregion


// #region problem 5


// /*5- */

// System.Console.WriteLine("Problem 5:");
// string s2 = "12a";
// if(int.TryParse(s2, out int result))
// {
//     Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine("Invalid input. Please enter a valid integer.");
// }

// #endregion


// #region problem 6

// System.Console.WriteLine("Problem 6:");
//     object o = 10;
// int a = (int)o;
// Console.WriteLine(a + 1);

// // result = 11 

// // the object O is assigned the value 10 as an integer and then it's cast back to an integer and stored in variable a. When we add 1 to a, it results in 11.
// #endregion

// #region problem 7
    
//     System.Console.WriteLine("Problem 7:");

//     object o = 10;
// long x = (long)o;
// Console.WriteLine(x);

// // will throw an invalid cast exception because the object O is assigned the valu 10 as an integer , and then we are tring to cast it to a long with out converting it to an int first.
// #endregion


  // #region problem 8
    // System.Console.WriteLine("Problem 8:");

    // object o = 10;
    // long x ;

    // try
    // {
    //     x = Convert.ToInt64(o);
    // }
    // catch 
    // {
    //     x=-1;
    // };
    // System.Console.WriteLine(x);
    // #endregion

//     #region problem 9
//     System.Console.WriteLine("Problem 9:");

//         string? name = null;
// Console.WriteLine(name?.Length);

// // it will print empty line because the null is accepted 
//     #endregion
