using System;

namespace Hometask3
{
    class NumberCheck
    {
        private int number;

        private string messValid
        {
            get
            {
                return $"Congratulations, you have entered {number}!\n";
            }
        }

        private string messFail = "You have entered the invalid value!\n";
        private string mess11   = "Great choice! 11 is the miles per hours that the fastest moving land snake, the Black Mamba, can move.\n";
        private string mess22   = "Awesome!22 is the number of stars in the Paramount Films logo.\n";
        private string mess67   = "Hey! I bet you know that 67 is the number of counties in Florida?\n";
        private string messEven = "That is even number, by the way.\n";

        private string UserInput
        {
            get
            {
                return Console.ReadLine();
            }
        }

        public string ValidateNumber()
        {
            var result = "";

            if (int.TryParse(UserInput, out number))
            {
                if ((number >= 0) && (number <= 100))
                {
                    result += messValid;
                    result += CheckEven();
                    result += CheckSpecialNums();
                }
                else
                    result += messFail;
            }
            else
                result += messFail;

            return result;
        }

        private string CheckSpecialNums()
        {
            switch (number)
            {
                case 11:
                    return mess11;
                case 22:
                    return mess22;
                case 67:
                    return mess67;
                default:
                    return "";
            }
        }

        private string CheckEven() 
            => (number % 2 == 0) ? messEven : "";

    }
}
