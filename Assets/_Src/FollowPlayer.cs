using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offet = new Vector3(0, 1, -5);

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = this.player.transform.position + this.offet;
    }
}
