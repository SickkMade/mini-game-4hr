using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyCollisions : MonoBehaviour
{
    [SerializeField]
    private int distance = 250;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("weapon")){
            rb.AddForce(distance * -other.gameObject.transform.forward, ForceMode.Impulse);
        }
    }
}
