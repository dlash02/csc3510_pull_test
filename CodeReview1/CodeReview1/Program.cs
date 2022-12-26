// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class PassChecker {

    string pw;
    public PassChecker(string pw) {
        this.pw = pw;
    }
    public Boolean pwCheck(string pw) {
        // Valid password 
        // 1. Cannot be one of these valid words:
        //        password,pword,pass,password1234,qwerty
        // 2. Must contain a capital letter
        // 3 Must be at least 8 characters
        // 4. Must contain one of these special characters: *&$!(
        //
        return true;

    }
}