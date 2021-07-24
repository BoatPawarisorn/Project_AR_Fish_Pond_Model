using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlaceContent : MonoBehaviour {

    [SerializeField]
    GameObject m_PlacementPrefab;
    [SerializeField]
    ARRaycastManager raycastManager;
    [SerializeField]
    GraphicRaycaster raycasterCanvas;
    [SerializeField]
    PhysicsRaycaster raycasterUI;
    [SerializeField]
    PhysicsRaycaster raycasterAR;

    private void Update() {

        if (Input.GetMouseButtonDown(0) && !IsClickOverUI()) {
        
            List<ARRaycastHit> hitPoints = new List<ARRaycastHit>();
            raycastManager.Raycast(Input.mousePosition, hitPoints, TrackableType.Planes);

            if (hitPoints.Count > 0) {
                Pose pose = hitPoints[0].pose;
                Instantiate(m_PlacementPrefab, pose.position, pose.rotation, transform);
            }
        }
    }

    bool IsClickOverUI() {
        //dont place content if pointer is over ui element
        PointerEventData data = new PointerEventData(EventSystem.current) {
            position = Input.mousePosition
        };
        List<RaycastResult> results = new List<RaycastResult>();
        raycasterCanvas.Raycast(data, results);
        raycasterUI.Raycast(data, results);
        raycasterAR.Raycast(data, results);


        results.RemoveAll(r => r.gameObject.tag == "plane");

        return results.Count > 0;
    }
}
