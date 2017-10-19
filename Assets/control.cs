using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {

	//car body
	public Rigidbody2D car;
	//reference to the wheel joints
	WheelJoint2D[] wheelJoints; 
	//center of mass of the car
	//public Transform centerOfMass;
	//reference tot he motor joint
	JointMotor2D motorBack;  
	//horizontal movement keyboard input
	float dir = 0f; 
	//input for rotation of the car
	float torqueDir = 0f;
	//max fwd speed which the car can move at
	float maxFwdSpeed = -2500;
	//max bwd speed
	float maxBwdSpeed = 2000f;
	//the rate at which the car accelerates
	float accelerationRate = 500;
	//the rate at which car decelerates
	float decelerationRate = 500;
	//how soon the car stops on braking
	float brakeSpeed = 2500f;
	//acceleration due to gravity
	float gravity = 9.81f;
	//angle in which the car is at wrt the ground
	float slope = 0;
	//reference to the wheels
	public Transform rearWheel;
	public Transform frontWheel;
    public GameObject GreenRoad;
    public GameObject Car;
	protected GameObject Carrot;
	public GameObject carrot;

    public Transform groundCheck;
    bool grounded = false;
    float groundradius = 1f;
    public LayerMask whatIsGround;



    // Use this for initialization 
    void Start () { 
		//set the center of mass of the car
		//GetComponent<Rigidbody2D>().centerOfMass = centerOfMass.transform.localPosition;
		//get the wheeljoint components
		wheelJoints = gameObject.GetComponents<WheelJoint2D>(); 
		//get the reference to the motor of rear wheels joint
		motorBack = wheelJoints[0].motor; 
	}  
	
	//all physics based assignment done here
	void FixedUpdate(){
		//add ability to rotate the car around its axis
		torqueDir = Input.GetAxis("Horizontal"); 
		if(torqueDir!=0){ 
			//GetComponent<Rigidbody2D>().AddTorque(1*Mathf.PI*torqueDir, ForceMode2D.Force);
		} 
		else{
			//GetComponent<Rigidbody2D>().AddTorque(0);
		}

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundradius, whatIsGround);

        //determine the cars angle wrt the horizontal ground
        slope = transform.localEulerAngles.z;
		
		//convert the slope values greater than 180 to a negative value so as to add motor speed 
		//based on the slope angle
		if(slope>=180)
			slope = slope - 360;
        //horizontal movement input. same as torqueDir. Could have avoided it, but decided to 
        //use it since some of you might want to use the Vertical axis for the torqueDir
        dir = Input.GetAxis("Horizontal");
        //dir = 0.5f;

        //check if there is any input from the user
        if (Input.GetKey(KeyCode.RightArrow)) {
            //if(motorBack.motorSpeed>0){
            //motorBack.motorSpeed=0;
            //motorBack.motorSpeed = Mathf.Clamp(motorBack.motorSpeed - brakeSpeed*Time.deltaTime, 0, maxFwdSpeed);

            //else
            motorBack.motorSpeed = Mathf.Clamp(motorBack.motorSpeed - (dir * accelerationRate - gravity * Mathf.Sin((slope * Mathf.PI) / 180) * 60) * Time.deltaTime, maxFwdSpeed, maxBwdSpeed);



        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            motorBack.motorSpeed = Mathf.Clamp(motorBack.motorSpeed - (dir * decelerationRate - gravity * Mathf.Sin((slope * Mathf.PI) / 180) * 60) * Time.deltaTime, maxFwdSpeed, maxBwdSpeed);
        }

        else if (Input.GetKey(KeyCode.DownArrow)) { 

            motorBack.motorSpeed = Mathf.Clamp(motorBack.motorSpeed - brakeSpeed * Time.deltaTime, 0, maxFwdSpeed);
        }  


        //apply brakes to the car
        if (Input.GetKey(KeyCode.DownArrow)){
           
            //car.AddForce(new Vector2(0, 4), ForceMode2D.Impulse);
           // motorBack.motorSpeed = Mathf.Clamp(motorBack.motorSpeed - brakeSpeed*Time.deltaTime, 0, maxFwdSpeed); 
		}

        

        if (Input.GetKeyDown(KeyCode.UpArrow)&&grounded){
            //print("grounded is "+grounded);
            car.AddForce(new Vector2(25, 75), ForceMode2D.Impulse);
            //motorBack.motorSpeed = Mathf.Clamp(motorBack.motorSpeed + brakeSpeed*Time.deltaTime, maxFwdSpeed, 0);
            
		}

		foreach (Touch touch in Input.touches){
			if(touch.phase==TouchPhase.Began){
				if(motorBack.motorSpeed<0)
					motorBack.motorSpeed=0;
				else
					motorBack.motorSpeed=-1500;
			}
			else if(touch.phase==TouchPhase.Moved)
				car.AddForce(new Vector2(1, 4), ForceMode2D.Impulse);
			else if(touch.phase==TouchPhase.Stationary)
				motorBack.motorSpeed=500;
		}

		if (Input.GetMouseButtonDown(0)) {
			print ("Left Mouse button clicked");
			if(motorBack.motorSpeed <100 && motorBack.motorSpeed>(-100)){
			Vector3 CarrotPosition = car.transform.position;
			CarrotPosition.y+=2;
			CarrotPosition.x+=2;
			Carrot=Instantiate(carrot,CarrotPosition,Quaternion.identity) as GameObject;
			//carrot.isKinematic=false;
			//carrot.velocity=new Vector2(-150,0);
            //rigi = GetComponent<Rigidbody2D>();
			//Carrot.rigidbody2D.velocity=new Vector2(10,2);
			//Carrot.AddForce(new Vector2(300,247.79f));
			}

		}
		//connect the motor to the joint
		wheelJoints[0].motor = motorBack; 
		
	}
}
