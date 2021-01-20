using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementIndicatorScript : MonoBehaviour
{
    private ARRaycastManager arRayCastManager = null;
    private GameObject VisualMarker = null;
    [SerializeField] private GameObject PreFab = null;
    private bool PlacementTrigger = true;



    private GameObject PlacemanetObject = null;


    private void Awake()
    {
        arRayCastManager = FindObjectOfType<ARRaycastManager>();
    }


    // Start is called before the first frame update
    void Start()
    {
        PlacementTrigger = true;
        
        VisualMarker = transform.GetChild(0).gameObject;

        VisualMarker.SetActive(false);
    }

 

    
    void Update()
    {
        List<ARRaycastHit> RayCastHitList = new List<ARRaycastHit>();

        arRayCastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), RayCastHitList, TrackableType.Planes);

        if (RayCastHitList.Count > 0)
        {
            this.transform.position = RayCastHitList[0].pose.position;
            this.transform.rotation= RayCastHitList[0].pose.rotation;

            if (!VisualMarker.activeInHierarchy && PlacementTrigger)
            {
                VisualMarker.SetActive(true);
            }
        }

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && PlacementTrigger)
        {
            PlacemanetObject = Instantiate(PreFab, this.transform.position, this.transform.rotation);
            VisualMarker.SetActive(false);
            PlacementTrigger = false;
        }
    }

    public void DestroyPlacementObj()
    {
        Destroy(PlacemanetObject);
        PlacemanetObject = null;
        PlacementTrigger = true;
    }
}
