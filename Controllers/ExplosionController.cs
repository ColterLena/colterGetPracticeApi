using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class explosionController : ControllerBase
    {
        [HttpGet]
        public string Explode(string input = "1234")
        {

            var newInput = input.Select(number => $"{number}").ToList();
            var finalAnswer = "";

            for (var index = 0; index < newInput.Count; index++)
            {

                for (var count = 0; count < int.Parse(newInput[index]); count++)
                {
                    finalAnswer += newInput[index];
                }

            }

            return $"{finalAnswer}";

        }

    }

}