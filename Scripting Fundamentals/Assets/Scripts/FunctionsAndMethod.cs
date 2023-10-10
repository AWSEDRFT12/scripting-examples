using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsAndMethod : MonoBehaviour
{   // Function are blocks of code that preform specific tasks and are not associated with any specific object or class. They can be called and executed independently. 

    // Method, on the other hand, are functions that are associated with a specific object or class. They can be called and executed on instances of that object or class.

    // Declare
    private AudioSource _audioSource;
    private float _speed = 10f;
    private int _PlayerHealthAmount = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // Creating some simple functions

    // Function to play a sound effect
    private void PlaySoundEffect(AudioClip soundEffect)
    {
        _audioSource.PlayOneShot(soundEffect);
    }

    // Function to detect Trigger
    private void OnTriggerEnter(Collider other)
    {

    }

    // Creating some simple methods

    // Method to move the enemy
    private void MoveEnemy()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    // Method to return a value 
    public int PlayerHealth(int amount)
    {
        int _PlayerHealthAmount = amount;

        return _PlayerHealthAmount;
    }
}
