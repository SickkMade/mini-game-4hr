
using System.Collections;
using UnityEngine;

public class ReverseCollege : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Stupd());
    }

    private IEnumerator Stupd(){
        while (true){
            yield return new WaitForSeconds(0.25f);
            this.transform.localScale = new(transform.localScale.x, Random.Range(0.1f, 2.5f), transform.localScale.z);
        }
    }
}
