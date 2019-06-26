using System;

namespace ACM.bl.Source
{
    public class Customer
    {
       public string FirstName{get;set;}
       public string LastName{get;set;}
       public string FullName
       {
           get
           {
               return FirstName+", "+LastName;
           }
       }

       public int CustomerId{get;private set;}
    }
}
