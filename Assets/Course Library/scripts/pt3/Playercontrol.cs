using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpforce = 10;
    public float gravitymodifier;
    public bool isground = true;
    public bool gameover = false;

    private Animator playani;
    public ParticleSystem partisystem;
    public ParticleSystem dirtparti;
    public AudioClip jumpsound;
    public AudioClip crashsound;
     
    private AudioSource playeraudio;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        Physics.gravity *= gravitymodifier;

        playani = GetComponent<Animator>();
        playeraudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isground && !gameover)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isground = false;
            playani.SetTrigger("Jump_trig");//animation change from run state to jump state
            dirtparti.Stop();
            playeraudio.PlayOneShot(jumpsound, 1.0f);

        }
         
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isground = true;
            dirtparti.Play();
        }
        else if (collision.gameObject.CompareTag("obstacle"))
        {
            gameover = true;
            //Debug.Log("game over!");
            //print("game over!");
            playani.SetBool("Death_b", true);
            playani.SetInteger("DeathType_int", 1);
            partisystem.Play();
            dirtparti.Stop();
            playeraudio.PlayOneShot(crashsound, 1.0f);

        }
    }
}
