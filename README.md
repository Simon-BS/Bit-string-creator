# Bit-string-creator
Creates a bit string from a number

Use this library by creating an instance of the class BitString.
By setting a number to convert, the .String will contain the bit string
You can also set .NumberOfBits in order to use larger or smaller bit strings

            BitString bs = new();
            bs.Number = 129;
            Console.WriteLine(bs.String);
