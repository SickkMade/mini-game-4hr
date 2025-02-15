using System.Collections;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    void Start()
    {
        StartCoroutine(Shoot());
    }
    private IEnumerator Shoot(){
        while (true){
            yield return new WaitForSeconds(.25f);
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.SetPositionAndRotation(this.transform.position, this.transform.rotation);
        }
    }
}
