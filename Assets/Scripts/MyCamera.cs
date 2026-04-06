using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3(0, 0, -10);

    private void LateUpdate()
    {
        if (player != null)
        {
            Vector3 targetPosition = player.position + offset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);

            transform.position = smoothPosition;
        }
    }
}