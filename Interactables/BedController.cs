using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedController : MonoBehaviour {

    //REFERENCES
    private SpriteRenderer render;
    private GameObject musicplayer;
    private MusicController audioSource;

    //SPRITES
    [SerializeField] private Sprite highlight;
    [SerializeField] private Sprite idle;

	// Use this for initialization
	void Start () {
        render = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        render.sprite = highlight;
    }

    private void OnMouseExit()
    {
        render.sprite = idle;
    }

    public void OnMouseDown()
    {
        musicplayer = GameObject.Find("Music Player");
        audioSource = musicplayer.GetComponent<MusicController>();
        audioSource.playMusic();
    }
}
