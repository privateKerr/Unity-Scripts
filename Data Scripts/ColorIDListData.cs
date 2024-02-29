using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ID Objects/Color ID List Data")]

public class ColorIDListData : ScriptableObject
{
    public List<ColorID> colorIDList;

    public ColorID currentColor;

    private int num;

    public void SetCurrentColorRandomly()
    {
        num = Random.Range(0, colorIDList.Count);
        currentColor = colorIDList[num]; 
        Debug.Log(num);
    }
}
