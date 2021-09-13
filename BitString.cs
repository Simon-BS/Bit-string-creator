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
        private int _numberOfBits;
        public int NumberOfBits { get => _numberOfBits;
            set
            {
                if (_numberOfBits != value)
                {
                    _numberOfBits = value >= 1 || value <= 31 ? value : 1;
                    _createBitString();
                }
            }
        }
        public string String { get; private set; }

        public BitString()
        {
            _number = 0;
            _numberOfBits = 8;
            String = "00000000";
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
