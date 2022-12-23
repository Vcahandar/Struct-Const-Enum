using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CalculateService : ICalculateService
    {
       

        public int Calculate(int[] arr)
        {
            int result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 20 && arr[i]>1)
                {
                    result = arr[i] * result;

                }
            }
            return result;
    
        }
    
        public double GetCalcul(int[]arr)
        {
            int sum = 0;            
            for (int i = 0; i < arr.Length ; i++)
            {
                if (arr[i]%2==0)
                {
                    sum += arr[i];
                }
            }
            double result= Math.Pow(sum, 2);

            return result;
           
        }

       
    }

}
