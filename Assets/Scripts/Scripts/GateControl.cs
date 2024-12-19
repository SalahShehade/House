using UnityEngine;

public class GateController : MonoBehaviour
{
    private Vector3 closedLocalPosition = new Vector3(0f, 0f, 0f);
    private Quaternion closedLocalRotation = Quaternion.Euler(0f, 0f, 0f);

    private Vector3 openLocalPosition = new Vector3(2.617357f, 1.387449f, 0f);
    private Quaternion openLocalRotation = Quaternion.Euler(0f, 0f, -93.291f);

    private bool isOpen = false;
    public float speed = 2f;

    void Awake()
    {
        transform.localPosition = closedLocalPosition;
        transform.localRotation = closedLocalRotation;

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
            rb.useGravity = false;
        }

        Animator animator = GetComponent<Animator>();
        if (animator != null)
        {
            animator.enabled = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            isOpen = !isOpen;
        }

        if (isOpen)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, openLocalPosition, Time.deltaTime * speed);
            transform.localRotation = Quaternion.Lerp(transform.localRotation, openLocalRotation, Time.deltaTime * speed);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, closedLocalPosition, Time.deltaTime * speed);
            transform.localRotation = Quaternion.Lerp(transform.localRotation, closedLocalRotation, Time.deltaTime * speed);
        }
    }
}
