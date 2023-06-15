using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ball : MonoBehaviour
{
    Rigidbody rb;
    public float JumpPower;
    public float MoveSpeed;
    public AudioSource Bounce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Bounce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3 (h,0,v)*MoveSpeed);
    }
    void OnTriggerEnter(Collider target){
        if(target.CompareTag("Jump")){
            Bounce.Play();
            rb.velocity = new Vector3(0,0,0);
            rb.AddForce(Vector3.up * JumpPower);
            
        }
        if(target.CompareTag("Boom")){
            Bounce.Play();
            rb.velocity = new Vector3(0,0,0);
            rb.AddForce(Vector3.up * JumpPower);
        }
        if(target.CompareTag("End")){
            SceneManager.LoadScene("Stage1");
        }
    }
}
