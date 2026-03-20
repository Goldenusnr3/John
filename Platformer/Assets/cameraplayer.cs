using UnityEngine;

public class cameraplayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public Transform target;
public Vector3 offset = new Vector3(0, 2, -10);

private void LateUpdate()
{
    transform.position = target.position + offset;
}
}
