using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour
{
    public GameObject Target;
    public Vector3 Offset;
    public float LerpSpeed;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = new Vector3(transform.position.x, transform.position.y, -200f + Mathf.Sin(Time.realtimeSinceStartup)*100f);
	    transform.position = Vector3.Lerp(transform.position, Target.transform.position + Offset, LerpSpeed * Time.deltaTime);
	}
}
