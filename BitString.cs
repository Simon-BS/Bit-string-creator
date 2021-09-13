    public class BitString
    {
        private int _number;
        public int Number {
            get => _number;
            set {
                if (_number != value)
                {
                    _number = value;
                    _createBitString();
                }
            }
        }
        public int NumberOfBits { get; set; }
        public string String { get; private set; }

        public BitString()
        {
            Number = 0;
            NumberOfBits = 8;
            String = "";
        }
        private void _createBitString()
        {
            string s = "";
            int limit = 1, number = Number;
            for (int _ = 0; _ < NumberOfBits-1; _++)
                limit *= 2;

            for (int i = 0; i < NumberOfBits; i++)
            {
                if (number >= limit)
                {
                    s += "1";
                    number -= limit;
                }
                else
                    s += "0";
                limit /= 2;
            }
            String = s;
        }
    }
