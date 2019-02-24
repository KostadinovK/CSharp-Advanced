using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Heroes
{
    public class HeroRepository
    {
        private Dictionary<string, Hero> data;

        public int Count => data.Count;

        public HeroRepository()
        {
            data = new Dictionary<string, Hero>();
        }

        public void Add(Hero hero)
        {
            if (!data.ContainsKey(hero.Name))
            {
                data[hero.Name] = hero;
            }
        }

        public void Remove(string name)
        {
            if (data.ContainsKey(name))
            {
                data.Remove(name);
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            int highestStrength = -1;
            Hero h = null;

            foreach (var kvp in data)
            {
                if (kvp.Value.Item.Strength > highestStrength)
                {
                    highestStrength = kvp.Value.Item.Strength;
                    h = kvp.Value;
                }
            }

            return h;
        }

        public Hero GetHeroWithHighestAbility()
        {
            int highestAbility = -1;
            Hero h = null;

            foreach (var kvp in data)
            {
                if (kvp.Value.Item.Ability > highestAbility)
                {
                    highestAbility = kvp.Value.Item.Ability;
                    h = kvp.Value;
                }
            }

            return h;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            int highestIntelligence = -1;
            Hero h = null;

            foreach (var kvp in data)
            {
                if (kvp.Value.Item.Intelligence > highestIntelligence)
                {
                    highestIntelligence = kvp.Value.Item.Intelligence;
                    h = kvp.Value;
                }
            }

            return h;
        }

        public override string ToString()
        {
            string res = "";

            foreach (var kvp in data)
            {
                res += kvp.Value.ToString();
                res += "\n";
            }

            res.TrimEnd('\n');

            return res;
        }
    }
}
