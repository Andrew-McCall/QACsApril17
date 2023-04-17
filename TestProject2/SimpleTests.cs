using MathsLibrary;

namespace TestProject2
{
    public class SimpleTests // "Pascals case" EveryWordCapitalised
    {
        [Fact]
        public void CalculatorTests()
        {
            // Arrange  - Setup
            int c = 16346;
            int d = 23463;
            int expectedResult = c + d;

            // Act      - Excuting what we are testing
            int result = Calculator.Add(c, d);
       
            // Assert   - Checking
            Assert.Equal(expectedResult, result);

            /* 
            // What assert.equals does
            if (!expectedResult.Equals(d))
            {
                throw new Exception();
            }

            */

            // add, subtract, multiply, division
            // Assert the answers are correct

            Assert.Equal(c*d, Calculator.Multiply(c, d));
            Assert.Equal(c/d, Calculator.Divison(c, d));
            Assert.Equal(c+d, Calculator.Add(c, d));
            Assert.Equal(c-d, Calculator.Subtraction(c, d));
            Assert.Equal(c%d, Calculator.Modulo(c, d));


        }

        [Fact]
        public void Add_Two_Numbers() // Capital_With_Underscore
        {
            // Type Name Equal Value
            // int  a    =     2

            // var - compiler guesses the type
            // string  - Text - Array of Character
            // datetime, arrays, lists, points

            /// Primitive
            // char    - single character

            // bool    - True | False

            // int     - whole number (32bit)
            // long    - whole number (64bit)
            // byte    - raw bit integer

            // float   - Decimals
            // double  - Slightly more accurate
            // decimal - Most accurate

            int a = 2; 
            int b = 3;

            int c = 5;

            char x = 'X'; // "s are for strings, 's are for char

            c = a + b;

            c = c * 2; // multiply
            c *= 2;
            
            c = c - 2; // subtract
            c -= 2;

            c = c + 2; // addition
            c += 2;

            c = c / 2;// division
            c /= 2;

            // Bidmas is followed. chain them too
            // c = 53 + 53/2 - 634 * 53 /3523 + 52

            Assert.Equal(c, a+b);
        }

        [Fact]
        public void Add_Two_Strings()
        {
            string a = "Hello";
            string b = "World!";

            string c = a + ", " + b;
            string d = $"{a}, {b}";
            string e = String.Format("{0}, {1}", a, b);

            /* // What Asert.Equal is doing
            if (c != "Hello, World!")
            {
                throw new Exception();
            } 
            */

            // to compare strings
            // string1.Equals(string2);

            Assert.Equal(c, "Hello, World!");
            Assert.Equal(c, d);
            Assert.Equal(d, e);
        }

    }
}