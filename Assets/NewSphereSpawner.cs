using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSphereSpawner : MonoBehaviour {

    public GameObject prefab;
    public float prefabSpeed;
    private Camera cam;


    // Start is called before the first frame update
    void Start() {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update() {
        
        if (Input.GetButtonDown("Fire1")) {

            // Vector3 mousePos = Input.mousePosition;
            // GameObject projectile = Instantiate(prefab, cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane)), transform.rotation) as GameObject;
            // projectile.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, 2000));

            // Vector3 mousePos = Input.mousePosition;
            // GameObject projectile = Instantiate(prefab, cam.transform.position, cam.transform.rotation) as GameObject;
            // projectile.GetComponent<Rigidbody>().AddForce(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
            
            // Vector3 mousePos = Input.mousePosition;
            // GameObject projectile = Instantiate(prefab, cam.transform.position, cam.transform.rotation) as GameObject;
            // Vector3 direction = new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane);
            // projectile.GetComponent<Rigidbody>().AddForce(direction * prefabSpeed);
            

            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.x, cam.nearClipPlane));
            Vector3 direction = worldMousePosition - cam.transform.position;
            direction.Normalize();
            GameObject projectile = Instantiate(prefab, cam.transform.position, cam.transform.rotation) as GameObject;
            projectile.GetComponent<Rigidbody>().AddForce(direction * prefabSpeed);


        }

        
        if (Input.GetButtonDown("Jump")) {
            
            Instantiate(prefab, cam.transform.position, cam.transform.rotation);
        
        }
    }
}
