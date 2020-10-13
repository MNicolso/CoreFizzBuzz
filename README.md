# CoreFizzBuzz
CoreFizzBuzz is a Coder Foundry challenge done with the .net core framework. 
Basic function is to generate a range between two inputs and replace the charater of a string every inputed value.
## Installation
Libraries required:
 Bootstrap v4.3.1 [Here](https://getbootstrap.com/)
  jQuery JavaScript Library v3.5.1 [Here](https://jquery.com/)
## Usage
```C#
 var fizz = Convert.ToInt32(fizzInput);
            var buzz = Convert.ToInt32(buzzInput); //convert input
            var min = Convert.ToInt32(minInput);
            var max = Convert.ToInt32(maxInput);

            var result = new StringBuilder(); //build string

            for (int i = min; i < max; i++)
            {
                var fizzRemainder = (i % fizz);
                var buzzRemainder = (i % buzz); //loop remainders

                if (fizzRemainder == 0 && buzzRemainder == 0) //identify and repalce chars on string
                {
                    result.Append("FIZZBUZZ!");
                }
                else if (fizzRemainder == 0)
                {
                    result.AppendLine("FIZZ! ");
                }
                else if (buzzRemainder == 0)
                {
                    result.AppendLine("BUZZ!");
                }
                else
                {
                    result.AppendLine($"{i}");

                }
