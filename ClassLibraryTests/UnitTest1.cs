using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;
namespace UnitTestProject;
[TestClass]
public class UnitTest1
{
    //Testing for ADD Function

    [TestMethod]
     public void Add_WhenCalledWithTwoPositiveNumbers_ReturnsSum()
    {      
         
        decimal x = 5;
        decimal y = 2;
        decimal expectedSum = x + y;       
        string result = UtilityLibraries.MyClassLibrary.Add(x, y);       
        Assert.AreEqual($"Hello Reader.\nThe Addition of {x} and {y} is = {expectedSum}", result);
    }

    [TestMethod]
    public void Add_WhenCalledWithNegativeAndPositiveNumbers_ReturnsSum()
    {
        decimal x = 5;
        decimal y = -2;
        decimal expectedSum = x + y;       
        string result = UtilityLibraries.MyClassLibrary.Add(x, y);       
        Assert.AreEqual($"Hello Reader.\nThe Addition of {x} and {y} is = {expectedSum}", result);
    }

    [TestMethod]
    public void Add_WhenCalledWithTwoNegativeNumbers_ReturnsSum()
    {
        decimal x = -5;
        decimal y = -2;
        decimal expectedSum = x + y;       
        string result = UtilityLibraries.MyClassLibrary.Add(x, y);       
        Assert.AreEqual($"Hello Reader.\nThe Addition of {x} and {y} is = {expectedSum}", result);
    }

    [TestMethod]
    public void Add_WhenCalledWithZero_ReturnsOtherNumber()
    {
        decimal x = 5;
        decimal y = 0;              
        string result = UtilityLibraries.MyClassLibrary.Add(x, y);       
       Assert.AreEqual($"Hello Reader.\nThe Addition of {x} and {y} is = {x}", result);
    }

    [TestMethod]
    public void Add_WhenCalledWithTwoZeros_ReturnsZero()
    {
        
        decimal x = 0;
        decimal y = 0;
        string result = UtilityLibraries.MyClassLibrary.Add(x, y);
        Assert.AreEqual($"Hello Reader.\nThe Addition of {x} and {y} is = 0", result);
    }


    //Testing for Subract Function
    [TestMethod]    
    public void Subtract_TwoPositiveNumbers_ReturnsDifference()
    {    
        decimal x = 8;
        decimal y = 3;
        decimal expectedDifference = x - y;
        string result = UtilityLibraries.MyClassLibrary.Subtract(x, y);
        Assert.AreEqual($"Hello Reader.\nThe Subtraction of {x} and {y} is = {expectedDifference}", result);
    }
    [TestMethod] 
    public void Subtract_ZeroFromPositiveNumber_ReturnsPositiveNumber()
    {    
         decimal x = 10;
         decimal y = 0;   
         string result = UtilityLibraries.MyClassLibrary.Subtract(x, y);   
         Assert.AreEqual($"Hello Reader.\nThe Subtraction of {x} and {y} is = {x}", result);
    }
    [TestMethod] 
    public void Subtract_PositiveNumberFromZero_ReturnsNegativeNumber()
    {

        decimal x = 0;
        decimal y = 7;
        string result = UtilityLibraries.MyClassLibrary.Subtract(x, y); 
        Assert.AreEqual($"Hello Reader.\nThe Subtraction of {x} and {y} is = -{y}", result);
    }
    [TestMethod] 
    public void Subtract_TwoNegativeNumbers_ReturnsNegativeDifference()
    {
   
        decimal x = -5;
        decimal y = -3;
        decimal expectedDifference = x - y;   
        string result = UtilityLibraries.MyClassLibrary.Subtract(x, y);   
        Assert.AreEqual($"Hello Reader.\nThe Subtraction of {x} and {y} is = {expectedDifference}", result);
    }
    [TestMethod] 
    public void Subtract_PositiveNumberFromNegativeNumber_ReturnsNegativeDifference()
    {    
        decimal x = -8;
        decimal y = 3;
        decimal expectedDifference = x - y;    
        string result = UtilityLibraries.MyClassLibrary.Subtract(x, y);  
        Assert.AreEqual($"Hello Reader.\nThe Subtraction of {x} and {y} is = {expectedDifference}", result);
    }

    //Testing for Multipy Function
     [TestMethod]
    public void Multiply_TwoPositiveNumbers_ReturnsProduct()
    {       
        decimal x = 5;
        decimal y = 3;
        decimal expectedProduct = x * y;      
        string result = UtilityLibraries.MyClassLibrary.Multiply(x, y);       
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of {x} and {y} is = {expectedProduct}", result);
    }

    [TestMethod]
    public void Multiply_PositiveNumberByZero_ReturnsZero()
    {       
        decimal number = 10;       
        string result = UtilityLibraries.MyClassLibrary.Multiply(number, 0);       
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of {number} and 0 is = 0", result);
    }

    [TestMethod]
    public void Multiply_TwoNegativeNumbers_ReturnsProduct()
    {       
        decimal x = -4;
        decimal y = -2;
        decimal expectedProduct = x * y;    
        string result = UtilityLibraries.MyClassLibrary.Multiply(x, y);    
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of {x} and {y} is = {expectedProduct}", result);
    }

    [TestMethod]
    public void Multiply_PositiveNumberByOne_ReturnsSameNumber()
    {       
        decimal number = 20;     
        string result = UtilityLibraries.MyClassLibrary.Multiply(number, 1);      
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of {number} and 1 is = {number}", result);
    }

    [TestMethod]
    public void Multiply_ZeroByAnyNumber_ReturnsZero()
    {       
        decimal number = 30;  
        string result = UtilityLibraries.MyClassLibrary.Multiply(0, number); 
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of 0 and {number} is = 0", result);
    }

    
    //Testing for Division Function

    [TestMethod]
    public void Divide_TwoPositiveNumbers_ReturnsQuotientString()
    {        
        decimal x = 15;
        decimal y = 3;        
        string result = UtilityLibraries.MyClassLibrary.Divide(x, y);        
        Assert.AreEqual($"Hello Reader.\nThe Division of {x} and {y} is = {x / y}", result);
    }

    [TestMethod]
    public void Divide_PositiveNumberByOne_ReturnsSameNumberString()
    {        
        decimal number = 20;       
        string result = UtilityLibraries.MyClassLibrary.Divide(number, 1);       
        Assert.AreEqual($"Hello Reader.\nThe Division of {number} and 1 is = {number}", result);
    }

    [TestMethod]
    public void Divide_AnyNumberByZero()
    {       
        decimal number = 30;   
        string result = UtilityLibraries.MyClassLibrary.Divide(number, 0);
        Assert.AreEqual("can not divided by 0", result);
    }

    [TestMethod]
     public void Divide_ZeroByAnyNumber_ReturnsZeroString()
    {      
        decimal number = 40;     
        string result = UtilityLibraries.MyClassLibrary.Divide(0, number);       
        Assert.AreEqual($"Hello Reader.\nThe Division of 0 and {number} is = 0", result);
    }
   
   [TestMethod]
    public void Divide_PositiveNumberByZero_ReturnsErrorMessage()
    {        
        decimal number = 50;      
        string result = UtilityLibraries.MyClassLibrary.Divide(number, 0);
        Assert.AreEqual("can not divided by 0", result);
    }

}