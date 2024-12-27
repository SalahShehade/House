using UnityEngine;

public class KnightController : MonoBehaviour
{
    [Header("Swing Settings")]
    public float swingAngle = 10f;
    public float swingSpeed = 2f;
    public float swingOffset = 0f;

    [Header("Movement Control")]
    public HorseController horseController;
    private bool isSwinging = false;

    void Start()
    {

        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    void Update()
    {
        if (horseController != null)
        {
            isSwinging = horseController.IsMoving();
        }

        if (isSwinging)
        {
            float swing = Mathf.Sin(Time.time * swingSpeed + swingOffset) * swingAngle;
            transform.localRotation = Quaternion.Euler(0, 0, swing);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
