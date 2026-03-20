using UnityEngine;

public  class abstractdeath : MonoBehaviour
{

        protected Collider2D _collider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     protected virtual void Start()
    {

        _collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
     protected void Update()
     {
     
     }
}
