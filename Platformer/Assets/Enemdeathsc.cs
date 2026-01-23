using UnityEngine;

public class enemydeath : MonoBehaviour
{

    private Collider2D _collider;
    [SerializeField]
    GameObject enemy;

    void Start()
    {

        _collider = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _collider.isTrigger = true;
            Destroy(enemy);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _collider.isTrigger = false;
        }
    }
}