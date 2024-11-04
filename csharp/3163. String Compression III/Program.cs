using _3163._String_Compression_III;

Console.WriteLine("3163. String Compression III");
var sln = new Solution();
string word1 = "abcde";
var result1 = sln.CompressedString(word1);
Console.WriteLine("result 1: " + result1);

string word2 = "aaaaaaaaaaaaaabb";
var result2 = sln.CompressedString(word2);
Console.WriteLine("result 2: " + result2);