using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY);
        transform.Translate(movement * Time.fixedDeltaTime * 5f);
    }
}
