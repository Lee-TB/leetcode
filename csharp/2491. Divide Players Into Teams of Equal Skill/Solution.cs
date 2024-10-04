namespace _2491._Divide_Players_Into_Teams_of_Equal_Skilll;

public class Solution
{
    public long DividePlayers(int[] skill)
    {
        int n = skill.Length;
        int totalSkill = skill.Sum();

        if (totalSkill % (n / 2) != 0) return -1; // if sum is indivisible for n/2 teams return -1


        Dictionary<int, int> hashmap = new Dictionary<int, int>(); // use hashmap to count skill
        for (int i = 0; i < n; i++)
        {
            hashmap[skill[i]] = hashmap.GetValueOrDefault(skill[i], 0) + 1;
        }

        int totalTeamSkill = totalSkill / (n / 2);

        long sumChemistry = 0;
        foreach (int playerSkill in hashmap.Keys)
        {
            while (hashmap[playerSkill] > 0)
            {
                hashmap[playerSkill] -= 1;
                int partnerSkill = totalTeamSkill - playerSkill;

                if (hashmap.GetValueOrDefault(partnerSkill, 0) == 0)
                {
                    return -1; // cannot find other player that match with player
                }

                hashmap[partnerSkill] -= 1;
                sumChemistry += (playerSkill * partnerSkill);
            }
        }

        return sumChemistry;
    }
}