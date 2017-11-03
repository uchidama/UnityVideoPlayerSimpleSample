using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space)) {

			VideoPlayer videoPlayer = this.GetComponent<VideoPlayer> ();

			if (videoPlayer.isPlaying) {
				videoPlayer.Pause();
			} else {
				videoPlayer.Play ();
			}

		}
	}
}
