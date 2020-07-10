using System;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class mumbleController : ControllerBase
    {
        [HttpGet]
        public string Mumble(string input = "abcd")
        {
            var lowerCaseInput = input.ToLower();

            var finalAnswer = "";

            for (var index = 0; index < input.Length; index++)
            {
                var currentCharacter = lowerCaseInput[index];
                var newIndex = index + 1;
                var processedLetter = "";

                for (var count = 0; count < newIndex; count++)
                {
                    processedLetter += currentCharacter;

                }

                var uppercaseProcessedLetter = Char.ToUpper(processedLetter[0]) + processedLetter.Substring(1) + "-";

                finalAnswer += uppercaseProcessedLetter;

            }

            finalAnswer = finalAnswer.Trim(finalAnswer[finalAnswer.Length - 1]);

            return $"{finalAnswer}";
        }
    }
}