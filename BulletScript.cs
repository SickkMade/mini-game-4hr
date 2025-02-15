using System.Collections;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(Death());
    }
    void Update()
    {
        this.transform.position += 5 * Time.deltaTime * Vector3.forward;
    }

    private IEnumerator Death(){
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }
}
