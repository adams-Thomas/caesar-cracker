// See https://aka.ms/new-console-template for more information
Console.WriteLine("Runing basic Caesar Cipher Cracker");
Console.Write("Enter the string to crack: ");

String cipher = (Console.ReadLine() ?? "").ToLower();
String alphabet = "abcdefghijklmnopqrstuvwxyz";

Console.WriteLine("Please select one (select number):");
Console.WriteLine("1 - Shift backwards [cefault]");
Console.WriteLine("2 - Shift forwards");
Console.WriteLine("3 - Try both ways");
String shift_option = Console.ReadLine() ?? "1";

switch(shift_option) {
	default:
	case "1":
		shift_backwards();
		break;

	case "2":
		shift_forwards();
		break;

	case "3":
	both_shifts();
		break;
}

void shift_backwards() {
	string new_cipher = "";
	for (int i = 0; i < 26; i++) {
		new_cipher = "";
		for (int k = 0; k < cipher.Length; k++) {
			if (cipher[k] == ' ') {
				new_cipher += " ";
				continue;
			}
			int alphabet_index = alphabet.IndexOf(cipher[k]);
			int original_index = alphabet_index - i;

			if (original_index < 0) {
				original_index = alphabet.Length + original_index;
			}

			new_cipher += alphabet[original_index];
		}

		Console.WriteLine($"{i} -- {new_cipher}");
	}
}

void shift_forwards() {
	string new_cipher = "";
	for (int i = 0; i < 26; i++) {
		new_cipher = "";
		for (int k = 0; k < cipher.Length; k++) {
			if (cipher[k] == ' ') {
				new_cipher += " ";
				continue;

			}
			int alphabet_index = alphabet.IndexOf(cipher[k]);
			int original_index = alphabet_index + i;

			if (original_index >= alphabet.Length) {
				original_index = original_index - alphabet.Length;
			}

			new_cipher += alphabet[original_index];
		}

		Console.WriteLine($"{i} -- {new_cipher}");
	}
}

void both_shifts() {
	Console.WriteLine("Shifting Backward");
	Console.WriteLine("===================================================");
	shift_backwards();
	Console.WriteLine("Shifting Forward");
	Console.WriteLine("===================================================");
	shift_forwards();
}
