using UnityEngine;

public class PositionToggle : MonoBehaviour
{
    public GameObject ObjectToToggle;
    public Transform StartPosition;
    public Transform EndPosition;
    public float Duration = 1f;

    private bool IsAnimating = false;
    private bool AtStart = true;

    private void OnTriggerEnter(Collider other)
    {
        if (IsAnimating) return;

        Debug.Log($"TogglePosition({ObjectToToggle.name}), AtStart={AtStart}");

        Transform destination = StartPosition;
        if(AtStart) destination = EndPosition;

        LeanTween.move(ObjectToToggle, destination, Duration)
            .setEase(LeanTweenType.easeOutBounce)
            .setOnStart(() => IsAnimating = true)
            .setOnComplete(() =>
            {
                IsAnimating = false;
                AtStart = !AtStart;
            });
    }

    void Start()
    {
        // Pose the object in the initial position.
        ObjectToToggle.transform.position = StartPosition.position;
    }
}
