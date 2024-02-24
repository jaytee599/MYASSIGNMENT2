using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASSIGNMENT2.Controllers
{
    [Route("api/[controller]")]
    public class J2Controller : Controller
        {
            // GET: api/<RollTheDice_J2>
            [HttpGet]
            [Route("api/J2/DiceGame/{m}/{n}")]
            public string Get(int m, int n)
            {
                // Calculate minimum and maximum possible values for the first die
                int min1 = Math.Max(1, 10 - n);
                int max1 = Math.Min(m, 9);

                // Calculate total pairs by subtracting lower possible sum from upper possible sum + 1
                int count = max1 - min1 + 1;

                // Check if count is valid (avoid negative results)
                if (count < 0)
                {
                    // Handle invalid input (m and n too small for sum of 10)
                    return "There are no possible ways to get a sum of 10 with these limits.";
                }

                // Build user-friendly message
                string totalString = $"With these limits, there are {count} ways to roll the dice and get a sum of 10.";
                return totalString;
            }

        }


    }
       
       
       

