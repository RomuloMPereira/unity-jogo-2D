using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {

    private float           moverHorizontal;
    private float           moverVertical;
    private Vector2         mover;
    private Rigidbody2D     rb2d;

	[SerializeField]
    private float velocidade;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        moverHorizontal =   Input.GetAxis("Horizontal");
        moverVertical   =   Input.GetAxis("Vertical");
        mover           = new Vector2(moverHorizontal, moverVertical);
		rb2d.velocity   = mover * velocidade;
    }
}
