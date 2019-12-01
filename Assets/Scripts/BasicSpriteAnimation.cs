using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSpriteAnimation : MonoBehaviour
{

	private SpriteRenderer renderer;
	[SerializeField] private Sprite[] spriteSheet;
	private int index = 0;
	public float interval = 0.2f;
	private float timeTracker;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timeTracker += Time.deltaTime;
        if(timeTracker >= interval)
        {
        	if((index + 1) == spriteSheet.Length)
				index = 0;
			else
				index++;
			
        	renderer.sprite = spriteSheet[index];
        	timeTracker = 0;
        }
    }
}
