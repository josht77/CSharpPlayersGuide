// See https://aka.ms/new-console-template for more information
PasswordValidator passwordValidator = new PasswordValidator();
string password;
while (true)
{
    Console.WriteLine("Enter a password: ");
    password = Console.ReadLine()!;
    if (passwordValidator.validateInput(password))
    {
        Console.WriteLine("That password is valid.");
    }
    else
    {
        Console.WriteLine("That password is not valid.");
    }
}
public class PasswordValidator
{
    private int _password() { get; set; }
    private int HasNum() { get; set; }
    private int HasUpper() { get; set; }
    private int HasLower() { get; set; }

    public PasswordValidator()
    {
    }
    public bool validateInput(string password)
    {

        foreach (char letter in password)
        {
            if (char.IsDigit(letter))
            {
                HasNum++;
            }
            if (char.IsUpper(letter))
            {
                HasUpper++;
            }
            if (char.IsLower(letter))
            {
                HasLower++;
            }
            if (char.Equals('T') || char.Equals('&'))
            {
                return false;
            }
            return password.Length >= 6 && password.Length <= 13 && HasNum && HasUpper && HasLower;
        }
//         private bool IsDigit(string password){
//             foreach (char letter in password)
//         {
//             if (char.IsDigit(letter))
//             {
//                 return true;
//             }
//             return false;
//         }
// }
    }
}


