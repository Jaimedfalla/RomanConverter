namespace ConversorRomanos
{
    public static class Converter
    {
        private static readonly Dictionary<int, char> _romanos = new Dictionary<int, char>() {
        {
            1,'I'
        },
        {
            5,'V'
        },
        {
            10,'X'
        },
        {
            50,'L'
        },
        {
            100,'C'
        },
        {
            500,'D'
        },
        {
            1000,'M'
        }
    };

        public static void ConvertNumber(int number, ref string converted, int potencia = 1)
        {
            if (number == 0) return;

            double valorPotencia = Math.Pow(10, potencia - 1);
            int cociente = (int)(number / Math.Pow(10, potencia));
            double residuo = number % Math.Pow(10, potencia);

            if (residuo != 0)
            {
                if (!_romanos.ContainsKey((int)residuo))
                {
                    var units = _romanos[(int)Math.Pow(10, potencia - 1)];
                    var menor = _romanos.LastOrDefault(c => c.Key <= residuo && c.Key >= valorPotencia);
                    var mayor = _romanos.FirstOrDefault(c => c.Key >= residuo && c.Key >= valorPotencia);

                    int difference = (int)((mayor.Key - residuo) / valorPotencia);
                    if (difference > 1)
                    {
                        difference = (int)((residuo - menor.Key) / valorPotencia);
                        converted = $"{menor.Value}{"".PadRight(difference, units)}{converted}";
                    }
                    else
                        converted = $"{units}{mayor.Value}{converted}";
                }
                else
                {
                    ; converted = $"{_romanos[(int)residuo]}{converted}";
                }
            }

            potencia++;
            ConvertNumber(number - (int)residuo, ref converted, potencia);
        }
    }
}
