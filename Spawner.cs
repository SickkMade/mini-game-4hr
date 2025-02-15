using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class Spawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> list = new();

    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn(){
        while(true){
            yield return new WaitForSeconds(3);
            Instantiate(list[Random.Range(0,list.Count-1)]);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("weapon")){
            Destroy(this.gameObject);
        }
    }
}
