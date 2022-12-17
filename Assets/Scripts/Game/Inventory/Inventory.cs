using System.Collections.Generic;

public class Inventory
{
    private ItemCase[] cells;
    public Inventory()
    {
        cells = new ItemCase[8];
        for (int i = 0; i < cells.Length; i++)
        {
            cells[i] = null;
        }
    }

    public bool AddItem(ItemCase itemCase)
    {
        for (int i = 0; i < cells.Length; i++)
        {
            if (cells[i] == null)
            {
                cells[i] = itemCase;
                return true;
            }
        }
        return false;
    }

    public bool RemoveItem(ItemCase itemCase)
    {
        for (int i = 0; i < cells.Length; i++)
        {
            if (cells[i] == itemCase)
            {
                cells[i] = null;
                return true;
            }
        }
        return false;
    }
}