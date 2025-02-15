using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class EnemyMovement : MonoBehaviour
{
    [SerializeField] SphereCollider attractArea;
    private bool isPlayerInArea = false;
    [SerializeField, Range(0, 5)] private float speed = .25f;
    string playerTag = "player";

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(playerTag))
            isPlayerInArea = true;
    }
    void FixedUpdate()
    {
        if(isPlayerInArea){ //go towards player
            this.transform.position = Vector3.Lerp(this.transform.position, PlayerManager.Instance.playerData.position, speed * Time.fixedDeltaTime);
            var lookPos =  transform.position - PlayerManager.Instance.playerData.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = rotation;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
            isPlayerInArea = false;
    }
}
