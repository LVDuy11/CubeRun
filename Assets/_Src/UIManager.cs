using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text score;
    public static UIManager instance;
    private void Awake()
    {
        UIManager.instance = this;
    }

    public virtual void SetScoreTxt(string txt)
    {
        if (score)
            score.text = txt;
    }
}
