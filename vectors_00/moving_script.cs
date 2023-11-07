using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    float speed = 1.0f;

    void Start() {
    }

    private void LateUpdate() {
            
            direction = goal.transform.position - this.transform.position;
            if (direction.magnitude > 2) {
                Vector3 velocity = direction.normalized * speed * Time.deltaTime;
              this.transform.position =   this.transform.position + velocity;
            }
            

    }
}