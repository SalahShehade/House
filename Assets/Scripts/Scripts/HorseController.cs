using UnityEngine;

public class HorseController : MonoBehaviour
{
    [Header("Body Parts")]
    public Transform frontLegRight;
    public Transform frontLegLeft;
    public Transform backLegRight;
    public Transform backLegLeft;
    public Transform neck;
    public Transform head;
    public Transform tail;

    [Header("Movement Settings")]
    public float moveSpeed = 2f;
    public float legSwingSpeed = 2f;
    public float distanceToMove = 20f;
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool isMoving = false;

    [Header("Leg Swing Settings")]
    public float legSwingAngle = 30f;
    [Header("Head, Neck, and Tail Movement")]
    public float neckSwingAngle = 15f;
    public float headSwingAngle = 15f;
    public float tailSwingAngle = 20f;
    public float swaySpeed = 1.5f;

    private float initialXPosition;

    void Start()
    {
        startPosition = transform.position;
        UpdateTargetPosition();

        neck.localPosition = new Vector3(5.934f, 5.194f, 0f);
        neck.localRotation = Quaternion.Euler(0f, 0f, -63.766f);
    }

    void Update()
    {
        UpdateTargetPosition();

        if (Input.GetKeyDown(KeyCode.S))
        {
            isMoving = !isMoving;
        }

        if (isMoving)
        {
            if (Vector3.Distance(transform.position, targetPosition) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            }
            else
            {
                isMoving = false;
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, startPosition) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, startPosition, moveSpeed * Time.deltaTime);
            }
            else
            {
                isMoving = false;
            }
        }

        float legSwing = Mathf.Sin(Time.time * legSwingSpeed) * legSwingAngle;

        frontLegRight.localRotation = Quaternion.Euler(0, 0, legSwing);
        frontLegLeft.localRotation = Quaternion.Euler(0, 0, -legSwing);
        backLegRight.localRotation = Quaternion.Euler(0, 0, -legSwing);
        backLegLeft.localRotation = Quaternion.Euler(0, 0, legSwing);

        float neckSwing = Mathf.Sin(Time.time * swaySpeed) * neckSwingAngle;
        neck.localRotation = Quaternion.Euler(0f, 0f, neckSwing - 63.766f);

        float headSwing = Mathf.Sin(Time.time * swaySpeed + Mathf.PI / 2) * headSwingAngle;
        head.localRotation = Quaternion.Euler(0, 0, headSwing);

        float tailSwing = Mathf.Sin(Time.time * swaySpeed) * tailSwingAngle;
        tail.localRotation = Quaternion.Euler(tailSwing, 0, 0);
    }

    private void UpdateTargetPosition()
    {
        targetPosition = new Vector3(startPosition.x + distanceToMove, startPosition.y, startPosition.z);
    }

    public bool IsMoving()
    {
        return isMoving;
    }
}
