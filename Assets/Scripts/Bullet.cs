using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    
    private float speed = 10f;
    [SerializeField]

    private string tagToIgnore = "Player";

    private Rigidbody rb;

    private TrailRenderer TrailRenderer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        TrailRenderer = GetComponent<TrailRenderer>();
    }

    private void OnEnable()
    {
        rb.linearVelocity = transform.forward * speed;
        TrailRenderer.Clear();
    }

    private void StopBullet()
    {
        TrailRenderer.Clear();
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagToIgnore)) return;
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        StopBullet();
    }
}
