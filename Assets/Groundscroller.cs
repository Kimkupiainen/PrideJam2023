using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundscroller : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] float PlayerVelocity;
    // Start is called before the first frame update

    public Transform character;   // Reference to the character's transform
    public float scrollSpeed = 5f;

    private float groundWidth;     // Width of the ground sprite
    private float startPosition;   // Starting x-position of the ground

    private void Start()
    {
        Renderer groundRenderer = GetComponent<Renderer>();
        groundWidth = groundRenderer.bounds.size.x;
        startPosition = transform.position.x;
    }

    private void Update()
    {
        // Calculate the movement based on the character's velocity float value
        float movement = PlayerVelocity * scrollSpeed * Time.deltaTime;

        // Scroll the ground in the opposite direction of the character's velocity
        transform.position += new Vector3(-movement, 0f, 0f);

        // If the ground has scrolled completely, move it back to the starting position
        if (transform.position.x <= startPosition - groundWidth)
        {
            transform.position = new Vector3(startPosition, transform.position.y, transform.position.z);
        }
    }
}
