namespace CircularArray;

public class CaesarCipher
{
    private char[] _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    public string Encode(string text, int shift)
    {
        // TODO: Implement encoding logic here
        text = text.ToUpper();  // Convert to uppercase
        char[] chars = text.ToCharArray();

        for (int n = 0; n < chars.Length; n++)
        {
            for (int i = 0; i < _alphabet.Length; i++)
            {
                if (_alphabet[i] == chars[n])  // Find matching letter
                {
                    int newIndex = (i + shift) % _alphabet.Length; // Apply shift with wrap-around
                    chars[n] = _alphabet[newIndex]; // Replace with shifted letter
                    break; // Exit inner loop once match is found
                }
            }
        }
        return new string(chars); // Convert char array back to string
    }

    public string Decode(string text, int shift)
    {
        text = text.ToUpper();
        char[] chars = text.ToCharArray();
    
        for (int n = 0; n < chars.Length; n++)
        {
            for (int i = 0; i < _alphabet.Length; i++)
            {
                if (_alphabet[i] == chars[n])
                {
                    int newIndex = (i - shift + _alphabet.Length) % _alphabet.Length; // Reverse shift
                    chars[n] = _alphabet[newIndex];
                    break;
                }
            }
        }
        return new string(chars);
    }

}


