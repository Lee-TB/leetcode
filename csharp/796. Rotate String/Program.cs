using _796._Rotate_String;

Console.WriteLine("796. Rotate String");
var sln = new Solution();
string s1 = "abcde", goal1 = "cdeab";
var res1 = sln.RotateString(s1, goal1);
Console.WriteLine("result 1: " + res1);

string s2 = "abcde", goal2 = "abced";
var res2 = sln.RotateString(s2, goal2);
Console.WriteLine("result 2: " + res2);