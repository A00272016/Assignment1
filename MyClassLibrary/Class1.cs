namespace UtilityLibraries;

   // [Route("[controller]/[action]")]
   // [ApiController]
    public static class MyClassLibrary
    {  
        public static string Add(decimal x = 5, decimal y = 2)
        {
            return $"Hello Reader.\nThe Addition of {x} and {y} is = {x + y}";
        }  
      
         public static string Subtract(decimal x = 5, decimal y = 2)
        {
            return $"Hello Reader.\nThe Subtraction of {x} and {y} is = {x - y}";
        }   
       
        public static string Multiply(decimal x = 5, decimal y = 2)
        {
            return $"Hello Reader.\nThe Multiplication of {x} and {y} is = {x * y}";
        } 
       
        public static string Divide(decimal x = 5, decimal y = 2)
        {
            if( y != 0) 
            {
                return $"Hello Reader.\nThe Division of {x} and {y} is = {x / y}";
            }
            else
            {
                return $"can not divided by 0";
            }

        } 
       
         public static string Modulo(decimal x = 5, decimal y = 2)
        {
            return $"Hello Reader.\nThe Remainder of {x} and {y} is = {x % y}";
        }   


       

    }