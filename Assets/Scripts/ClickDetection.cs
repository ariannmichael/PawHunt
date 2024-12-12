using UnityEngine;
using UnityEngine.EventSystems;

public class ClickDetection : MonoBehaviour, IPointerDownHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AddPhysics2DRaycaster();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        AnimalMovement am = eventData.pointerCurrentRaycast.gameObject.GetComponent<AnimalMovement>();
        am.HandleClick();
    }

    private void AddPhysics2DRaycaster()
    {
        Physics2DRaycaster physicsRaycaster = FindFirstObjectByType<Physics2DRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
        }
    }   
}
