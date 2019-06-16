using UnityEngine;

[CreateAssetMenu(fileName = "DialogData", menuName = "HolDown/DialogData", order = 0)]
public class DialogData : ScriptableObject {

    public Talk[] talks;
    
}

[System.Serializable]
public class Talk{
    public Sprite icon;
    [TextArea]
    public string text;
}