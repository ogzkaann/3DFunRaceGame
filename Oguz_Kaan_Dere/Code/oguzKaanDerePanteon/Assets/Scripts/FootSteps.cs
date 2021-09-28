using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{

    [SerializeField] private AudioClip FirstForwardFootStep;
    [SerializeField] private AudioClip SecondForwardFootStep;
    [SerializeField] private AudioClip FirstBackwardFootStep;
    [SerializeField] private AudioClip SecondBackwardFootStep;
    [SerializeField] private AudioClip LandingFootStep;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void StepOneF()
    {
        audioSource.PlayOneShot(FirstForwardFootStep);
    }    
    
    private void StepTwoF()
    {
        audioSource.PlayOneShot(SecondForwardFootStep);
    }

    private void StepOneB()
    {
        audioSource.PlayOneShot(FirstBackwardFootStep);
    }

    private void StepTwoB()
    {
        audioSource.PlayOneShot(SecondBackwardFootStep);
    }

    private void Landing()
    {
        audioSource.PlayOneShot(LandingFootStep);
    }

}
