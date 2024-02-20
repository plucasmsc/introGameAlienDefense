using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementPlayer : MonoBehaviour

{

    public float speed;
    Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
       animator = GetComponent<Animator>();
        speed = 0.03f;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        
        
        Vector2 movePlayer = new Vector2 (moveHorizontal * speed, moveVertical * speed);
        transform.Translate(movePlayer);   
        if(Input.GetKeyDown(KeyCode.D)){
           animator.Play("Right_Run");

        }
        if  (Input.GetKeyDown(KeyCode.S)){       
            animator.Play("Front_Run");
        }
        if  (Input.GetKeyDown(KeyCode.A)){       
            animator.Play("Left_Run");
        
        }
        if  (Input.GetKeyDown(KeyCode.W)){       
            animator.Play("Back_Run");
        

        }
        //movePlayer = transform.position.normalized;
   
        
    }
    
}
