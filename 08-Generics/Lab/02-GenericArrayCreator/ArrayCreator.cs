
public class ArrayCreator
{
    public static T[] Create<T>(int length, T element)
    {
        T[] res = new T[length];

        for (int i = 0; i < length; i++)
        {
            res[i] = element;
        }

        return res;
    }
}

