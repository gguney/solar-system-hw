using UnityEngine;

public class Focuser : MonoBehaviour
{
    private Camera mainCamera;

    private int yPivot = 3;
    private float movementStep = 0.1f;
    private GameObject target;
    private bool hasTarget = false;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {  
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;  
            
            if (Physics.Raycast(ray, out hit))
            {
                target = hit.collider.gameObject;
                hasTarget = true;
            }  
        }

        if (hasTarget)
        {
            Vector3 point = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z -40);
            transform.position = point; 
        }
    }
}
