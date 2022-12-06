using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    protected PlayerMovement movement;
    GameManager gameManager;
    float index = 0;

    private void Awake()
    {
        this.movement = GetComponent<PlayerMovement>();
        this.gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        gameManager.GetScore();
        gameManager.Score -=(index*10);
        gameManager.IncrementScore();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(index);
            index++;
        }
    }
}
