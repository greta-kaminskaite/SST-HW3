namespace SST_HW3
{
    public class MathService
    {
        public bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = number - 1; i >= 2; i--)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public bool IsPrimeNumber_Mutation1(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= number - 1; i++)  // Changed from i = number - 1
            {
                if (number % i == 0) return false;
            }
            //different loop structure, but logic remains the same
            return true;
        }

        public bool IsPrimeNumber_Mutation2(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            if (number % 1 == 0) return false; // Added this unnecessary condition

            for (int i = number - 1; i >= 2; i--)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public bool IsPrimeNumber_Mutation3(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return true; // Mutated to return true for all even numbers greater than 2

            for (int i = number - 1; i >= 2; i--)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public bool IsPrimeNumber_Mutation4(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = number - 1; i >= 2; i--)
            {
                if (number % i == 0) return true; // Changed return to true when divisible
            }

            return true;
        }

        public bool IsPrimeNumber_Mutation5(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = number + 1; i >= 2; i--)  // Changed the loop to start from number + 1
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        //Mutation testing results:
        // Number of mutants - 5
        // Number of killed mutants - 3
        // Mutation score = 3/5 = 60%
    }
}
