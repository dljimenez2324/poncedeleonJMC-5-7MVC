using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace poncedeleonJMC_5_7MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class multiEndPoint : ControllerBase
    {
        [HttpGet("/madLib")]
        public string madLib(string adj1 = "sticky", string adj2 = "wet", string adj3 = "old", string nounAnimal = "dog", string nounPlural = "everyone", string nounPlace = "town", string adj4 = "sticky"){
            return $"There was a {adj1} {adj2} {adj3} {nounAnimal} who would get pets from {nounPlural} around {nounPlace} before sadly one day, he was not {adj4} anymore.";
        }

        [HttpGet("/OddOrEven")]
        public string oddOrEven(int a = 1){
            string result;
            if(a%2 == 1){
                result = "odd";
            }
            else{
                result = "even";
            }
            return $"Your number is {result}.";
        }

        [HttpGet("/reverseAll")]
        public string reverseAll(string reverseIt = "ABRACADABRA54321"){
            char[] charArray = reverseIt.ToCharArray();
            Array.Reverse(charArray);
            reverseIt = new string(charArray);
            return $"Your string reversed is {reverseIt}";
        }

        [HttpGet("/reverseNumbers")]
        public int reverseNumbers(int reverseNum = 123){
            int reversal = 0;   
            int remainder = 0;
            while( reverseNum > 0){
                remainder = reverseNum %10;
                reverseNum = reverseNum/10;
                reversal = (reversal*10) + remainder;
            }
                return reversal;
            
        }
    }
}