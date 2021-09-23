using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private AudioClip[] audioClips;

        void Start()
        {
            StartCoroutine("playAudio");
        }

        IEnumerator playAudio()
        {
            yield return null;
            for (int i = 0; i < audioClips.Length; i++)
            {
                audioSource.clip = audioClips[i];
                audioSource.Play();
                if (i == 1)
                {
                    audioSource.loop = true;
                }
                while (audioSource.isPlaying)
                {
                    yield return null;
                }
            }
        }
}
