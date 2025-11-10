using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void LateUpdate()
    {
        if (player == null) return;

        Vector3 newPosition = player.position;
        newPosition.z = transform.position.z; // keep the same height
        transform.position = newPosition;
    }
}
