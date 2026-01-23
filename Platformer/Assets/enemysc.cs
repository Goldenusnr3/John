using UnityEngine;

public class enemymove : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 6f;
    public Vector3 startPos;

    void Start()
    {

        startPos = transform.position;
    }

    void Update() 
    {
        float newX = startPos.x + Mathf.PingPong(Time.time * speed, distance);
        transform.position =  new Vector3(newX, transform.position.y, transform.position.z);
    }
}

