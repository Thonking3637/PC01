using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.Scale(new Vector3(1,1,0));
        transform.position = mousePosition;
    }


    //VersionTWO
    /*
    using UnityEngine;

public class Target : MonoBehaviour
{
	float tx = 0, ty = 0;

	void Update()
	{
		tx += 0.01f;
		ty += 0.01f;
		float x = -5 + 10 * Mathf.PerlinNoise(tx, 0);
		float y = -5 + 10 * Mathf.PerlinNoise(0, ty);
		transform.position = new Vector3(x, y, 0);
	}
}
*/
}
