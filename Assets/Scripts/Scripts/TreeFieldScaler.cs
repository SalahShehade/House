using UnityEngine;

public class TreeFieldScaler : MonoBehaviour
{
    [Header("Scale Settings")]
    public Vector3 startScale = Vector3.zero;
    public Vector3 endScale = Vector3.one;
    public float scaleDuration = 3f;

    private float elapsedTime = 0f;
    private bool isScalingUp = false;
    private bool isScaling = false;

    void Start()
    {
        transform.localScale = startScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            isScalingUp = !isScalingUp;
            elapsedTime = 0f;
            isScaling = true;
        }

        if (isScaling && elapsedTime < scaleDuration)
        {

            elapsedTime += Time.deltaTime;
            float progress = Mathf.Clamp01(elapsedTime / scaleDuration);

            if (isScalingUp)
            {
                transform.localScale = Vector3.Lerp(startScale, endScale, progress);
            }
            else
            {
                transform.localScale = Vector3.Lerp(endScale, startScale, progress);
            }

            if (elapsedTime >= scaleDuration)
            {
                isScaling = false;
            }
        }
    }
}
