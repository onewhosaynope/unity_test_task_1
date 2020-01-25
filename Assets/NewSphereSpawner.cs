using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSphereSpawner : MonoBehaviour {

    public GameObject prefab;
    public float prefabSpeed;
    public float mousePositionMultiplier;
    public float mouseZaxis;
    private Camera cam;


    // Start is called before the first frame update
    void Start() {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update() {
        
        if (Input.GetButtonDown("Fire1")) {

            // Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x * mousePositionMultiplier, Input.mousePosition.y * mousePositionMultiplier, cam.nearClipPlane));
            // Vector3 direction = worldMousePosition - cam.transform.position;
            // direction.Normalize();
            // GameObject projectile = Instantiate(prefab, cam.transform.position, cam.transform.rotation) as GameObject;
            // projectile.GetComponent<Rigidbody>().AddForce(direction * prefabSpeed);

            // Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x * mousePositionMultiplier, Input.mousePosition.y * mousePositionMultiplier, cam.nearClipPlane - mouseZaxis));
            // Vector3 direction = worldMousePosition - cam.transform.position;
            // direction.Normalize();
            // GameObject projectile = Instantiate(prefab, cam.transform.position, cam.transform.rotation) as GameObject;
            // projectile.GetComponent<Rigidbody>().AddForce(direction);

        }

        
        if (Input.GetButtonDown("Jump")) {
            
            Instantiate(prefab, cam.transform.position, cam.transform.rotation);
        
        }
    }
}
