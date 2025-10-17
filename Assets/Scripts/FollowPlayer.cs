using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (player == null)
        {
            player = GameObject.Find("Vehicle");
        }        
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position +
            new Vector3(offset.x, offset.y, -offset.z);
    }
}
