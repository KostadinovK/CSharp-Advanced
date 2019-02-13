
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

public class Clinic
{
    private int index;
    public string Name { get; set; }

    public Pet[] Rooms { get; set; }

    public Clinic(string name, int rooms)
    {
        if (rooms % 2 == 0)
        {
            throw new ArgumentException();
        }

        Name = name;
        Rooms = new Pet[rooms];
        index = rooms / 2;
    
    }

    public bool Add(Pet pet)
    {
        for (int i = 0; i <= index; i++)
        {
            if (Rooms[index - i] == null)
            {
                Rooms[index - i] = pet;
                return true;
            }

            if (Rooms[index + i] == null)
            {
                Rooms[index + i] = pet;
                return true;
            }
        }

        return false;
    }

    public bool Release()
    {
        for (int i = 0; i < index; i++)
        {
            if (Rooms[index + i] != null)
            {
                Rooms[index + i] = null;
                return true;
            }
        }

        for (int i = 0; i < index; i++)
        {
            if (Rooms[i] != null)
            {
                Rooms[i] = null;
                return true;
            }
        }

        return false;
    }

    public bool HasEmptyRooms()
    {
        return Rooms.Any(x => x == null);
    }

    public string PrintRoom(int room)
    {
        if (Rooms[room] == null)
        {
            return "Room empty";
        }

        return Rooms[room].ToString();

    }


    public string Print()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < Rooms.Length; i++)
        {
            if (Rooms[i] == null)
            {
                sb.AppendLine("Room empty");
            }
            else
            {
                sb.AppendLine(Rooms[i].ToString());
            }
        }

        return sb.ToString();
    }
}

