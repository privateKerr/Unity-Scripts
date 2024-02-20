using UnityEngine;

public class ColorIDBehaviour : IDContainerBehaviour
{
    public ColorIDListData colorIDListDataObj;

    private void Awake()
    {
        idObj = colorIDListDataObj.currentColor;
    }
}
