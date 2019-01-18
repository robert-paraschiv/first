using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) {
        

        if (collisionInfo.collider.tag == "Obstacle") {
            Debug.Log("WE hit an Obstacle mate ");
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
