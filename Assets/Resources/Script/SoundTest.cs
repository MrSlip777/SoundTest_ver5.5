/*
*参考URL　http://qiita.com/amano-kiyoyuki/items/43fa92cce1a44a8030b5
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour {

    public AudioClip audioClip1;

    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
        audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
