using UnityEngine;

public class playerdeath : MonoBehaviour
{

    private Collider2D _collider;
    [SerializeField]
    GameObject player;

    void Start()
    {

        _collider = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _collider.isTrigger = true;
            Destroy(player);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            _collider.isTrigger = false;
        }
    }
}