using System.Text;

public abstract class Algorithm
{
    public void DisplayElements(string prefix, int[] array) {
        this.DisplayElements(prefix, array, new int[0]);
    }

    public void DisplayElements(int[] array, int[] helper) {
        this.DisplayElements("", array, helper);
    }

    public void DisplayElements(string prefix, int[] array, int[] helper) {

        StringBuilder message = new StringBuilder();
        message.Append($"{prefix}");

        message.Append($"\t array [");
        foreach (int elem in array)
            message.Append($"{elem},");
        message.Remove(message.Length - 1, 1);
        message.Append("] ");

        if (helper.Length != 0) {
            message.Append($"\t helper [");
            foreach (int elem in helper)
                message.Append($"{elem},");
            message.Remove(message.Length - 1, 1);
            message.Append("]");
        }

        Console.WriteLine(message.ToString());
    }

    public void DisplayMessage(string message, bool newLine = true) {
        if (newLine == false)   Console.Write(message);
        else                    Console.WriteLine(message);
    }
}
