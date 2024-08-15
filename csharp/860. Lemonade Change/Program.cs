var sln = new Solution();
int[] bills = [5, 5, 5, 10, 20];
Console.WriteLine(sln.LemonadeChange(bills));
int[] bills2 = [5, 5, 10, 10, 20];
Console.WriteLine(sln.LemonadeChange(bills2));

public class Solution
{
    public bool LemonadeChange(int[] bills)
    {
        int fiveBill = 0;
        int tenBill = 0;
        foreach (var bill in bills)
        {
            if (bill == 5)
                fiveBill++;
            else if (bill == 10)
            {
                if (fiveBill >= 1)
                {
                    tenBill++;
                    fiveBill--;

                }
                else return false;
            }
            else
            {
                if (tenBill >= 1 && fiveBill >= 1)
                {
                    tenBill--;
                    fiveBill--;
                }
                else if (fiveBill >= 3)
                {
                    fiveBill -= 3;
                }
                else return false;
            }
        }
        return true;
    }
}