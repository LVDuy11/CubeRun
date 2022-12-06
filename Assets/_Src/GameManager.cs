using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float score = 0;
    public Transform player;

    public virtual void GetScore()
    {
        this.Score = player.position.z;
    }
    public virtual void IncrementScore()
    {
        UIManager.instance.SetScoreTxt(score.ToString("0"));
    }
    public float Score { get => score; set => score=value; }
}
