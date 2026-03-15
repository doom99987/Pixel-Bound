using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Player")]
    public Transform player;

    [Header("Follow Settings")]
    public Vector3 offset = new Vector3(0f, 5f, -10f);
    public float smoothSpeed = 5f;

    [Header("Look Settings")]
    public bool lookAtTarget = true;

    void LateUpdate()
    {
        Vector2 desiredPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        if (lookAtTarget)
        {
            transform.LookAt(player);
        }
    }
}
