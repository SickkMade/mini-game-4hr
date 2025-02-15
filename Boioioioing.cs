using System.Collections;
using UnityEngine;

public class Boioioioing : MonoBehaviour
{

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(Bounce());
    }
    private IEnumerator Bounce(){
        while(true){
            rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
            yield return new WaitForSeconds(3);
        }
    }
}
