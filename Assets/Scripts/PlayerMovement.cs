using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float force = 200f;

	private void FixedUpdate()
	{
		Rigidbody player;

		player = GetComponent<Rigidbody>();

		
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.RightArrow))
		{
			player.AddForce( 0f, force * Time.deltaTime, 0f, ForceMode.VelocityChange);
		}

		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.LeftArrow))
		{
			player.AddForce( 0f, -force * Time.deltaTime, 0f, ForceMode.VelocityChange);
		}
	}
}
