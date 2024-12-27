using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Follow Target")]
    public Transform target;

    [Header("Follow Settings")]
    public Vector3 offset;
    public float followSpeed = 5f;

    [Header("Zoom Settings")]
    public float zoomSpeed = 1f;
    public float minZoomLimit = 2f;

    private Vector3 initialOffset;
    private float currentZoomProgress = 0f;

    void Start()
    {
        if (target == null)
        {
            Debug.LogError("No target assigned for the camera to follow. Please assign a target in the Inspector.");
            return;
        }

        initialOffset = transform.position - target.position;
        offset = initialOffset;
    }

    void LateUpdate()
    {
        if (target != null)
        {
            float distanceToTarget = offset.magnitude;
            if (distanceToTarget > minZoomLimit)
            {
                currentZoomProgress += zoomSpeed * Time.deltaTime;
                currentZoomProgress = Mathf.Clamp01(currentZoomProgress);
                offset = Vector3.Lerp(initialOffset, initialOffset.normalized * minZoomLimit, currentZoomProgress);
            }

            Vector3 targetPosition = target.position + offset;

            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }
}
