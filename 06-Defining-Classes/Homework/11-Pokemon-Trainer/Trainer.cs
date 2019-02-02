using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Trainer
{
    public string Name { get; set; }

    public int Badges { get; set; }

    public List<Pokemon> Pokemon { get; set; }

    public Trainer(string name)
    {
        Name = name;
        Badges = 0;
        Pokemon = new List<Pokemon>();
    }

    public void CheckPokemonToBeAnElement(string element)
    {
        if (Pokemon.Where(x => x.Element == element).ToList().Count >= 1)
        {
            Badges++;
        }
        else
        {
            for (int i = 0; i < Pokemon.Count; i++)
            {
                Pokemon[i].Health -= 10;
                if (Pokemon[i].Health <= 0)
                {
                    Pokemon.RemoveAt(i);
                    i--;
                }
            }
        }
    }

    public override string ToString()
    {
        return Name + " " + Badges + " " + Pokemon.Count;
    }
}

