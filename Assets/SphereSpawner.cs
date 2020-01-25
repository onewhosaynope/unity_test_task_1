using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour {

    Ray ray;
    RaycastHit hit;
    public GameObject prefab;
    public float prefabSpeed;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if(Input.GetButtonDown("Fire1")) {

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit)) {
            
                Vector3 target = new Vector3(hit.point.x, hit.point.y, hit.point.z);
                
                // Debug.DrawLine(Camera.main.transform.position, target, Color.blue, 100);
                // Debug.DrawLine(Camera.main.transform.position, target * prefabSpeed, Color.red, 100);
                
                // Debug.DrawLine(Camera.main.transform.position, target.normalized, Color.green, 100);
                // Debug.DrawLine(Camera.main.transform.position, target.normalized * prefabSpeed, Color.yellow, 100);

                Vector3 test = new Vector3(target.x, target.y, target.z);
                Vector3 testSpeed = new Vector3(target.x, target.y * prefabSpeed, target.z);
                
                GameObject projectile = Instantiate(prefab, Camera.main.transform.position, Camera.main.transform.rotation) as GameObject;
                
                projectile.GetComponent<Rigidbody>().AddForce(testSpeed, ForceMode.Impulse);
            }
        }

        if (Input.GetButtonDown("Jump")) {
        
            Instantiate(prefab, Camera.main.transform.position, Camera.main.transform.rotation);
        
        }
    }
}