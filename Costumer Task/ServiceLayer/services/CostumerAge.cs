using DomainLayer.Models;
using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.services
{
    public class CostumerAge : ICostumerAge
    {
        public double GetAge(Costumer[] arr)
        {
            
            int count = 0;
            
            foreach (var item in arr)
            {
                if (item.Age>25&&item.Age<30)
                {
                    count++;
                    
                }
              

            }
         
            return count;
        }


        public double GetMiddleAge(Costumer[] arr)
        {
            double sum= 0;
            double count = 0;
            

            foreach (var item in arr)
            {
               sum=sum+item.Age;
                count++;
            }
            var result=sum/count;
            return result;
        }






    }
}
