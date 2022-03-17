
using UnityEngine;

public class Followcamera : MonoBehaviour
{
    public Transform player;
    public Vector3 voffset;
    
       
    

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + voffset;
    }
}
