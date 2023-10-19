using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float _speed = 30f;
    private float _leftbounds = -15f;
    private PlayerController _PlayerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        _PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_PlayerControllerScript.GameOver == false)
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        
        if (transform.position.x < _leftbounds && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
