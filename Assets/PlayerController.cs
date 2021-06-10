using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpForce;
	private float moveInput;

	private Rigidbody2D rb;

	private bool facingRight = true;

	private bool isgrounded;
	public Transform groundCheck;
	public float checkRadius;
	public LayerMask whatIsGround;

	private int extraJump;
	public int extraJumpValue;

	void Start(){
		extraJump = extraJumpValue;
		rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate(){
		isgrounded = Physics2D.OverlapCircle (groundCheck.position, checkRadius, whatIsGround);
		moveInput = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2 (moveInput * speed, rb.velocity.y);

		if(facingRight == false && moveInput > 0){
			Flip();
		} else if(facingRight == true && moveInput < 0){
			Flip();
		}
	}

	void Update(){
		if(isgrounded == true){
			extraJump = extraJumpValue;
		}

		if(Input.GetKeyDown(KeyCode.Space) && extraJump > 0){
			rb.velocity = Vector2.up * jumpForce;
			extraJump--;
		}else if(Input.GetKeyDown(KeyCode.Space) && extraJump == 0 && isgrounded == true){
			rb.velocity = Vector2.up * jumpForce;
		}
	}

	void Flip(){
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;
	}
}
