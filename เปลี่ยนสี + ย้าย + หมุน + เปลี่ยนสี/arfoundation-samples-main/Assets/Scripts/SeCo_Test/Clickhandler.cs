using UnityEngine;
using UnityEngine.Events;

public class Clickhandler : MonoBehaviour
{
    [SerializeField]
    UnityEvent clickEvent;

    void OnMouseUpAsButton() {
        clickEvent?.Invoke();
    }
}
