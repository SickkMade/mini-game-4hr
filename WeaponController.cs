using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] Weapon weapon;

    void Update()
    {
        if( Input.GetMouseButtonDown(0)){ //if click
            weapon.SwingBat();
        }
    }
}
