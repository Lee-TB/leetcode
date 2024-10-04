export function dividePlayers(skill: number[]): number {
  const n = skill.length;
  const totalSkill = skill.reduce((acc, val) => acc + val, 0);

  if (totalSkill % (n / 2) !== 0) return -1; // if sum is indivisible for n/2 teams return -1

  const hashmap: { [key: number]: number } = {}; // use hashmap to count skill
  for (let i = 0; i < n; i++) {
    hashmap[skill[i]] = (hashmap[skill[i]] || 0) + 1;
  }

  const totalTeamSkill = totalSkill / (n / 2);

  let sumChemistry = 0;
  for (const playerSkill in hashmap) {
    while (hashmap[playerSkill] > 0) {
      hashmap[playerSkill] -= 1;
      const partnerSkill = totalTeamSkill - parseInt(playerSkill);

      if (!hashmap[partnerSkill] || hashmap[partnerSkill] === 0) {
        return -1; // cannot find partner that match with player
      }

      hashmap[partnerSkill] -= 1;
      sumChemistry += parseInt(playerSkill) * partnerSkill;
    }
  }

  return sumChemistry;
}

export function dividePlayers1(skill: number[]): number {
  const n = skill.length;
  const totalSkill = skill.reduce((acc, val) => acc + val, 0);

  if (totalSkill % (n / 2) !== 0) return -1; // if sum is indivisible for n/2 teams return -1

  const skillMap: Map<number, number> = new Map(); // use Map to count skill
  for (let i = 0; i < n; i++) {
    skillMap.set(skill[i], (skillMap.get(skill[i]) || 0) + 1);
  }

  const totalTeamSkill = totalSkill / (n / 2);

  let sumChemistry = 0;
  for (const [playerSkill] of skillMap) {
    while (skillMap.get(playerSkill)! > 0) {
      skillMap.set(playerSkill, skillMap.get(playerSkill)! - 1);
      const partnerSkill = totalTeamSkill - playerSkill;

      if (!skillMap.get(partnerSkill) || skillMap.get(partnerSkill)! === 0) {
        return -1; // cannot find partner that matches with player
      }

      skillMap.set(partnerSkill, skillMap.get(partnerSkill)! - 1);
      sumChemistry += playerSkill * partnerSkill;
    }
  }

  return sumChemistry;
}
