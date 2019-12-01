using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{
	public GameObject groundPiece1;
	public float interval = 2f;
	private float timeTracker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeTracker += Time.deltaTime;
        if(timeTracker >= interval)
        {
        	Instantiate(groundPiece1, transform.position, transform.rotation);
        	timeTracker = 0;
        }
    }
}
